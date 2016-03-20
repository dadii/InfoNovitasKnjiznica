﻿using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace InfoNovitas.LoginSample.Authentication
{
    public class MyUser : IdentityUser<int, MyLogin, MyUserRole, MyClaim>
    {
        #region properties

        public string ActivationToken { get; set; }

        public string PasswordAnswer { get; set; }

        public string PasswordQuestion { get; set; }

        #endregion

        #region methods

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(MyUserManager userManager)
        {
            var userIdentity = await userManager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }

        #endregion
    }
}
