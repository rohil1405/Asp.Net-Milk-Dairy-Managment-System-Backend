/*using PasswordForgotDairy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;
using Form = System.Windows.Forms.Form;

namespace PasswordForgotDairy
{
    public partial class OTP : Form
    {
        String randomCode;
        public static String to;
        public OTP()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            throw new NotImplementedException();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            String from, pass, messageBody;
            Random rs = new Random();
            randomCode = (rs.Next(9999999)).ToString();
            MailMessage message = new MailMessage();
            to = (txtEmail.Text).ToString();
            from = "xxxxxxx@gmail.com";

            pass = "dahmmiotsbtwanwu";
            messageBody = "Your reset code is " + randomCode;

            message.To.Add(to);
            message.Body = messageBody;
            message.Subject = "Password Reseting Code";

            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(from, pass);

            try
            {
                smtp.Send(message);
                System.Windows.Forms.MessageBox.Show("Code Send Successfully");
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }
        private void btnVerify_Click(object sender, EventArgs e)
        {
            if (randomCode == (txtVerify.Text).ToString())
            {
                to = txtEmail.Text;
                resetPass rp = new resetPass();
                this.Hide();
                rp.SHow();
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Wrong Code");
            }
        }
    }

}*/