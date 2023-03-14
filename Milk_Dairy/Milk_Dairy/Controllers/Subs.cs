using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Milk_Dairy.Controllers
{
    public class Subs : ApiController
    {
        private string constring;
        private SqlConnection conn;
        public Subs()
        {
            constring = @"Data Source = DESKTOP-TA8BLLL\SQLEXPRESS;Initial Catalog = MilkDairy;user id = sa;password=Jainish@123;";
            conn = new SqlConnection(constring);
            conn.Open();
        }
        public DataSet executeproc(string proc, string[] colvalu)
        {

            string query = "";
            if (!colvalu[4].Equals(""))
            {
                query = "@RowsOfPage=" + colvalu[1] + ",@PageNumber=" + colvalu[0] + ",@SubscriptionId=" + colvalu[2] + ",@Column=" + colvalu[3] + ",@pagematch=" + colvalu[4];
            }
            else if (!colvalu[3].Equals(""))
            {
                query = "@RowsOfPage=" + colvalu[1] + ",@PageNumber=" + colvalu[0] + ",@SubscriptionId=" + colvalu[2] + ",@Column=" + colvalu[3];
            }
            else if (!colvalu[2].Equals(""))
            {
                query = "@RowsOfPage=" + colvalu[1] + ",@PageNumber=" + colvalu[0] + ",@SubscriptionId=" + colvalu[2];
            }
            else if (!colvalu[1].Equals(""))
            {
                query = "@RowsOfPage=" + colvalu[1] + ",@PageNumber=" + colvalu[0];
            }
            else
            {
                if (proc.Equals("DairyCustomersSHOW") || proc.Equals("DairyCustomersSHOWL"))
                    query = "@DairyId=" + colvalu[0];
                else if (proc.Equals("SettingsSHOW") || proc.Equals("SettingsSHOWL"))
                    query = "@PrintSettingId=" + colvalu[0];
                else if (proc.Equals("milkdairyfilter"))
                    query = "@SubscriptionId=" + colvalu[0];
                }

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"{proc} {query}", conn);
            sqlDataAdapter.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            return (ds);
        }
    }
}

