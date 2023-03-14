using Milk_Dairy.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Milk_Dairy.Controllers {
    public class SettingsController:ApiController {
        MilkDairyEntities db = new MilkDairyEntities();

        [HttpGet]
        [Route("api/Settings/getAll")]
        public IHttpActionResult getAll() {
            List<PrintAndMessageSetting> obj = db.PrintAndMessageSettings.ToList();
            return Ok(obj);
            }

        [HttpGet]
        [Route("api/Settings/getByID/{id}")]
        public IHttpActionResult getByID(int id) {
            var obj = db.PrintAndMessageSettings.Where(model => model.PrintSettingId == id).FirstOrDefault();
            return Ok(obj);
            }

        [HttpPost]
        [Route("api/Settings/Insert")]
        public IHttpActionResult Insert(PrintAndMessageSetting d) {
            d.Active = (bool)true;
            d.CreatedOn = System.DateTime.Now;
            db.PrintAndMessageSettings.Add(d);
            db.SaveChanges();
            return Ok();
            }

        [HttpPut]
        [Route("api/Settings/Update")]
        public IHttpActionResult Update(PrintAndMessageSetting d) {
            db.Entry(d).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok();
            }


        [HttpDelete]
        [Route("api/Settings/Delete/{id}")]
        public IHttpActionResult Delete(int id) {
            var per = db.PrintAndMessageSettings.Where(model => model.PrintSettingId == id).FirstOrDefault();
            db.Entry(per).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();
            return Ok();
            }

        }
    }

