using RetailShop.Repositary.Entity;


namespace RetailShop.Repositary.Interface
{
    public interface IProductRepository
    {
        public List<Product> Get();
        public Product GetById(Guid id);
        public void Post(Product Product);
        public void Put(Product Product);
        public void Delete(Guid id);


    }
}
