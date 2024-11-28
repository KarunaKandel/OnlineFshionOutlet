namespace OnlineFashionOutletUsingMVC.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Role { get; set; } = "User"; // Default role is "User"

       //Navigation property
        public ICollection<Order> Orders { get; set; }
       
}
    }

