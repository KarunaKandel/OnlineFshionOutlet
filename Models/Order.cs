namespace OnlineFashionOutletUsingMVC.Models
{
    public class Order
    {
        //Scalar properties
        public int OrderId { get; set; }
        public string OrderDate { get; set; }
        public string OrderStatus { get; set; } = "Pending"; // Default status is "Pending"
        public double TotalAmount { get; set; }
        public string PaymentType { get; set; }
        public string UserName { get; set; }
        //Navigation property
        public User? User { get; set; }
    }
}
