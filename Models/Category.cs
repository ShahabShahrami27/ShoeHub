namespace ShoeHub.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; } // مثل: اسپرت، رسمی، زنانه، بچگانه

        public ICollection<Product> Products { get; set; }
    }
}
