namespace OnlineFashionOutletUsingMVC.Models
{
    public class Product
    {
        //Scalar properties
        public int ProductId { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? Category { get; set; }
        public int? Quantity { get; set; }
        //Navigation property
        public ICollection<Order>? Orders { get; set; }

    }
}
