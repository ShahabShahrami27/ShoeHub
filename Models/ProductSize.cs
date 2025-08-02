namespace ShoeHub.Models
{
    public class ProductSize
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Size { get; set; } // مثلاً 38، 39، 42
        public int Quantity { get; set; } // موجودی برای این سایز
    }
}
