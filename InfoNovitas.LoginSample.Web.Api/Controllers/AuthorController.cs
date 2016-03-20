using InfoNovitas.LoginSample.Services;
using InfoNovitas.LoginSample.Web.Api.Models.Authors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InfoNovitas.LoginSample.Web.Api.Controllers
{
    [Authorize]
    public class AuthorController : ApiController
    {
        private IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = _authorService.GetAuthors();

            if (result.Success)
                return Ok(result.Authors);
            else
                return BadRequest("Greska kod dohvacanja autora!");
        }
    }
}
