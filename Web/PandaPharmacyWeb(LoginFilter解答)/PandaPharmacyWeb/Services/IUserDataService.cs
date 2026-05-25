using PandaPharmacyWeb.Models;

namespace PandaPharmacyWeb.Services
{
    public interface IUserDataService
    {
        public User? GetByName(string userName);
    }
}
