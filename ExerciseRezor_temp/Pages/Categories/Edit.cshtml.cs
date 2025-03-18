using ExerciseRezor_temp.Data;
using ExerciseRezor_temp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExerciseRezor_temp.Pages.Categories
{
    [BindProperties]
    public class EditModel : PageModel
    {
        private readonly ApplicationDbContext _dbContext;
        public Category Category { get; set; }
        public EditModel(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void OnGet(int? id)
        {
            if(id != null && id != 0)
            {
                Category = _dbContext.Categories.Find(id);
            }
        }

        public IActionResult OnPost(Category category)
        {
            if(ModelState.IsValid)
            {
                _dbContext.Categories.Update(category);
                _dbContext.SaveChanges();
                return RedirectToPage("Index");
            }
            return Page();
        }
    }
}
