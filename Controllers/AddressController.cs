using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ECommerceApp.Models;
using ECommerceApp.Services.Interfaces;
using ECommerceApp.Helpers;
namespace ECommerceApp.Controllers;

public class AddressController : Controller
{
    private readonly IAddressService _addresssrv;

    public AddressController(IAddressService addresssrv)
    {
        _addresssrv = addresssrv;
    }


    [HttpGet]
    public IActionResult Search(){
        return View();
    }

    [HttpGet]
    public IActionResult GetAddresses()
    {
        var user =HttpContext.Session.GetObjectFromJson<User>("User");
       var addresses= _addresssrv.GetAddresses(user.UserId);
       return View(addresses);
    }

   

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
