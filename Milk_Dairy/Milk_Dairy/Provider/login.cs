using Microsoft.Owin.Security.OAuth;
using Milk_Dairy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Security;

namespace Milk_Dairy.Provider
{
    public class login : OAuthAuthorizationServerProvider
    {
        
        public override async Task ValidateClientAuthentication(OAuthValidateClientAuthenticationContext context)
        {
            context.Validated();
        }
        public override async Task GrantResourceOwnerCredentials(OAuthGrantResourceOwnerCredentialsContext context)
        {
            var identity = new ClaimsIdentity(context.Options.AuthenticationType);

            if (Membership.ValidateUser(context.UserName, context.Password))
            {
                identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
                context.Validated(identity);
            }
            else
            {
                context.SetError("invalid_grant", "Provided username and password is incorrect");
                return;
            }
            /* using (MilkDairyEntities rs = new MilkDairyEntities())
             {
                 var user = rs.ValidateUser(context.UserName, context.Password);
                 if (user == "false")
                 {
                     context.SetError("invalid_grant", "provide MobileNo and password is incorrect");
                     return;
                 }
                 *//*var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                 identity.AddClaim(new Claim(ClaimTypes.MobilePhone, user.MobileNo));
                 identity.AddClaim(new Claim("Password", user.Password));
 *//*
                 var identity = new ClaimsIdentity(context.Options.AuthenticationType);
                 //  identity.AddClaim(new Claim(ClaimTypes.City, "Anand"));
                 identity.AddClaim(new Claim(ClaimTypes.Name, "RKWST"));
                 //identity.AddClaim(new Claim("Email", user.UserEmailID));  


                 context.Validated(identity);

             }*/


            /* using (MilkDairyEntities rs = new MilkDairyEntities()))
                     {
                 if (rs.credentials.Any(alias => alias.UserName.Equals(context.UserName,
            StringComparison.OrdinalIgnoreCase) && alias.Password.Equals(context.Password)))
                 {
                     identity.AddClaim(new Claim(ClaimTypes.Role, "user"));
                     identity.AddClaim(new Claim(ClaimTypes.Name, context.UserName));
                     context.Validated(identity);
                 }
             }*/

        }
    }
}