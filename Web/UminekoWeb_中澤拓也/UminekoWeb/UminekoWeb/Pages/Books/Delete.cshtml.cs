using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
//Modelsのプロパティを使用するために必要なusingディレクティブ
using UminekoWeb.Models;
//Servicesのプロパティを使用するために必要なusingディレクティブ
using UminekoWeb.Services;

namespace UminekoWeb.Pages.Books
{
    [TypeFilter(typeof(LoginFilter))]
    [TypeFilter(typeof(AdminFilter))]
    public class DeleteModel : PageModel
    {
        //IBookDataServiceのインスタンスを保持するためのフィールド
        //1行のデータだけとれればいいので今回はICategoryDataService無し
        private readonly IBookDataService _bookDataService;
        
        // コンストラクタ
        // DIコンテナからIBookDataServiceのインスタンスが渡されるようにする
        public DeleteModel(IBookDataService bookDataService)
        {
            _bookDataService = bookDataService;
        }

        //1行のデータ
        [BindProperty]
        public Book Book { get; set; } = new Book();

        public IActionResult OnGet(int bookId)
        {
            // IBookDataServiceのGetById呼びだして1行分のデータを取得する
            //引数はクエリパラメータからもらう
            Book? data = _bookDataService.GetById(bookId);

            // データが取得できなかった場合はNotFoundを返す
            if (data == null)
            {
                return NotFound();
            }

            // データが取得できた場合はBookプロパティにセットする
            Book = data;

            return Page();
        }

        public IActionResult OnPost()
        {
            // BookプロパティのBookIdがnullの場合はBadRequestを返す
            if (Book.BookId == null)
            {
                return BadRequest();
            }

            // 引数はBooKのBookIdをint型にキャストして渡す
            // キャストするのはBookIdがint?型（null許容型）だから
            _bookDataService.DeleteById((int)Book.BookId);

            return RedirectToPage("/Books/Index");
        }
    }
}