using Microsoft.AspNetCore.Mvc.RazorPages;
using YokoamiPetWeb.Models;
using YokoamiPetWeb.Services;

namespace YokoamiPetWeb.Pages.Histories
{
    public class IndexModel : PageModel
    {
        // データサービスを格納するフィールド
        private readonly IHistoryDataService _historyDataService;

        // コンストラクタでデータサービスを受け取って、フィールドに格納する
        public IndexModel(IHistoryDataService historyDataService)
        {
            _historyDataService = historyDataService;
        }

        // 実施サービス履歴の一覧を格納するプロパティ
        public List<History> Histories { get; set; } = new();

        public void OnGet()
        {
            // データサービスから実施サービス履歴の一覧を取得して、プロパティに格納する
            Histories = _historyDataService.GetList();
        }
    }
}