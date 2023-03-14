using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PasswordForgotDairy.Models;
//using System.Web.HttpContextBase;

namespace PasswordForgotDairy.Controllers
{
    public class GenrateOTP : System.Web.Mvc.Controller
    {
        public IHttpActionResult Index()
        {
            return (IHttpActionResult)View();
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult GenerateOtp()
        {
            return (IHttpActionResult)View();
        }

        [System.Web.Http.HttpPost]
        public IHttpActionResult SendOtp()
        {
            string num = "0123456789";
            int len = num.Length;
            string otp = string.Empty;

            int otpDigit = 5;
            string finalDigit;
            int getIndex;

            for(int i = 0; i < otpDigit; i++)
            {
                do
                {
                    getIndex = new Random().Next(0, len);
                    finalDigit = num.ToCharArray()[getIndex].ToString();
                }
                while (otp.IndexOf(finalDigit) != -1);
                {
                    otp += finalDigit;
                }
            }

            return (IHttpActionResult)View();

        }

        public IHttpActionResult Contact()
        {
            ViewData["message"] = "your Contact page.";
            return (IHttpActionResult)View();
        }

        public IActionResult Error()
        {
            ViewData["RequestId"] = Activity.Current?.Id;
            return (IActionResult)View();
        }
       
    }
}