using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class ItemsController : Controller
  {

    [HttpGet("/items")]
    public ActionResult Index()
    {
      List<Car> allItems = Car.GetAll();
      return View(allItems);
    }

    [HttpGet("/items/new")]
    public ActionResult CreateForm()
    {
      return View();
    }

    [HttpPost("/items")]
    public ActionResult Create(string MakeModel, int Price, int Miles)
    {
      Car myItem = new Car(MakeModel, Price, Miles);
      return RedirectToAction("Index");
    }

  }
}