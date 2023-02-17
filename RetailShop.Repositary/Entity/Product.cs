using System.ComponentModel.DataAnnotations;

namespace RetailShop.Repositary.Entity
{
    public class Product
    {
        [Key]
        [Required]
        public Guid Id { get; set; }
        [Required]
        public string? Name { get; set; }
        public string? Type { get; set; }
        public int Price { get; set; }
        public int Qunatity { get; set; }

    }
}