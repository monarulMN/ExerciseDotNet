using Exercise.DataAccess.Data;
using Exercise.DataAccess.Repository.IRepository;
using Exercise.Models;

namespace Exercise.DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private ApplicationDbContext _dbContext;
        public ProductRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }


        public void Update(Product product)
        {
            _dbContext.Products.Update(product);
        }
    }
}
