using HolidayChallenge.Services;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HolidayChallenge.WebAPI.Controllers
{
    [Authorize]
    public class PresentController : ApiController
    {
        private PresentService CreatePresentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var presentService = new PresentService(userId);
            return presentService;
        }
        [HttpGet]
        public IHttpActionResult Get()
        {
            PresentService presentService = CreatePresentService();
            var presents = presentService.GetPresents();
            return Ok(presents);
        }
    }
}
