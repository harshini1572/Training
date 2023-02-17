namespace RetailShop.MsTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetByName()
        {
            var ExpectedResult = "OnePlus";
            RetailShopModel Product = new RetailShopModel();
            var type = Product.GetByName("OnePlus");
            Assert.IsNotNull(type);
            Assert.AreEqual(ExpectedResult, type.Name);
        }
    }
}