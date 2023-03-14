using Milk_Dairy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Milk_Dairy.Controllers
{
    public class Subscription : ApiController
    {
        MilkDairyEntities db = new MilkDairyEntities();

        [HttpGet]

        public IHttpActionResult Index()
        {
            List<Subscription4> obj = db.Subscription4.ToList();
            return Ok(obj);
        }

        [HttpGet]
        public IHttpActionResult Index(int id)
        {
            var obj = db.Subscription4.Where(model => model.SubscriptionId == id).FirstOrDefault();
            return Ok(obj);
        }

        [HttpPost]
        public IHttpActionResult SubInsert(Subscription4 p)
        {
            p.Active = (bool)true;
            db.Subscription4.Add(p);
            db.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult SubUpadate(Subscription4 s)
        {
            db.Entry(s).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok();
        }


        [HttpDelete]
        public IHttpActionResult SubDelete(int id)
        {
            var per = db.Subscription4.Where(model => model.SubscriptionId == id).FirstOrDefault();
            db.Entry(per).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
        }
    }
}
