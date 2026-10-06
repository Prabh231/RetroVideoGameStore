using Microsoft.AspNetCore.Mvc;
using RetroVideoGameStore.Models;

namespace RetroVideoGameStore.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>();
            for(int i = 1; i <= 10; i++)
            {
                categories.Add(new Category { Id = i, Name = "Category " + i });
            }
            return View(categories);
        }
        public IActionResult Browse(string CategoryName)
        {
            ViewBag.categoryName = CategoryName;
            return View();
        }
        public IActionResult Create()
        {
            //display form to add new category
            return View();
        }
    }
}
