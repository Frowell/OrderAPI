using System.Data;
using System.Data.SqlClient;
using System.Text;
using OrderAPI.Models;

namespace OrderAPI.Services
{
    public class OrderDataAccess : IOrderDataAccess
    {
        public Order RetrieveOrder(Guid uid)
        {
            return null;
        }

        public void CreateOrder(Order order)
        {


        }

        public void DeleteOrder(Guid uid)
        {


        }

        public void UpdateOrder(Order order)
        {


        }

        public List<Order> RetrieveOrdersByType(OrderType orderType)
        {

            return null;
        }

    }
}
