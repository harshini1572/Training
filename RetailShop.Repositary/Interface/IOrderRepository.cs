using RetailShop.Repositary.Entity;

namespace RetailShop.Repository.Interface
{
    public interface IorderRepository
    {
        List<Order> Get();
        Order GetById(Guid id);
        public void Put(Order Order);
        public void Post(Order Order);
        public void Delete(Guid id);


    }
}
