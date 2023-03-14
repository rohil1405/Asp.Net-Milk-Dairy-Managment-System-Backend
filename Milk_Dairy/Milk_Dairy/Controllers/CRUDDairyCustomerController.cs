using Milk_Dairy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Milk_Dairy.Controllers {
    public class CRUDDairyCustomerController:ApiController {
        MilkDairyEntities db = new MilkDairyEntities();

        [HttpGet]
        [Route("api/CRUDDairyCustomer/getAll")]
        public IHttpActionResult getAll() {
            List<DairyCustomer> obj = db.DairyCustomers.ToList();
            return Ok(obj);
            }

        [HttpGet]
        [Route("api/CRUDDairyCustomer/getByID/{id}")]
        public IHttpActionResult getByID(int id) {
            var obj = db.DairyCustomers.Where(model => model.DairyCustomerId == id).FirstOrDefault();
            return Ok(obj);
            }

        [HttpPost]
        [Route("api/CRUDDairyCustomer/InsertDairyCutomer")]
        public IHttpActionResult InsertDairyCutomer(DairyCustomer d) {
            d.Active = (bool)true;
            d.CreatedOn = System.DateTime.Now;
            db.DairyCustomers.Add(d);
            db.SaveChanges();
            return Ok();
            }

        [HttpPut]
        [Route("api/CRUDDairyCustomer/UpdateDairyCutomer")]
        public IHttpActionResult UpdateDairyCutomer(DairyCustomer d) {
            db.Entry(d).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok();
            }


        [HttpDelete]
        [Route("api/CRUDDairyCustomer/DeleteDairyCutomer/{id}")]
        public IHttpActionResult DeleteDairyCutomer(int id) {
            var per = db.DairyCustomers.Where(model => model.DairyCustomerId == id).FirstOrDefault();
            db.Entry(per).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
            }

        }
    }


//ALTER TABLE dbo.DairyCustomers 
//ADD CONSTRAINT df_isActiveC DEFAULT 1 FOR Active
//
