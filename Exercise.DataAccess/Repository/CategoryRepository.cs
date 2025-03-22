using Exercise.DataAccess.Data;
using Exercise.DataAccess.Repository.IRepository;
using Exercise.Models;

namespace Exercise.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _dbContext;
        public CategoryRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


        public void Update(Category category)
        {
            _dbContext.Categories.Update(category);
        }
    }
}
