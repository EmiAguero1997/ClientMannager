using ClientMannager.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientMannager.Repositories
{
    public class ProductRepository : RepositoryBase<Product>, IProductRepository
    {
        public ProductRepository(ClientMannagerContext repositoryContext) : base(repositoryContext)
        {
        }

        public Product FindById(long id)
        {
            return FindByCondition(product => product.Id == id)
                .FirstOrDefault();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return FindAll()
                .ToList();
        }

        public void Save(Product product)
        {
            Create(product);
            SaveChanges();
        }
    }
}
