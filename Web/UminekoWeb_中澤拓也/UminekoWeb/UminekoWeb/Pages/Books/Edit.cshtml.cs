using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Modelsのプロパティを使用するために必要なusingディレクティブ
using UminekoWeb.Models;
//Servicesのプロパティを使用するために必要なusingディレクティブ
using UminekoWeb.Services;

namespace UminekoWeb.Pages.Books
{
    public class EditModel : PageModel
    {
        // IBookDataServiceとICategoryDataServiceのインスタンスを保持するためのフィールド
        private readonly IBookDataService _bookDataService;
        private readonly ICategoryDataService _categoryDataService;

        // コンストラクタ
        // DIコンテナからIBookDataServiceとICategoryDataServiceのインスタンスが渡されるようにする
        public EditModel(
            IBookDataService bookDataService,
            ICategoryDataService categoryDataService)
        {
            _bookDataService = bookDataService;
            _categoryDataService = categoryDataService;
        }

        //1行のデータ
        [BindProperty]
        public Book Book { get; set; } = new Book();

        //カテゴリリストに一覧表示するカテゴリデータのリスト
        public List<Category> Categories { get; set; } = new List<Category>();

        public IActionResult OnGet(int bookId)
        {
            // IBookDataServiceのGetById呼びだして1行分のデータを取得する
            //引数はクエリパラメータからもらう
            Book? data = _bookDataService.GetById(bookId);

            // データが取得できなかった場合はNotFoundを返す
            //URLにid直打ちして存在しないidを指定した場合など
            if (data == null)
            {
                return NotFound();
            }
            // データが取得できた場合はBookプロパティにセットする
            Book = data;
            // 画面表示前にプルダウンの選択肢をDBから読み込む処理
            Categories = _categoryDataService.GetList();

            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                // 入力に不備がある場合は、再度プルダウンの選択肢をDBから読み込んで画面に戻す
                Categories = _categoryDataService.GetList();
                return Page();
            }

            // IBookDataServiceのUpdateメソッドを呼び出してBookプロパティの内容をDBに更新する
            _bookDataService.Update(Book);

            // 更新後は詳細画面にリダイレクトする
            //return RedirectToPage(
            //    "/Books/Detail",
            //    // 無名オブジェクトでクエリパラメータを指定する
            //    // クエリパラメータの名前はDetail.cshtml.csのOnGetの引数名と同じにすること
            //    new { BookId = Book.BookId }
            return RedirectToPage("/Books/Index");
        }
    }
}