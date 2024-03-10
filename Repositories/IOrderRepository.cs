using ClientMannager.Models;

namespace OrderMannager.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> GetAllOrders();
        void Save(Order order);
        Order FindById(long id);
    }
}
