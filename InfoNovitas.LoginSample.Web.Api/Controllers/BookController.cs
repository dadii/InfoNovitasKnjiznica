using InfoNovitas.LoginSample.Services;
using InfoNovitas.LoginSample.Web.Api.Models.Books;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InfoNovitas.LoginSample.Web.Api.Controllers
{
    [Authorize]
    public class BookController : ApiController
    {
        private IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = _bookService.GetBooks();

            if (result.Success)
                return Ok(result.Books);
            else
                return BadRequest("Greska kod dohvacanja knjiga!");
        }
    }
}
