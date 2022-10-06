using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OrderAPI.Data;
using OrderAPI.Models;
using OrderAPI.Services;

namespace OrderAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly Data.OrderContext _context;
        private readonly IOrderDataAccess _orderDataAccess;

        public OrdersController(OrderContext context, IOrderDataAccess orderDataAccess)
        {
            _context = context;
            _orderDataAccess = orderDataAccess;
        }

        // GET: api/Orders
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Order>>> GetOrder()
        {
            var orders = _orderDataAccess.GetAllOrders(_context);

            if (orders == null)
            {
                return NotFound();
            }
            return await _context.Order.ToListAsync();
        }

        // GET: api/Orders/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Order>> GetOrder(Guid id)
        {
            var order = _orderDataAccess.RetrieveOrder(id, _context);

            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        // PUT: api/Orders/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutOrder(Guid id, Order order)
        {
            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                _orderDataAccess.UpdateOrder(order, _context);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Orders
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Order>> PostOrder(Order order)
        {
            _orderDataAccess.CreateOrder(order, _context);

            return CreatedAtAction("GetOrder", new { id = order.Id }, order);
        }

        // DELETE: api/Orders/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrder(Guid id)
        {
            _orderDataAccess.DeleteOrder(id, _context);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/Orders/5
        [HttpGet("OrdersByType/{type}")]
        public async Task<ActionResult<List<Order>>> GetOrdersByType(OrderType type)
        {
            var order = new List<Order>();
            if(OrderType.None == type)
            {
                order = _orderDataAccess.GetAllOrders(_context);
            } 
            else
            {
                order = _orderDataAccess.RetrieveOrdersByType(type, _context);
            }
             


            if (order == null)
            {
                return NotFound();
            }

            return order;
        }

        private bool OrderExists(Guid id)
        {
            return _context.Order.Any(e => e.Id == id);
        }
    }
}
