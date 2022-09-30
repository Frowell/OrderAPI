using Microsoft.AspNetCore.Mvc;
using OrderAPI.DAL;
using OrderAPI.Models;
using OrderAPI.Services;
using System.Data.Entity;

namespace OrderAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private IOrderDataAccess _dataAccess;
        private readonly ILogger<OrderController> _logger;
        private readonly OrderContext _db;

        public OrderController(ILogger<OrderController> logger, IOrderDataAccess dataAccess, OrderContext db)
        {
            _dataAccess = dataAccess;
            _logger = logger;
            _db = db;
        }

        [HttpGet(Name = "Get")]
        public IEnumerable<Order> Get()
        {
            return new [] { new Order() };
        }

        [HttpGet(Name = "Get")]
        public Order Get(Guid id)
        {


            return null;
        }

        [HttpPost(Name = "Post")]
        public void Post([FromBody]string json )
        {

        }

        [HttpPut(Name = "Put")]
        public void Put([FromBody] string json)
        {

        }

        [HttpDelete(Name = "Delete")]
        public void Delete(Guid id)
        {

        }


        [HttpPost(Name = "ByType")]
        public void ByType([FromBody] string json)
        {

        }


    }
}