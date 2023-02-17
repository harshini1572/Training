using AutoMapper;
using RetailShop.Models;
using RetailShop.Repositary.Entity;
using RetailShop.Repositary.Implementation;
using RetailShop.Services.Interface;


namespace RetailShop.Services.Implementation
{
    public class OrderService : IOrderService
    {

        private readonly OrderRepository _orderRepo;
        private readonly IMapper _mapper;
        public OrderService(OrderRepository orderRepo, IMapper mapper)
        {

            _orderRepo = orderRepo;
            _mapper = mapper;
        }


        public List<ModelOrder> Get()
        {
            var OrderList = _orderRepo.Get();
            List<ModelOrder> ListOfOrders = _mapper.Map<List<ModelOrder>>(OrderList);
            return ListOfOrders;


        }
        public ModelOrder GetById(Guid id)
        {
            var OrderInfo = _orderRepo.GetById(id);
            ModelOrder OrderWithId = _mapper.Map<ModelOrder>(OrderInfo);
            return OrderWithId;
        }
        public void Post(ModelOrder MyOrder)
        {
            var NewOrder = _mapper.Map<Order>(MyOrder);
            NewOrder.OrderId = Guid.NewGuid();
            _orderRepo.Post(NewOrder);

        }
        public void Put(Guid id, ModelOrder MyOrder)
        {
            var NewOrder = _mapper.Map<Order>(MyOrder);
            NewOrder.OrderId = id;
            _orderRepo.Put(NewOrder);
        }
        public void Delete(Guid id)
        {
            _orderRepo.Delete(id);
        }

        
    }
}
