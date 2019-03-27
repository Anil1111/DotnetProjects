using System.Collections.Generic;
using LangFeatures.Models;
using Microsoft.AspNetCore.Mvc;

namespace LangFeatures.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //extension methods
            ShoppingCart cart = new ShoppingCart {Products = Product.GetProducts()};

            decimal cartTotal = cart.TotalPrices(); //extension method

            return View("Index", new string[] {$"Total: {cartTotal:C2}"});


            //pattern matching -- #2
            //object[] data = new object[]
            //{
            //    275M,
            //    29.95M,
            //    "apple",
            //    "orange",
            //    100,
            //    10
            //};

            //decimal total = 0;

            //foreach (var obj in data)
            //{
            //    switch (obj)
            //    {
            //        case decimal decimalValue:
            //            total += decimalValue;
            //            break;
            //        case int intValue when intValue > 50:
            //            total += intValue;
            //            break;
            //    }
            //}


            //pattern matching -- #1

            //object[] data = new object[]
            //{
            //    275M, 29.95M, "apple","orange",100,10
            //};
            //decimal total = 0;

            //foreach (var obj in data)
            //{
            //    if (obj is decimal d)
            //    {
            //        total += d;
            //    }
            //}

            //return View("Index", new string[] {$"Total: {total:C2}"});

            //--------------------------------------------
            //using an index initializer
            //Dictionary<string, Product> products = new Dictionary<string, Product>
            //{
            //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M},
            //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M}
            //};

            //return View("Index", products.Keys);

            //----------------------------------------------

            //var results = new List<string>();

            //foreach (var p in Product.GetProducts())
            //{
            //    var name = p?.Name ?? "<No Name>";
            //    var price = p?.Price ?? 0;
            //    var relatedName = p?.Related?.Name ?? "<None>";
            //    results.Add($"Name: {name}, Price: {price}, Related: {relatedName}");
            //}

            //return View(results);
        }
    }
}
