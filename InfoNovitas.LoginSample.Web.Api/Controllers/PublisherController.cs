using InfoNovitas.LoginSample.Services;
using InfoNovitas.LoginSample.Web.Api.Models.Publishers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InfoNovitas.LoginSample.Web.Api.Controllers
{
    [Authorize]
    public class PublisherController : ApiController
    {
        private IPublisherService _publisherService;

        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpGet]
        public IHttpActionResult Get()
        {
            var result = _publisherService.GetPublishers();

            if (result.Success)
                return Ok(result.Publishers);
            else
                return BadRequest("Greska kod dohvacanja nakladnika!");
        }
    }
}
