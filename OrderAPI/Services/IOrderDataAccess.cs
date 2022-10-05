using OrderAPI.Data;
using OrderAPI.Models;

namespace OrderAPI.Services
{
    public interface IOrderDataAccess
    {
        public List<Order> GetAllOrders(OrderContext context);
        public Order RetrieveOrder(Guid id, OrderContext context);
        public void CreateOrder(Order order, OrderContext context);
        public void DeleteOrder(Guid uid, OrderContext context);
        public void UpdateOrder(Order order, OrderContext context);
        public List<Order> RetrieveOrdersByType(OrderType orderType, OrderContext context);
    }


}
