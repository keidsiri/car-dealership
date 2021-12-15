using Microsoft.AspNetCore.Mvc;
using Dealership.Models;

namespace CarDealership.Controllers
{
    public class HomeController : Controller
    {

      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }

    }
}