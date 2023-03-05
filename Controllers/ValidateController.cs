using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommerceApp.Models;
using ECommerceApp.Services.Interfaces;
using ECommerceApp.Helpers;

namespace ECommerceApp.Controllers;
public class ValidateController : Controller
{
     private readonly IUserService _usersrv;
public  ValidateController(IUserService srv)
    {
        this._usersrv = srv;
    }

     public IActionResult Login()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Login(User user)
    {
     bool status=  _usersrv.ValidateUser(user);
     if(status){
        HttpContext.Session.SetObjectAsJson("User", user);

        return RedirectToAction("ShowAll","Product");
     }
      return RedirectToAction("Invalid","Validate");
       }

          public IActionResult Valid()
    {
        return View();
    }

      public IActionResult InValid()
    {
        return View();
    }
}