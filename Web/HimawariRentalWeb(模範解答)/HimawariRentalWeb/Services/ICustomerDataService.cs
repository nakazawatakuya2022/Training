using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    /// <summary>
    /// 顧客データの取得と登録に関する機能を提供する
    /// </summary>
    public interface ICustomerDataService
    {
        /// <summary>
        /// 顧客データの一覧を取得
        /// </summary>
        /// <returns>顧客データの一覧</returns>
        public List<Customer> GetList();
    }
}
