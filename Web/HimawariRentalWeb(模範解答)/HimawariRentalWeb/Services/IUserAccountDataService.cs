using HimawariRentalWeb.Models;

namespace HimawariRentalWeb.Services
{
    /// <summary>
    /// ユーザアカウントデータの取得と登録に関する機能を提供する
    /// </summary>
    public interface IUserAccountDataService
    {
        /// <summary>
        /// ユーザ名に一致する1件分のユーザアカウントデータを取得する.
        /// </summary>
        /// <param name="staffId">ユーザ名</param>
        /// <returns>ユーザアカウントデータ. 一致するものが無ければnullが返る.</returns>
        public UserAccount? GetById(string staffId);
    }
}
