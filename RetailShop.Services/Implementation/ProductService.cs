using AutoMapper;
using RetailShop.Models;
using RetailShop.Repositary.Entity;
using RetailShop.Repositary.Implementation;
using RetailShop.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailShop.Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly ProductRepository _productRepo;
        private readonly IMapper _mapper;
        public ProductService(ProductRepository productRepo, IMapper mapper)
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }
        public List<ModelProduct> Get()
        {
            var ProductList = _productRepo.Get();
            List<ModelProduct> ListOfProducts = _mapper.Map<List<ModelProduct>>(ProductList);
            return ListOfProducts;


        }
        public ModelProduct GetById(Guid id)
        {
            var ProductById = _productRepo.GetById(id);
            ModelProduct ProductId = _mapper.Map<ModelProduct>(ProductById);
            return ProductId;
        }
        public void Post(ModelProduct Product)
        {
            var NewProduct = _mapper.Map<Product>(Product);
            NewProduct.Id = Guid.NewGuid();
            _productRepo.Post(NewProduct);

        }
        public void Put(Guid id, ModelProduct Product)
        {
            var NewProduct = _mapper.Map<Product>(Product);
            NewProduct.Id = id;
            _productRepo.Put(NewProduct);
        }
        public void Delete(Guid id)
        {
            _productRepo.Delete(id);

        }
    }
}