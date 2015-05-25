﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Pollyana.ViewModels;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;


namespace Pollyana.Controllers
{
    [AllowAnonymous]
    public class AuthController : Controller
    {
        private readonly UserManager<AppUser> userManager;

        public AuthController() : this (Startup.UserManagerFactory.Invoke())
        { }

        public AuthController(UserManager<AppUser> userManager)
        {
            this.userManager = userManager;
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing && userManager != null)
            {
                userManager.Dispose();
            }

            base.Dispose(disposing);
        }

        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<ActionResult> Register(RegisterModel model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            var user = new AppUser
            {
                UserName = model.Email,
                Country = model.Country
            };

            var result = await userManager.CreateAsync(user, model.Password);

            if(result.Succeeded)
            {
                await SignIn(user);
                return RedirectToAction("index", "home");
            }

            foreach(var error in result.Errors)
            {
                ModelState.AddModelError("", error);
            }

            return View();
        }

        [HttpGet]
        public ActionResult LogIn(string returnUrl)
        {
            var model = new LoginModel
            {
                ReturnUrl = returnUrl
            };
            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> LogIn(LoginModel model)
        {
            if(!ModelState.IsValid)
                return View();

            //if(model.Email == "admin@admin.com" && model.Password == "password")
            //{
            //    var identity = new ClaimsIdentity(new[] {
            //        new Claim(ClaimTypes.Name, "Ben"),
            //        new Claim(ClaimTypes.Email, "a@b.com"),
            //        new Claim(ClaimTypes.Country, "England")
            //    },
            //    "ApplicationCookie");

            //    var ctx = Request.GetOwinContext();
            //    var authManager = ctx.Authentication;

            //    authManager.SignIn(identity);

            //    return Redirect(GetRedirectUrl(model.ReturnUrl));
            //}

            var user = await userManager.FindAsync(model.Email, model.Password);

            if(user != null)
            {
                var identity = await userManager.CreateIdentityAsync(
                    user, DefaultAuthenticationTypes.ApplicationCookie);

                GetAuthenticationManager().SignIn(identity);

                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }



            ModelState.AddModelError("", "Invalid credentials");
            return View();
        }

        private async Task SignIn(AppUser user)
        {
            var identity = await userManager.CreateIdentityAsync(user, DefaultAuthenticationTypes.ApplicationCookie);

            GetAuthenticationManager().SignIn(identity);
        }

        private IAuthenticationManager GetAuthenticationManager()
        {
            var ctx = Request.GetOwinContext();
            return ctx.Authentication;
        }

        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
            return RedirectToAction("index", "home");
        }

        private string GetRedirectUrl(string returnUrl)
        {
            if(string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("index", "home");
            }

            return returnUrl;
        }
    }

}

