using Milk_Dairy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Milk_Dairy.Controllers
{
    public class UpdateDairyNameController : ApiController
    {
        MilkDairyEntities db = new MilkDairyEntities();

        [HttpGet]

        public IHttpActionResult Dairy()
        {
            List<Dairy4> obj = db.Dairy4.ToList();
            return Ok(obj);
        }

        [HttpPut]

        public IHttpActionResult DairyUpdate(Dairy4 d)
        {
            db.Entry(d).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }
    }
}
