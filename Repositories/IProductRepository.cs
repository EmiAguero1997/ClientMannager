using ClientMannager.Models;

namespace ClientMannager.Repositories
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        void Save(Product product);
        Product FindById(long id);
    }
}
