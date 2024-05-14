namespace FastFoodOrders.Models
{
    public class Basket : Food
    {
        public int Quantity { get; set; }
        List<Food> _foods = null;

        public Basket()
        {
            _foods = new List<Food>()
            {
               new Food(){Id = 1, Compositions= "One Two Three", Name="CheeseBurger", Price="12", PhotoFilePath=""}
            };
        }

        public Food Add(Food food)
        {
            food.Id = _foods.Max(s => s.Id) + 1;
            _foods.Add(food);
            return food;
        }
        public List<Food> GetAll()
        {
            return _foods;
        }
    }
}
