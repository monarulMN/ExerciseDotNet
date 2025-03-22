using Exercise.Models;

namespace Exercise.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
       
    }
}
