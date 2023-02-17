using Microsoft.AspNetCore.Mvc;
using RetailShop.Models;
using RetailShop.Services.Interface;

namespace RetailShop.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;

        }

        // GET: api/<APIController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_productService.Get());
        }

        // GET api/<APIController>/5
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {

            return Ok(_productService.GetById(id));
        }

        // POST api/<APIController>
        [HttpPost]
        public void Post(ModelProduct Product)
        {
            _productService.Post(Product);
        }

        // PUT api/<APIController>/5
        [HttpPut("{id}")]
        public void Put(Guid id, ModelProduct Product)

        {
            _productService.Put(id, Product);

        }

        // DELETE api/<APIController>/5
        [HttpDelete("{id}")]
        public void Delete(Guid id)
        {

            _productService.Delete(id);
        }
    }
}
