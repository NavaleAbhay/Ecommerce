
using System.Data.Common;
using System.Diagnostics;
using ECommerceApp.Helpers;
using ECommerceApp.Models;
using ECommerceApp.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ECommerceApp.Controllers;

public class DashboardController : Controller
{
    private readonly IDashboardService _dashboardsrv;

    public DashboardController(IDashboardService dashboardsrv)
    {
        _dashboardsrv = dashboardsrv;
    }
    public JsonResult GetDetails()
    {
        var result = _dashboardsrv.GetProductsData();
        return Json(result);
    }
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }
    [HttpGet]

    public IActionResult BarChart()
    {
        return View();
    }

    [HttpGet]
    public IActionResult PieChart()
    {
        return View();
    }
    public IActionResult LineChart()
    {
        return View();
    }
}

