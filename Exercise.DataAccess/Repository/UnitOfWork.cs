using Exercise.DataAccess.Data;
using Exercise.DataAccess.Repository.IRepository;

namespace Exercise.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _dbContext;
        public ICategoryRepository Category { get; private set; }
        public IProductRepository Product { get; private set; }
        public UnitOfWork(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            Category = new CategoryRepository(dbContext);
            Product = new ProductRepository(dbContext);
        }

        public void Save()
        {
            _dbContext.SaveChanges(); 
        }
    }
}
