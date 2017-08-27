﻿using PetApiClient;
using PetApiClient.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace PetProject.Web.Controllers
{
    public class UserController : Controller
    {
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        
        [HttpPost]
        public async Task<ActionResult> Login(Credentials credentials)
        {
            var result = await PetApi.Instance.Login(credentials);

            if (result.Success)
            {
                Session["Vet"] = result.Result.Vet;
                Session["Clinic"] = result.Result.Clinic;
                Session["Owner"] = result.Result.Owner;
                return RedirectToAction("Index", "Vet");
            }
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

    }
}