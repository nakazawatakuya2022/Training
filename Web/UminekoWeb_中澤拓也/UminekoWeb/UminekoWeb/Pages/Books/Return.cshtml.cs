using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Modelsのプロパティを使用するために必要なusingディレクティブ
using UminekoWeb.Models;
using UminekoWeb.Services;

namespace UminekoWeb.Pages.Books
{
    [TypeFilter(typeof(LoginFilter))]
    public class ReturnModel : PageModel
    {
        // インスタンスを保持するためのフィールド
        private readonly IBookDataService _bookDataService;
        private readonly ILentHistoryDataService _lentHistoryDataService;

        // コンストラクタ
        // DIコンテナからインスタンスが渡されるようにする
        public ReturnModel(
            IBookDataService bookDataService,
            ILentHistoryDataService lentHistoryDataService)
        {
            _bookDataService = bookDataService;
            _lentHistoryDataService = lentHistoryDataService;
        }

        // 貸出対象の本のデータ
        public Book Book { get; set; } = new();

        // GETされたBookIdをもとに本のデータを取得して、Bookプロパティに格納する
        public IActionResult OnGet(int bookId)
        {
            //1件の本のデータを取得してBookクラスのインスタンスに格納する
            Book? data =
                _bookDataService.GetById(bookId);

            // データが取得できなかった場合はNotFoundを返す
            //URLにid直打ちして存在しないidを指定した場合など
            if (data == null)
            {
                return NotFound();
            }

            // 取得したデータをBookプロパティに格納する
            Book = data;

            return Page();
        }

        // POSTされたBookIdをもとに本のデータを取得して、詳細画面にリダイレクトする
        // bookidは、OnGetのURLにクエリパラメータとして付与されているものと同じにすること
        // 本を借りて当日返しても、当日また借りることはできないのでここではtryとcatchは必要ない
        public IActionResult OnPost(int bookId)
        {
            Book? book =
                _bookDataService.GetById(bookId);

            if (book == null)
            {
                return NotFound();
            }

            // 貸出履歴を返却済みに更新
            _lentHistoryDataService.Return(bookId);

            // 蔵書を利用可に戻す
            book.LentFlag = false;

            // booksテーブル更新
            _bookDataService.Update(book);

            return RedirectToPage(
                "/Books/Detail",
                new { bookId = book.BookId });
        }
    }
}