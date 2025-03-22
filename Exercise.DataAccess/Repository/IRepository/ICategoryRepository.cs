using Exercise.Models;

namespace Exercise.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
       
    }
}
