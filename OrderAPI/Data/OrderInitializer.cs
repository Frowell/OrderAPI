using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.EntityFrameworkCore;
using OrderAPI.Models;


namespace OrderAPI.Data
{
    public class OrderInitializer
    {
        public static void Initialize(OrderContext context)
        {
            if (context.Order.Any())
            {
                return;
            }

            var orders = new Order[]
            {
                new Order{Id = new Guid("36827ad2-ce1a-4a65-a277-1bb5a4bfc90d"), Type = OrderType.SaleOrder, CreatedDate = DateTime.Now, CustomerName = "Tim Jones", CreatedByUsername = "frowell" },
                new Order{Id = new Guid("dbe923fd-2ac1-468a-8c19-9e728e054898"), Type = OrderType.PurchaseOrder, CreatedDate = DateTime.Now,  CustomerName = "John Doe", CreatedByUsername = "frowell"},
                new Order{Id = new Guid("bff04b8a-8ab2-40a8-927e-5e9992f16bff"), Type = OrderType.ReturnOrder, CreatedDate = DateTime.Now,  CustomerName = "James Moe", CreatedByUsername = "frowell"},
                new Order{Id = new Guid("2721ac7f-98eb-40d1-92f0-97c7d8221c7a"), Type = OrderType.TransferOrder, CreatedDate = DateTime.Now,  CustomerName = "Adam James", CreatedByUsername = "frowell"},
                new Order{Id = new Guid("7b953278-996b-4a63-b3e1-68868ca2fe62"), Type = OrderType.Standard, CreatedDate = DateTime.Now,  CustomerName = "Alex Smith", CreatedByUsername = "frowell"},
                new Order{Id = new Guid("fe55a0a3-457b-4789-b2ed-7f3b502f48f4"), Type = OrderType.SaleOrder, CreatedDate = DateTime.Now, CustomerName = "Tom Brady", CreatedByUsername = "frowell" }
            };
            context.Order.AddRange(orders);
            context.SaveChanges();


        }
    }
}
