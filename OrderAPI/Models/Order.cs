
namespace OrderAPI.Models
{
    public enum OrderType
    {
        Standard,
        SaleOrder,
        PurchaseOrder,
        TransferOrder,
        ReturnOrder,
        None
    }
    public class Order
    {
        public Order(Guid id, OrderType type, DateTime createdDate, string customerName, string createdByUsername)
        {
            this.Id = id;
            this.Type = type;
            this.CreatedDate = createdDate;
            this.CustomerName = customerName;
            this.CreatedByUsername = createdByUsername;
        }

        public Order()
        {

        }


        public OrderType Type { get; set; }

        public Guid Id { get; set; }

        public DateTime CreatedDate { get; set; }

        public string CustomerName { get; set; }

        public string CreatedByUsername { get; set; }

    }
}