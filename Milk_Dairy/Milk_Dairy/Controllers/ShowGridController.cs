using Milk_Dairy.Models;
using System;
using System.Data;
using System.Web.Http;

namespace Milk_Dairy.Controllers {
    public class ShowGridController:ApiController {
        [HttpPost]
        [Route("api/ShowGrid/showfun")]
        public IHttpActionResult showfun([FromBody] Test obj) {
            if(obj.pagenum > 0 && (obj.rows == 5 || obj.rows == 10 || obj.rows == 20 || obj.rows == 50))
                {
                Datab b = new Datab();
                string[] colva = { obj.pagenum + "",obj.rows + "",obj.dairyid + "",obj.column + "",obj.pagematch + "" };
                DataSet d = b.executeproc("DairyCustomersSHOW",colva);
                var list = d.Tables[0].AsEnumerable().Select(dr => new DairyCustomer
                    {
                    DairyCustomerId = dr.Field<int>("DairyCustomerId"),
                    CustomerName = dr.Field<string>("CustomerName"),
                    DairyId = dr.Field<int>("DairyId"),
                    MobileNo = dr.Field<string>("MobileNo"),
                    MilkType = dr.Field<string>("MilkType"),
                    CustomerNo = dr.Field<string>("CustomerNo"),
                    Email = dr.Field<string>("Email"),
                    Address = dr.Field<string>("Address"),
                    City = dr.Field<string>("City"),
                    State = dr.Field<string>("State"),
                    Country = dr.Field<string>("Country"),
                    BankAcNo = dr.Field<string>("BankAcNo"),
                    BankIfsc = dr.Field<string>("BankIfsc"),
                    DOB = dr.Field<string>("DOB"),
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
                return Ok("Invalid page number size or row size");
                }
            }
        }
    }
//id optional, if given-show only of id
//grid-page no,no of row given


//list-dairyid is provided compulsory
//display all entries of given dairy id