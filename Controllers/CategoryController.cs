using Microsoft.AspNetCore.Mvc;
using Startproject.Data;
using Startproject.Models;

namespace Startproject.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Category> objCategory = _db.Categories;
            return View(objCategory);
        }
        //Get
        public IActionResult Create()
        {
            return View();
        }
    }
}
