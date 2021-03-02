using Microsoft.AspNetCore.Mvc;

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

// using Microsoft.AspNetCore.Mvc;
// using CarDealership.Models;
// using System.Collections.Generic;

// namespace CarDealership.Controllers
// {
//   public class HomeController : Controller
//   {
//     [HttpGet("/")]
//     // public ActionResult Index()
//     // {

//     //   List<Item> allItems = Item.GetAll();
//     //   return View(allItems);
//     // }

//     [Route("/hello")]
//     public string Hello() { return "Hello friend!"; }

//     [Route("/goodbye")]
//     public string Goodbye() { return "Goodbye friend."; }

//     [Route("/")]
//     public ActionResult Index()
//     {
//       Item starterItem = new Item("Add a car to the dealer database");
//       return View(starterItem);
//     }

//     [Route("/items/new")]
//     public ActionResult CreateForm()
//     {
//       return View();
//     }

//     [Route("/items")]
//     public ActionResult Create(string description)
//     {
//       Item myItem = new Item(description);
//       return View("Index", myItem);
//     }

//     // [HttpPost("/items")]
//     // public ActionResult Create(string description)
//     // {
//     //   Item myItem = new Item(description);
//     //   return RedirectToAction("Index");
//     // }
//   }
// }