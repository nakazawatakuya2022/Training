using YokoamiPetWeb.Models;

namespace YokoamiPetWeb.Services
{
    /// <summary>
    /// 実施サービス履歴データの操作機能を提供する
    /// </summary>
    public interface IHistoryDataService
    {
        /// <summary>
        /// 実施サービス履歴一覧を取得する
        /// </summary>
        List<History> GetList();

        /// <summary>
        /// 指定した実施サービスIDの履歴を取得する
        /// </summary>
        History? GetById(int id);

        /// <summary>
        /// 実施サービス履歴を登録する
        /// </summary>
        void Register(History history);

        /// <summary>
        /// 実施サービス履歴を更新する
        /// </summary>
        void Update(History history);

        /// <summary>
        /// 指定した実施サービスIDの履歴を削除する
        /// </summary>
        void Delete(int id);
    }
}