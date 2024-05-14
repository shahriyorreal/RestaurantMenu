using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FastFoodOrders.ViewModel
{
    public class HomeCreateClientsViewModel
    {

        public int Id { get; set; }
        [Required]
        [DisplayName("FullName")]
        [MaxLength(50)]
        public string Fullname { get; set; }
        [Required]
        [DisplayName("Username")]
        [MaxLength(50)]
        public string Username { get; set; }
        [Required]
        [DisplayName("Password")]
        [MaxLength(50)]
        public string Password { get; set; }
        [Required]
        [DisplayName("Phone")]
        [MaxLength(50)]
        public int Phone { get; set; }
    }
}
