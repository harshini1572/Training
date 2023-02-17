using Moq;
using RetailShop.Api.Controllers;
using RetailShop.Models;
using RetailShop.Services.Interface;

namespace RetailShop.XUnitTest
{
    public class UnitTest1
    {
        private readonly Mock<IProductService> ProductService;
        public UnitTest1()
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