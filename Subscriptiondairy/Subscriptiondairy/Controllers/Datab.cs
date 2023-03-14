using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Subscriptiondairy.Controllers
{
    public class Datab : ApiController
    {
        private string constring;
        private SqlConnection conn;
        public Datab()
        {
            constring = @"LAPTOP-1F7TNHDG\SQLEXPRESS ;Initial Catalog='Milk Dairy';Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework";
            conn = new SqlConnection(constring);
            conn.Open();
        }
        public DataSet executeproc(string proc, string[] colvalu)
        {
            string query = "";
            if (!colvalu[4].Equals(""))
            {
                query = "@rows=" + colvalu[1] + ",@pagenum=" + colvalu[0] + ",@DairySubscriptionId=" + colvalu[2] + ",@ColName=" + colvalu[3] + ",@regex=" + colvalu[4];
            }
            else if (!colvalu[3].Equals(""))
            {
                query = "@rows=" + colvalu[1] + ",@pagenum=" + colvalu[0] + ",@DairySubscriptionId=" + colvalu[2] + ",@ColName=" + colvalu[3];
            }
            else if (!colvalu[2].Equals(""))
            {
                query = "@rows=" + colvalu[1] + ",@pagenum=" + colvalu[0] + ",@DairySubscriptionId=" + colvalu[2];
            }
            else if (!colvalu[1].Equals(""))
            {
                query = "@rows=" + colvalu[1] + ",@pagenum=" + colvalu[0];
            }
            else
            {
                query = "@DairySubscriptionId=" + colvalu[0];
            }


            //string query = "@RowsOfPage=" + colvalu[1] + ",@PageNumber=" + colvalu[0] + ",@Column=" + colvalu[2] + ",@pagematch=" + colvalu[3];
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter($"{proc} {query}", conn);
            sqlDataAdapter.SelectCommand.ExecuteNonQuery();
            DataSet ds = new DataSet();
            sqlDataAdapter.Fill(ds);
            return (ds);
        }
    }
}
