using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    public class DbRentalHistoryDataService
        : IRentalHistoryDataService
    {
        public List<RentalHistory> GetListByRentalItemId(int rentalItemId)
        {
            List<RentalHistory> list = new();

            return list;
        }
    }
}