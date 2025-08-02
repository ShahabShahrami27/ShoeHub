namespace ShoeHub.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }
        public decimal TotalAmount { get; set; }
        public string Status { get; set; } // در حال پردازش، ارسال شده، لغو شده
    }
}
