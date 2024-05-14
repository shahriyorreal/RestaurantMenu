using System.ComponentModel.DataAnnotations;

namespace FastFoodOrders.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="Name Food")]
        [MaxLength(100)]
        public string NameFood { get; set; }
        [Required]
        [Display(Name = "Price")]
        [MaxLength(100)]
        public string Price { get; set; }
        [Required]
        [Display(Name = "Photo")]
        public string PhotoFilePath { get; set; }
        [Required]
        [Display(Name = "Compasition Food")]
        public string Compositions { get; set; }
        [Required]
        [Display(Name = "Phone Number")]
        [MaxLength(100)]
        public int PhoneNumber { get; set; }
        [Required]
        [Display(Name = "Adress")]
        public string Adress { get; set; }
    }
}
