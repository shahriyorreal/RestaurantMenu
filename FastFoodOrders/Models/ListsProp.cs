


using FastFoodOrders.ViewModel;

namespace FastFoodOrders.Models
{
    public class ListsProp : IFoodRepository
    {
        private readonly AdminDbContext _logger;

        public ListsProp(AdminDbContext logger)
        {
            _logger = logger;
        }        

        IEnumerable<Client> IFoodRepository.GetClients()
        {
            return _logger.Clients;
        }

        IEnumerable<Food> IFoodRepository.GetFoods()
        {
            return _logger.Foods;
        }

        Client IFoodRepository.CreateClients(Client client)
        {
            _logger.Clients.Add(client);
            _logger.SaveChanges();
            return client;
        }

        Food IFoodRepository.CreateFood(Food food)
        {
            _logger.Foods.Add(food);
            _logger.SaveChanges();
            return food;
        }

        Client IFoodRepository.UpdateClients(Client client)
        {
            throw new NotImplementedException();
        }

        Client IFoodRepository.DeleteClients(int id)
        {
            throw new NotImplementedException();
        }

        Food IFoodRepository.GetFood(int id)
        {
            return _logger.Foods.Find(id);
        }

        Food IFoodRepository.UpdateFood(Food updateFood)
        {
            var food = _logger.Foods.Attach(updateFood);
            food.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _logger.SaveChanges();
            return updateFood;
        }

        Food IFoodRepository.DeleteFood(int id)
        {
            var food = _logger.Foods.Find(id);
            if (food != null)
            {
                _logger.Foods.Remove(food);
                _logger.SaveChanges();
            }
            return food;
        }

    }
}
