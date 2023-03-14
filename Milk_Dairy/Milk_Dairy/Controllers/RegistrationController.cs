using Milk_Dairy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Milk_Dairy.Controllers
{
    public class RegistrationController : ApiController
    {
        MilkDairyEntities db = new MilkDairyEntities();

        [HttpGet]

        public IHttpActionResult Dairy()
        {
            List<Dairy4> obj = db.Dairy4.ToList();
            return Ok(obj);
        }

        [HttpPost]

        public IHttpActionResult DairyInsert(Dairy4 d)
        {
            db.Dairy4.Add(d);
            db.SaveChanges();
            return Ok();
        }
    }
}
