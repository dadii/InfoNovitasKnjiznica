using InfoNovitas.LoginSample.Services;
using InfoNovitas.LoginSample.Web.Api.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InfoNovitas.LoginSample.Web.Api.Controllers
{
    [Authorize]
    public class UserController : ApiController
    {
        private IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = _userService.GetUsers();

            if (result.Success)
                return Ok(result.Users);
            else
                return BadRequest("Greska kod dohvacanja korisnika!");
        }
    }
}
