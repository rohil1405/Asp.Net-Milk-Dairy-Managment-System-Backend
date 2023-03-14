using Milk_Dairy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Milk_Dairy.Controllers
{
    public class ChangePasswordController : ApiController
    {
        MilkDairyEntities dairy = new MilkDairyEntities();

        [HttpGet]

        public IHttpActionResult Dairy()
        {
            List<Dairy4> milk = dairy.Dairy4.ToList();
            return Ok(milk);
        }

        [HttpPut]

        public IHttpActionResult ChangepasswordDairy(Dairy4 R)
        {
            dairy.Entry(R).State = System.Data.Entity.EntityState.Modified;
            dairy.SaveChanges();
            return Ok();
        }
    }
}
