using System.ComponentModel;

namespace ShoeHub.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; } //موجودی
        public string ImageUrl { get; set; } //آدرس عکس
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public ICollection<ProductSize> sizes { get; set; }

    }
}
