using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Roomie.Models;

namespace Roomie.Controllers.Api
{
    public class RoomiesController : ApiController
    {
        private ApplicationDbContext _context;

        public RoomiesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/roomies
        public IHttpActionResult GetRoomies()
        {
            var roomie = _context.RoomieModel.ToList();

            return Ok(roomie);
        }

        // GET /api/roomies/1
        public IHttpActionResult GetRoomie(int id)
        {
            var roomie = _context.RoomieModel.SingleOrDefault(c => c.Id == id);

            if (roomie == null)
                return NotFound();

            return Ok(roomie);
        }

        // POST /api/roomies
        [HttpPost]
        public IHttpActionResult CreateRoomie(RoomieModel roomie)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.RoomieModel.Add(roomie);
            _context.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + roomie.Id), roomie);
        }
    }
}
