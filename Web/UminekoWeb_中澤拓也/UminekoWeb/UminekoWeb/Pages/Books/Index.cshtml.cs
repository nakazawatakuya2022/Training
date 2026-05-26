using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UminekoWeb.Models;
using UminekoWeb.Services;

namespace UminekoWeb.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly IBookDataService _bookDataService;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="bookDataService">蔵書データの取得と登録に関する機能</param>
        public IndexModel(IBookDataService bookDataService)
        {
            _bookDataService = bookDataService;
        }

        /// <summary>
        /// 検索用キーワード
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string? Search { get; set; }

        /// <summary>
        /// 貸出中のみ絞込みフラグ
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public bool IsLentOnly { get; set; }

        /// <summary>
        /// 一覧表示する書籍データのリスト
        /// </summary>
        public List<Book>? Books { get; set; }

        public void OnGet()
        {
            // TODO: Booksプロパティのデータを正しくセットすること
        }
    }
}
