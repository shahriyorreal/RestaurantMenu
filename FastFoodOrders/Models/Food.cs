using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace FastFoodOrders.Models
{
    public class Food
    {
        public int Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Compasition")]
        public string Compositions { get; set; }
        [DisplayName("Category")]
        public Category Categories { get; set; }
        [DisplayName("Price")]
        public string Price { get; set; }
        [DisplayName("Photo File Path")]
        public string PhotoFilePath { get; set; }
    }
}
