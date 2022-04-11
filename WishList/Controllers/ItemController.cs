using Microsoft.AspNetCore.Mvc;

namespace WishList.Controllers
{
    public class ItemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
