using Microsoft.AspNetCore.Mvc;
using RetailShop.Models;
using RetailShop.Services.Interface;

namespace RetailShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;

        }
        // GET: api/<OrderController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_orderService.Get());
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            return Ok(_orderService.GetById(id));
        }

        // POST api/<OrderController>
        [HttpPost]
        public void Post(ModelOrder Order)
        {
            _orderService.Post(Order);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, ModelOrder Order)
        {
            _orderService.Post(Order);
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {
            _orderService.Delete(id);
        }
    }
}
