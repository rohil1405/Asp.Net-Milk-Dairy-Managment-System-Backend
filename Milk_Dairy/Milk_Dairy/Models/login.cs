using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Milk_Dairy.Models
{
    public class login : IDisposable
    {
        /*MilkDairyEntities context = new MilkDairyEntities();

        public Dairy4 ValidateUser(string mobileno, string password)
        {
            return context.Dairy4.FirstOrDefault(user => user.MobileNo.Equals(mobileno, StringComparison.OrdinalIgnoreCase) && user.Password == password);
        }

        public void Dispose()
        {
            context.Dispose();
        }*/

        public string ValidateUser(string mobileno, string password)
        {
            string MobileNo = mobileno == "9099968144" ? "Valid" : "InValid";
            string Password = password == "1234" ? "Valid" : "InValid";

            if (MobileNo == "Valid" && Password == "Valid")
                return "true";
            else
                return "false";
        }
        public void Dispose()
        {
            //Dispose();  
        }
    }
}