using System;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            //return View(@"\Views\Home\Index.cshtml");
            return View("Index");
        }

        public IActionResult Error()
        {
            return View("Error");
        }
    }
}
