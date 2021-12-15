using Microsoft.AspNetCore.Mvc;
using Dealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allItems = Car.GetAll();
      return View(allItems);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/cars")]  //POST method sends data to the serve take data from user
    public ActionResult Create(string makeModel, int price, int miles)
    {
      Car myCar = new Car(makeModel, price, miles);
      return RedirectToAction("Index");
    }

    [HttpPost("/cars/delete")]
    public ActionResult DeleteAll()
    {
      Car.ClearAll();
      return View();
    }

  }
}