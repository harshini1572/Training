using RetailShop.Models;
namespace RetailShop.Services.Interface
{
    public interface IProductService
    {
        List<ModelProduct> Get();
        ModelProduct GetById(Guid id);
        void Post(ModelProduct Order);
        void Delete(Guid id);
        void Put(Guid id, ModelProduct Order);
    }
}
