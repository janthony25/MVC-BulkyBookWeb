using Microsoft.AspNetCore.Mvc;
using MVC_BulkyCompleteCRUD.Data;
using MVC_BulkyCompleteCRUD.Models;

namespace MVC_BulkyCompleteCRUD.Controllers
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
            IEnumerable<Category> objCategoryList = _db.Categories;
            return View(objCategoryList);
        }

        // GET
        public IActionResult Create()
        {
            return View();
        }

        //POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category obj)
        {
            return View();
        }



    }
}
