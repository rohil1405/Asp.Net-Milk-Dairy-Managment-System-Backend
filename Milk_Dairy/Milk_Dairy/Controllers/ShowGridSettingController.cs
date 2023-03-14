using Milk_Dairy.Models;
using System;
using System.Data;
using System.Linq;
using System.Web.Http;

namespace Milk_Dairy.Controllers {
    public class ShowGridSettingController:ApiController {
        [HttpPost]
        [Route("api/ShowGridSetting/showfun")]
        public IHttpActionResult showfun([FromBody] Test obj) {
            if(obj.pagenum > 0 && (obj.rows == 5 || obj.rows == 10 || obj.rows == 20 || obj.rows == 50))
                {
                Datab b = new Datab();
                string[] colva = { obj.pagenum + "",obj.rows + "",obj.PrintSettingId + "",obj.column + "",obj.pagematch + "" };
                DataSet d = b.executeproc("SettingsSHOW",colva);
                var list = d.Tables[0].AsEnumerable().Select(dr => new PrintAndMessageSetting
                    {
                    PrintSettingId = dr.Field<int>("PrintSettingId"),
                    DairyId = dr.Field<int>("DairyId"),
                    PrintMethod = dr.Field<string>("PrintMethod"),
                    PrintBoldFont = dr.Field<bool>("PrintBoldFont"),
                    PaymentRoundOfff = dr.Field<bool>("PaymentRoundOfff"),
                    TranslateEverything = dr.Field<bool>("TranslateEverything"),
                    ShowLink = dr.Field<bool>("ShowLink"),
                    ShowSNFCLR = dr.Field<bool>("ShowSNFCLR"),
                    ShowRSLTR = dr.Field<bool>("ShowRSLTR"),
                    ShowKGFAT = dr.Field<bool>("ShowKGFAT"),
                    SMSMethod = dr.Field<string>("SMSMethod"),
                    MobileId = dr.Field<int>("MobileId"),
                    SyncState = dr.Field<bool>("SyncState"),
                    CreatedBy = dr.Field<string>("CreatedBy"),
                    CreatedOn = dr.Field<DateTime>("CreatedOn"),
                    UpdatedBy = dr.Field<string>("UpdatedBy"),
                    UpdatedOn = dr.Field<DateTime>("UpdatedOn"),
                    CreatedIp = dr.Field<int>("CreatedIP"),
                    UpdatedIp = dr.Field<int>("UpdatedIP"),
                    Active = dr.Field<bool>("Active"), 

                    });
                return Ok(list);
                }
            else
                {
                return Ok("Invalid page number size or row size");
                }
            }
        }
    }
