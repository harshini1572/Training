
namespace RetailShop.Models
{
    public class ModelOrder
    {
        public Guid OrderId { get; set; }
        public Guid ProductId { get; set; }
        public int TotalCost { get; set; }

    }
}
