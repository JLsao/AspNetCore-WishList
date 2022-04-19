using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using WishList.Data;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {



        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        /*
        private readonly ApplicationDbContext (context)
            {
            _context = context;
            }

        [HttpPost]
        public IActionResult Create(WishList.Models.Item item)
        {

            _context.Items.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");

        }
        */
    }
}
