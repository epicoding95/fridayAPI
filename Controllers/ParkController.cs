using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProjectAPI.Models;

namespace ProjectAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ParkController : ControllerBase
    {
        private ProjectAPIContext _db = new ProjectAPIContext();

        
        [HttpGet]
        public ActionResult<IEnumerable<Park>> Get()
        {
            return _db.Parks.ToList();
        }

       
        [HttpPost]
        public void Post([FromBody] Park park)
        {
            _db.Parks.Add(park);
            _db.SaveChanges();
        }


        
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Park park)
        {
            park.ParkId = id;
            _db.Entry(park).State = EntityState.Modified;
            _db.SaveChanges();
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var parkToDelete = _db.Parks.FirstOrDefault(x => x.ParkId == id);
            _db.Parks.Remove(parkToDelete);
            _db.SaveChanges();
        }
             
     
    }
}
