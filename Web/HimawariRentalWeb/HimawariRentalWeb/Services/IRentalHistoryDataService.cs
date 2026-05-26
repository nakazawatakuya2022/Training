using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    public interface IRentalHistoryDataService
    {
        List<RentalHistory> GetListByRentalItemId(int rentalItemId);
    }
}