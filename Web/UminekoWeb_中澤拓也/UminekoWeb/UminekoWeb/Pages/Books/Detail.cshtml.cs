using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Modelsのプロパティを使用するために必要なusingディレクティブ
using UminekoWeb.Models;
using UminekoWeb.Services;

namespace UminekoWeb.Pages.Books
{
    public class DetailModel : PageModel
    {
        // IBookDataServiceとICategoryDataServiceのインスタンスを保持するためのフィールド
        private readonly IBookDataService _bookDataService;
        private readonly ILentHistoryDataService _lentHistoryDataService;

        // DIコンテナからIBookDataServiceとICategoryDataServiceのインスタンスが渡されるようにする
        public DetailModel(
            IBookDataService bookDataService,
            ILentHistoryDataService lentHistoryDataService)
        {
            _bookDataService = bookDataService;
            _lentHistoryDataService = lentHistoryDataService;
        }

        // 1行のデータ
        //OnGetの時にnewするのでここでは= new();不要
        public Book? Book { get; set; } 

        // 貸し出し履歴のリスト
        public List<LentHistory> LentHistories { get; set; } = new();

        public IActionResult OnGet(int bookId)
        {
            // IBookDataServiceのGetById呼びだして1行分のデータを取得する
            //引数はクエリパラメータからもらう(モデルバインディング)
            Book? data = _bookDataService.GetById(bookId);

            // データが取得できなかった場合はNotFoundを返す
            //URLにid直打ちして存在しないidを指定した場合など
            if (data == null)
            {
                return NotFound();
            }

            // データが取得できた場合はBookプロパティにセットする
            // 途中で判定が入ったのでわかりやすく変数に代入してからBookプロパティにセットする
            // nullチェックを行った後なので、dataはnullでないことが保証されている
            Book = data;

            // 貸し出し履歴のリストを取得してLentHistoriesプロパティにセットする
            LentHistories =
                _lentHistoryDataService.GetList(bookId);

            return Page();
        }
    }
}