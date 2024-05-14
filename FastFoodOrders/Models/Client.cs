using System.ComponentModel;

namespace FastFoodOrders.Models
{
    public class Client
    {
        public int Id { get; set; }
        [DisplayName("Full Name")]
        public string Fullname { get; set; }
        [DisplayName("Username")]
        public string Username { get; set; }
        [DisplayName("Password")]
        public string Password { get; set; }
        [DisplayName("Phone")]
        public int Phone { get; set; }
    }
}
