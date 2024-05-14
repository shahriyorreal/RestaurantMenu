using FastFoodOrders.Models;
using FastFoodOrders.ViewModel;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FastFoodOrders.Controllers
{
    public class AdminController : Controller
    {
        private readonly IFoodRepository _logger;
        private readonly IWebHostEnvironment webHost;

        public AdminController(IFoodRepository logger, IWebHostEnvironment webHost)
        {
            _logger = logger;
            this.webHost = webHost;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult ClientsIndex()
        {
            ClientViewModel viewModel = new ClientViewModel()
            {
                Clients = _logger.GetClients() 
            };
            return View(viewModel);
        }

        public IActionResult FoodsIndex()
        {
            FoodViewModel foods = new FoodViewModel()
            {
                Foods = _logger.GetFoods()
            };
            return View(foods);
        }
        [HttpGet]
        public IActionResult EditFood(int id)
        {
            Food food = _logger.GetFood(id);
            EditFoodViewModel editFood = new EditFoodViewModel
            {
                Name = food.Name,
                Price = food.Price,
                Categories = food.Categories,
                Compositions = food.Compositions,
                ExistingPhotoFilePath = food.PhotoFilePath
            };
            return View(editFood);
        }

        [HttpGet]
        public IActionResult CreateFood() 
        {
            return View();  
        }

        [HttpPost]
        public IActionResult EditFood(EditFoodViewModel food)
        {
            Food existingfood = _logger.GetFood(food.Id);
            existingfood.Name = food.Name;
            existingfood.Price = food.Price;
            existingfood.Categories = food.Categories;
            existingfood.Compositions = food.Compositions;
            if (food.Photo != null)
            {
                if (food.ExistingPhotoFilePath != null)
                {
                    string filePath =  Path.Combine(webHost.WebRootPath, "images", food.ExistingPhotoFilePath);
                    System.IO.File.Delete(filePath);
                }
                existingfood.PhotoFilePath = ProccessUploadedFile(food);
            }

            _logger.UpdateFood(existingfood);
            return RedirectToAction("FoodsIndex");

            return View();
        }

        private string ProccessUploadedFile(FoodViewModel food)
        {
            string uniqueFileName = string.Empty;
            if (food.Photo != null)
            {
                string uploadFolder = Path.Combine(webHost.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + food.Photo.FileName;
                string imageFilePath = Path.Combine(uploadFolder, uniqueFileName);
                food.Photo.CopyTo(new FileStream(imageFilePath, FileMode.Create));
            }

            return uniqueFileName;
        }
        [HttpPost]
        public IActionResult DeleteFood(int id)
        {
            _logger.DeleteFood(id);
            return RedirectToAction("FoodsIndex");
        }


            [HttpPost]
        public IActionResult CreateFood(FoodViewModel food)
        {

            string uniqueFileName = ProccessUploadedFile(food);

            Food newFood = new Food
                {
                    Name = food.Name,
                    Compositions = food.Compositions,
                    Categories = food.Categories,
                    Price = food.Price,
                    PhotoFilePath = uniqueFileName
                };

                newFood = _logger.CreateFood(newFood);
                return RedirectToAction("FoodsIndex");

            return View();
        }

        [HttpGet]
        public ViewResult CreateClients()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateClients(Client client)
        {
            _logger.CreateClients(client);
            return View(client);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

