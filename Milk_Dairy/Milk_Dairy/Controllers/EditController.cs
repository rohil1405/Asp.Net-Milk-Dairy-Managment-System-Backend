using Milk_Dairy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Milk_Dairy.Controllers
{
    public class EditController : ApiController
    {
        MilkDairyEntities rs = new MilkDairyEntities();

        [HttpGet]

        public IHttpActionResult Dairy()
        {

            List<Dairy4> obj = rs.Dairy4.ToList();
            return Ok(obj);

        }

        [HttpGet]
        public IHttpActionResult EditDairy(int id)
        {
            var obj = rs.Dairy4.Where(model => model.DairyId == id).FirstOrDefault();
            return Ok(obj);
        }
    }
}

