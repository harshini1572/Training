using AutoMapper;
using RetailShop.Repositary;
using RetailShop.Repositary.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Repositary.Implementation
{
    public class OrderRepository
    {
        private readonly AppDbContext _dbcontext;
        public OrderRepository(AppDbContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
        public List<Order> Get()
        {
            var Orders = _dbcontext.Orders.ToList();
            return Orders;

        }
        public Order GetById(Guid id)
        {
            var OrderDetails = _dbcontext.Orders.FirstOrDefault(x => x.OrderId == id);
            return OrderDetails;

        }
        public void Put(Order Order)
        {

            _dbcontext.Orders.Update(Order);
            _dbcontext.SaveChanges();
        }
        public void Post(Order Order)
        {

            _dbcontext.Orders.Add(Order);
            _dbcontext.SaveChanges();
        }
        public void Delete(Guid id)
        {
            var Order = _dbcontext.Orders.FirstOrDefault(x => x.OrderId == id);
            _dbcontext.Orders.Remove(Order);
            _dbcontext.SaveChanges();

        }
    }
}
