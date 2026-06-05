using YokoamiPetWeb.Models;

namespace YokoamiPetWeb.Services
{
    public interface IServiceDataService
    {
        List<Service> GetList();

        Service? GetById(int id);

        void Register(Service service);

        void Update(Service service);
    }
}