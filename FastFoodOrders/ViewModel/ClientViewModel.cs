using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using FastFoodOrders.Models;

namespace FastFoodOrders.ViewModel
{
    public class ClientViewModel
    {


        public IEnumerable<Client> Clients { get; set; }
    }
}
