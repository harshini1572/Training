using AutoMapper;
using RetailShop.Repositary.Entity;

namespace RetailShop.Repositary.Implementation
{
    public class ProductRepository
    {
        private readonly AppDbContext _dbcontext;
        private readonly IMapper _mapper;
        public ProductRepository(AppDbContext dbcontext, IMapper mapper)
        {
            _dbcontext = dbcontext;
            _mapper = mapper;
        }
        public List<Product> Get()
        {
            var ProductList = _dbcontext.Products.ToList();


            return ProductList;

        }
        public Product GetById(Guid id)
        {
            var ProductDetails = _dbcontext.Products.FirstOrDefault(x => x.Id == id);
            return ProductDetails;

        }

        public void Post(Product Product)
        {

            _dbcontext.Products.Add(Product);
            _dbcontext.SaveChanges();
        }
        public void Put(Product Product)
        {

            _dbcontext.Products.Update(Product);
            _dbcontext.SaveChanges();

        }
        public void Delete(Guid id)
        {
            var Product = _dbcontext.Products.FirstOrDefault(x => x.Id == id);
            _dbcontext.Products.Remove(Product);
            _dbcontext.SaveChanges();

        }
    }
}