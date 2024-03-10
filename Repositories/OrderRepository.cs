using ClientMannager.Models;
using Microsoft.EntityFrameworkCore;
using ClientMannager.Repositories;

namespace ClientMannager.Repositories
{
    namespace HomeBankingMindHub.Repositories
    {
        public class OrderRepository : RepositoryBase<Order>, IOrderRepository
        {
            public OrderRepository(ClientMannagerContext repositoryContext) : base(repositoryContext)
            {
            }

            public Order FindById(long id)
            {
                return FindByCondition(order => order.Id == id)
                    .Include(order => order.Items)
                    .FirstOrDefault();
            }

            public IEnumerable<Order> GetAllOrders()
            {
                return FindAll()
                    .Include(order => order.Items)
                    .ToList();
            }

            public void Save(Order order)
            {
                Create(order);
                SaveChanges();
            }
        }
    }
}
