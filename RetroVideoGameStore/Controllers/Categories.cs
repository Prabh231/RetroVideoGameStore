using Microsoft.AspNetCore.Mvc;
using RetroVideoGameStore.Models;

namespace RetroVideoGameStore.Controllers
{
    public class Categories : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>();
            for(int i = 1; i <= 10; i++)
            {
                categories.Add(new Category { Id = i, Name = "Category " + i });
            }
            return View();
        }
        public IActionResult Browse(string CategoryName)
        {
            ViewBag.categoryName = CategoryName;
            return View();
        }
    }
}
