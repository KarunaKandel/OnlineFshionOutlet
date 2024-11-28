namespace OnlineFashionOutletUsingMVC.Models
{
    public class User
    {
        //Scalar properties
        public int  UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Role { get; set; } = "Customer"; // Default role is "User"

       //Navigation property
        public ICollection<Order>? Orders { get; set; }
       
}
    }

