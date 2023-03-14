using Milk_Dairy.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using System.Web.Security;

namespace Milk_Dairy.Controllers
{
    public class LoginController : ApiController
    {
        [Authorize]

        [HttpGet]

        [Route("api/test/resource1")]

        public IHttpActionResult GetResource1()
        {
            var identity = (ClaimsIdentity)User.Identity;
            //   var MobileNo = identity.Claims.FirstOrDefault(c => c.Type == "MobileNo").Value;
            //   var Password = identity.Claims.FirstOrDefault(c => c.Type == "Password").Value;
            return Ok("Hello: " + identity.Name);
        }

        /*MilkDairyEntities db = new MilkDairyEntities();
        [Authorize]



        [HttpGet]
        public IHttpActionResult FetchAllData()
        {
            test obj = new test();
            obj.connection();
            DataSet ds = obj.selectData();
            var list = ds.Tables[0].AsEnumerable().Select(dataRow => new Dairy
            {
                DairyId = dataRow.Field<int>("DairyId"),
                Password = dataRow.Field<string>("Password"),
                Name = dataRow.Field<string>("Name"),
                MobileNo = dataRow.Field<string>("MobileNo"),
                Email = dataRow.Field<string>("Email")
            }).ToList();



            return Ok(list);
        }



        [HttpPost]
        public IHttpActionResult InsertData([FromBody] registration tempObj)
        {
            test obj = new test();
            obj.connection();



            if (db.registrations.Any(alias => alias.Mobile_No.Equals(tempObj.Mobile_No)))
            {
                return BadRequest("Name already exists.");
            }
            else
            {
                obj.InsertData(tempObj.DairyId, tempObj.Password, tempObj.Name, tempObj.MobileNo, tempObj.Email);
                db.SaveChanges();
                MembershipUser user = Membership.CreateUser(tempObj.Id, tempObj.Password);
            }
            return Ok();
        }*/
    }
}

