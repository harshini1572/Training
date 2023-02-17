using RetailShop.Models;
using RetailShop.Api.Controllers;
using Moq;
using RetailShop.Services.Implementation;
using RetailShop.Services.Interface;

namespace RetailShop.UnitTests
{
    public class UnitTest
    {
        private readonly Mock<IProductService> ProductService;
        public UnitTest()
        {
            ProductService = new Mock<IProductService>();
        }
        [Fact]
        public void GetAllProducts()
        {
            var testData = ProductModels();
            ProductService.Setup(x => x.Get()).Returns(testData);
            var productController = new ProductController(ProductService.Object);
            var response = productController.Get();
            Assert.NotNull(response);
        }
        private List<ModelProduct> ProductModels()
        {
            return new List<ModelProduct> {
                new ModelProduct()
                {
                    Name= "Name",
                    Price=20000,
                    Quantity=1
                }
            };
        }
    }
}