namespace FastFoodOrders.Models
{
    public interface IFoodRepository
    {
        IEnumerable<Client> GetClients();
        IEnumerable<Food> GetFoods();
        Food GetFood(int id);
        Food UpdateFood(Food food);
        Food DeleteFood(int id);
        Food CreateFood(Food food);
        Client CreateClients (Client client);
        Client UpdateClients(Client client);
        Client DeleteClients(int id);
    }
}
