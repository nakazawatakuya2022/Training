using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Modelsのプロパティを使用するために必要なusingディレクティブ
using UminekoWeb.Models;
//Servicesのプロパティを使用するために必要なusingディレクティブ
using UminekoWeb.Services;

namespace UminekoWeb.Pages.Books
{
    public class CreateModel : PageModel
    {
        // IBookDataServiceとICategoryDataServiceのインスタンスを保持するためのフィールド
        private readonly IBookDataService _bookDataService;
        private readonly ICategoryDataService _categoryDataService;

        // コンストラクタ
        // DIコンテナからIBookDataServiceとICategoryDataServiceのインスタンスが渡されるようにする
        public CreateModel(
            IBookDataService bookDataService,
            ICategoryDataService categoryDataService)
        {
            _bookDataService = bookDataService;
            _categoryDataService = categoryDataService;
        }

        // 一覧表示する書籍データのリスト
        [BindProperty]
        public Book Book { get; set; } = new Book();

        // カテゴリリストに一覧表示するカテゴリデータのリスト
        public List<Category> Categories { get; set; } = new List<Category>();

        // 画面表示前にプルダウンの選択肢をDBから読み込む処理
        public void OnGet()
        {
            Categories = _categoryDataService.GetList();
        }

        // 新規データ登録の処理
        public IActionResult OnPost()
        {
            // 入力に不備がある場合は、再度プルダウンの選択肢をDBから読み込んで画面に戻す
            if (!ModelState.IsValid)
            {
                // 再度DBからカテゴリデータを読み込むのは、画面に戻すときにプルダウンの選択肢がないと困るから
                Categories = _categoryDataService.GetList();
                return Page();
            }
            // IBookDataServiceのRegisterメソッドを呼び出してBookプロパティの内容をDBに登録する
            _bookDataService.Register(Book);

            // 登録後は一覧画面にリダイレクトする
            // 登録処理完了後はリダイレクトしてGET画面へ遷移させることで、F5を押しても再登録されない
            return RedirectToPage("/Books/Index");
        }
    }
}