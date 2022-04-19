using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using WishList.Data;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {


        private readonly ApplicationDbContext _context;
        public ItemController(ApplicationDbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View("Create");
        }

        [HttpPost]
        public IActionResult Create(Models.Item item)
        {
            _context.Items.Add(item);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

//((var|List<Item>).*=\s*?_context.Items(;\s*?return\s*View[(](""Index"",)?.*[.]ToList[(]\s*?[)]\s*?[)];|[.]ToList[(]\s*?[)]\s*?;\s*?return\s*View\s*?[(]\s*?(""Index"",)?.*[)];)|return\s*View\s*?[(]\s*?(""Index"",)?\s*?_context[.]Items[.]ToList[(]\s*?[)]\s*?[)]\s*?[;])\s*?}";


        public IActionResult Index()
        {
        var sample = _context.Items;
            return View("Index", sample.ToList());
        }

        public IActionResult Delete(int id)
        {
            var itemtodel = _context.Items.FirstOrDefault(x => x.Id == id);
            _context.Items.Remove(itemtodel);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
    }
}
