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
            var objFromDb = _dbContext.Products.FirstOrDefault(x => x.Id == product.Id);
            if (objFromDb!=null)
            {
                objFromDb.Title = product.Title;
                objFromDb.ISBN = product.ISBN;
                objFromDb.Price = product.Price;
                objFromDb.Price50 = product.Price50;
                objFromDb.Price100 = product.Price100;
                objFromDb.ListPrice = product.ListPrice;
                objFromDb.Description = product.Description;
                objFromDb.CategoryId = product.CategoryId;
                objFromDb.Author = product.Author;
                if(product.ImageUrl != null)
                {
                    objFromDb.ImageUrl = product.ImageUrl;
                }

            }
        }
    }
}
