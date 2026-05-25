using PandaPharmacyWeb.Models;

namespace PandaPharmacyWeb.Services
{
    public interface IOrderDataService
    {
        List<Order> GetList();

        public void Register(Order order);

        public Order? GetById(int id);
    }
}