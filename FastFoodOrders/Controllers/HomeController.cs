using FastFoodOrders.Models;
using FastFoodOrders.ViewModel;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FastFoodOrders.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFoodRepository _logger;
        private readonly IWebHostEnvironment webHost;
        Basket basket;


        public HomeController(IFoodRepository logger ,IWebHostEnvironment webHost)
        {
            _logger = logger;
            this.webHost = webHost;
        }
        public IActionResult Index()
        {
            FoodViewModel foods = new FoodViewModel()
            {
                Foods = _logger.GetFoods()
            };
            return View(foods);
        }
        public IActionResult SignUp()
        {
            return View();
        }

        public IActionResult Basket(Food food)
        {
            FoodViewModel foods = new FoodViewModel()
            {
                Foods = _logger.GetFoods()
            };
            return View(foods);
        }
       

    }
}
