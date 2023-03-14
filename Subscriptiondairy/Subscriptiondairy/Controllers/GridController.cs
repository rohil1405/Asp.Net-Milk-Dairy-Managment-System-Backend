using Subscriptiondairy.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Subscriptiondairy.Controllers
{
    public class GridController : ApiController
    {
        [HttpPost]
        [Route("api/Grid/rohil")]

        public IHttpActionResult rohil([FromBody] Test obj)
        {
            if (obj.pagenum > 0 && (obj.rows == 5 || obj.rows == 10 || obj.rows == 20 || obj.rows == 50))
            {
                Datab b = new Datab();

                string[] rs = { obj.pagenum + "", obj.rows + "", obj.column + "", obj.pagematch + "" };

                DataSet d = b.executeproc("milkdairyfilter", rs);

                var list = d.Tables[0].AsEnumerable().Select(dr => new DairySubscription
                {
                    DairySubscriptionId = dr.Field<int>("[DairySubscriptionId"),
                    SubscriptionId = dr.Field<int>("SubscriptionId"),
                    DairyId = dr.Field<int>("DairyId"),
                    StartDate = dr.Field<string>("StartDate"),
                    EndDate = dr.Field<string>("EndDate"),
                    PaidAmount = dr.Field<string>("PaidAmount"),
                    SubscriptionPrice = dr.Field<string>("SubscriptionPrice"),
                    IsPaid = dr.Field<bool>("IsPaid"),
                    MobileId = dr.Field<int>("MobileId"),
                    SyncState = dr.Field<bool>("SyncState"),
                    CreatedBy = dr.Field<string>("CreatedBy"),
                    CreatedOn = dr.Field<DateTime>("CreatedOn"),
                    UpdatedBy = dr.Field<string>("UpdatedBy"),
                    UpdatedOn = dr.Field<DateTime>("UpdatedOn"),
                    CreatedIP = dr.Field<int>("CreatedIP"),
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
