using Subscriptiondairy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Subscriptiondairy.Controllers
{
    public class MilkDairyController : ApiController
    {
        Mlik_DairyEntities1 rs = new Mlik_DairyEntities1();

        [HttpGet]
        public IHttpActionResult Index()
        {
            List<DairySubscription> obj = rs.DairySubscriptions.ToList();
            return Ok(obj);
        }

        [HttpGet]
        public IHttpActionResult Index(int id)
        {
            var obj = rs.DairySubscriptions.Where(model => model.SubscriptionId == id).FirstOrDefault();
            return Ok(obj);
        }

        [HttpPost]
        public IHttpActionResult SubInsert(DairySubscription p)
        {
            p.Active = (bool)true;
            p.CreatedOn = System.DateTime.Now;
            rs.DairySubscriptions.Add(p);
            rs.SaveChanges();
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult SubUpadate(DairySubscription s)
        {
            rs.Entry(s).State = System.Data.Entity.EntityState.Modified;
            rs.SaveChanges();
            return Ok();
        }


        [HttpDelete]
        public IHttpActionResult SubDelete(int id)
        {
            var per = rs.DairySubscriptions.Where(model => model.SubscriptionId == id).FirstOrDefault();
            rs.Entry(per).State = System.Data.Entity.EntityState.Deleted;
            rs.SaveChanges();
            return Ok();
        }

    }
}
