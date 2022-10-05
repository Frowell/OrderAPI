using System.Data;
using System.Data.SqlClient;
using System.Text;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;
using OrderAPI.Data;
using OrderAPI.Models;

namespace OrderAPI.Services
{
    public class OrderDataAccess : IOrderDataAccess
    {
        ILogger _logger;

        public List<Order> GetAllOrders(OrderContext context)
        {
            List<Order> orders = context.Order.ToList<Order>();
            return orders;
        }
        public Order RetrieveOrder(Guid uid, OrderContext context)
        {
            Order? order = context.Order.Find(uid);
            return order;
        }

        public void CreateOrder(Order order, OrderContext context)
        {
            context.Order.Add(order);
            context.SaveChanges();
        }

        public void DeleteOrder(Guid uid, OrderContext context)
        {
            context.Order.Remove(RetrieveOrder(uid, context));
            context.SaveChanges();
        }

        public void UpdateOrder(Order order, OrderContext context)
        {
            context.Order.Update(order);
            context.SaveChanges();
        }

        public List<Order> RetrieveOrdersByType(OrderType orderType, OrderContext context)
        {
            List<Order> orders = context.Order.Where(order => order.Type == orderType).ToList<Order>();
            context.SaveChanges();
            return orders;
        }

    }
}
