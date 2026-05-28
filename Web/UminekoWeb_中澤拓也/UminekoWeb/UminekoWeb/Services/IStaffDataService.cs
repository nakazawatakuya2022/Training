using UminekoWeb.Models;

namespace UminekoWeb.Services
{
    /// <summary>
    /// 職員データの取得に関する機能を提供する
    /// </summary>
    public interface IStaffDataService
    {
        /// <summary>
        /// 職員IDに一致する1件分の職員データを取得する
        /// </summary>
        /// <param name="staffId">職員ID</param>
        /// <returns>職員データ。IDに一致するものが無ければnull</returns>
        Staff? GetById(string staffId);
    }
}