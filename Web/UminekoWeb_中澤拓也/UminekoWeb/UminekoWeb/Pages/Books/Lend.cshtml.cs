using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Modelsのプロパティを使用するために必要なusingディレクティブ
using UminekoWeb.Models;
using UminekoWeb.Services;

namespace UminekoWeb.Pages.Books
{
    [TypeFilter(typeof(LoginFilter))]
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

        //貸し出しのインサート
        public IActionResult OnPost()
        {
            // 入力値のバリデーションチェック
            if (!ModelState.IsValid)
            {
                return Page();
            }
            // BookIdのnullチェック
            if (LentHistory.BookId == null)
            {
                return NotFound();
            }

            // bookIdはint?型なので.Valueでintを取り出して入れる
            int bookId = LentHistory.BookId.Value;

            // 1行分のデータを取り出し
            Book? book =
                _bookDataService.GetById(bookId);

            // bookのデータが取り出せなかった場合NotFound()を返す
            if (book == null)
            {
                return NotFound();
            }

            //貸し出しのインサート
            try
            {
                // 貸出履歴テーブルへデータを登録する
                _lentHistoryDataService.Register(LentHistory);
            }
            catch
            {
                // DB登録時にエラーが発生した場合
                // 画面にエラーメッセージを表示する
                // ""はモデル全体に対するエラーを表す
                ModelState.AddModelError(
                    "",
                    "同じ会員が同じ蔵書を同じ日に貸出することはできません。");

                // return Page()すると画面を再表示するため、
                // 再度画面表示に必要な情報をセットし直す

                // 蔵書情報を再セット
                Book = book;

                // 貸出履歴へ蔵書IDを再セット
                LentHistory.BookId =book.BookId;

                // 会員一覧を再取得（プルダウン表示用）
                Members = _memberDataService.GetList();

                // 処理は何も行わず画面を再表示
                return Page();
            }

            //貸出フラグを立てる
            book.LentFlag = true;

            //貸出フラグをもって更新する
            _bookDataService.Update(book);

            //詳細画面にリダイレクトする
            return RedirectToPage(
                "/Books/Detail",
                new { BookId = book.BookId });
        }
    }
}