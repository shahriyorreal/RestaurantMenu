using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using FastFoodOrders.Models;

namespace FastFoodOrders.ViewModel
{
    public class FoodViewModel
    {
        public IEnumerable<Food> Foods { get; set; }
        public IEnumerable<Basket> Baskets { get; set; }

        [Required]
        public int Id { get; set; }
        [DisplayName("Name")]
        public string Name { get; set; }
        [DisplayName("Compasition")]
        public string Compositions { get; set; }
        [DisplayName("Category")]
        public Category Categories { get; set; }
        [DisplayName("Price")]
        public string Price { get; set; }

        public IFormFile Photo { get; set; }

    }
}
