using ExerciseWeb.Data;
using ExerciseWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace ExerciseWeb.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _dbContext;
        public CategoryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<Category> objCategories = _dbContext.Categories.ToList();
            return View(objCategories);
        }
    }
}
