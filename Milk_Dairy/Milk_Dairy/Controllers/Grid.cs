using Milk_Dairy.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Milk_Dairy.Controllers
{
    public class Grid : ApiController
    {
        [HttpPost]
        [Route("api/Grid/rohil")]

        public IHttpActionResult rohil([FromBody] Test obj)
        {
            if (obj.pagenum > 0 && (obj.rows == 5 || obj.rows == 10 || obj.rows == 20 || obj.rows == 50))
            {
                Subs b = new Subs();

                string[] rs = { obj.pagenum + "", obj.rows + "", obj.column + "", obj.pagematch + "" };

                DataSet d = b.executeproc("milkdairyfilter", rs);

                var list = d.Tables[0].AsEnumerable().Select(dr => new Subscription4
                {
                    SubscriptionId = dr.Field<int>("SubscriptionId"),
                    Subscriptionprice = dr.Field<string>("SubscriptionPrice"),
                    NoOfdays = dr.Field<int>("NoOfDays"),
                    CreatedBy = dr.Field<string>("CreatedBy"),
                    CreatedOn = dr.Field<DateTime>("CreatedOn"),
                    UpdatedBy = dr.Field<string>("UpdatedBy"),
                    UpdatedOn = dr.Field<DateTime>("UpdatedOn"),
                    CreatedIp = dr.Field<int>("CreatedIP"),
                    UpdatedIP = dr.Field<int>("UpdatedIP"),
                    Active = dr.Field<bool>("Active")
                });
                return Ok(list);
            }
            else
            {
                return Ok("Invalid page number");
            }
        }
    }
}

