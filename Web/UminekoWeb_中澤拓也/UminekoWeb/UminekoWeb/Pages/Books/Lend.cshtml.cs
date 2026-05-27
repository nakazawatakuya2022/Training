using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Modelsのプロパティを使用するために必要なusingディレクティブ
using UminekoWeb.Models;
using UminekoWeb.Services;

namespace UminekoWeb.Pages.Books
{
    public class LendModel : PageModel
    {
        // インスタンスを保持するためのフィールド
        private readonly IBookDataService _bookDataService;

        private readonly IMemberDataService _memberDataService;

        private readonly ILentHistoryDataService _lentHistoryDataService;

        // コンストラクタ
        // DIコンテナからインスタンスが渡されるようにする
        public LendModel(
            IBookDataService bookDataService,
            IMemberDataService memberDataService,
            ILentHistoryDataService lentHistoryDataService)
        {
            _bookDataService = bookDataService;
            _memberDataService = memberDataService;
            _lentHistoryDataService = lentHistoryDataService;
        }

        // 貸出対象の本のデータ
        public Book? Book { get; set; }

        // POST時に送信される貸出データ
        [BindProperty]
        public LentHistory LentHistory { get; set; }
            = new();

        // プルダウン表示用会員一覧
        public List<Member> Members { get; set; }
            = new();


        // 対象の本取得
        public IActionResult OnGet(int bookId)
        {
            Book? data =
                _bookDataService.GetById(bookId);

            // データが取得できなかった場合はNotFoundを返す
            //URLにid直打ちして存在しないidを指定した場合など
            if (data == null)
            {
                return NotFound();
            }

            // データが取得できた場合はBookプロパティにセットする
            Book = data;

            // 会員一覧取得
            Members =
                _memberDataService.GetList();

            // 画面表示準備
            return Page();
        }
        // 明日はここから！！！！！！
        public IActionResult OnPost()
        {
            if (LentHistory.BookId == null)
            {
                return NotFound();
            }

            Book? book =
                _bookDataService.GetById(
                    LentHistory.BookId.Value);

            if (book == null)
            {
                return NotFound();
            }

            LentHistory.LentDate =
                DateTime.Today;

            LentHistory.HasReturned =
                false;

            _lentHistoryDataService.Register(
                LentHistory);

            book.LentFlag =
                true;

            _bookDataService.Update(book);

            return RedirectToPage(
                "/Books/Detail",
                new { BookId = book.BookId });
        }
    }
}