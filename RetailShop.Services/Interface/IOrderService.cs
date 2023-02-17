using RetailShop.Models;

namespace RetailShop.Services.Interface
{
    public interface IOrderService
    {
        List<ModelOrder> Get();
        ModelOrder GetById(Guid id);
        void Post(ModelOrder Order);
        void Delete(Guid id);
        void Put(Guid id, ModelOrder MyOrder);
    }
}
