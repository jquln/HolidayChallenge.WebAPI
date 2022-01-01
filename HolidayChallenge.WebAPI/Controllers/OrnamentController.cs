using HolidayChallenge.Models.OrnamentModels;
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
    public class OrnamentController : ApiController
    {
        private OrnamentService CreateOrnamentService()
        {
            var userId = Guid.Parse(User.Identity.GetUserId());
            var clientService = new OrnamentService(userId);
            return clientService;
        }
        public IHttpActionResult Get()
        {
            OrnamentService ornamentService = CreateOrnamentService();
            var ornaments = ornamentService.GetOrnaments();
            return Ok(ornaments);
        }
        public IHttpActionResult Post(OrnamentCreate ornament)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var service = CreateOrnamentService();

            if (!service.CreateOrnament(ornament))
                return InternalServerError();

            return Ok();
        }

        public IHttpActionResult Get(int id)
        {
            OrnamentService ornamentService = CreateOrnamentService();
            var ornament = ornamentService.GetOrnamentById(id);
            return Ok(ornament);
        }

        //public IHttpActionResult Put(OrnamentEdit ornament)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);
        //    var service = CreateOrnamentService();

        //    if (!service.UpdateOrnament(ornament))
        //        return InternalServerError();
        //    return Ok();
        //}

    }
}
