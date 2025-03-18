using ExerciseRezor_temp.Data;
using ExerciseRezor_temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExerciseRezor_temp.Pages.Categories
{
    [BindProperties]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public Category Category { get; set; }
        public CreateModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet()
        {
        }

        public IActionResult OnPost(Category category)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return RedirectToPage("Index");
        }
    }
}
