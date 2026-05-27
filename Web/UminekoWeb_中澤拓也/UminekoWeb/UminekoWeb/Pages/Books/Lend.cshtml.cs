using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using UminekoWeb.Models;
using UminekoWeb.Services;

namespace UminekoWeb.Pages.Books
{
    public class LendModel : PageModel
    {
        private readonly IBookDataService _bookDataService;

        private readonly IMemberDataService _memberDataService;

        private readonly ILentHistoryDataService _lentHistoryDataService;



        public Book? Book { get; set; }

        [BindProperty]
        public LentHistory LentHistory { get; set; }
            = new();

        public List<Member> Members { get; set; }
            = new();

        public LendModel(
            IBookDataService bookDataService,
            IMemberDataService memberDataService,
            ILentHistoryDataService lentHistoryDataService)
        {
            _bookDataService = bookDataService;
            _memberDataService = memberDataService;
            _lentHistoryDataService = lentHistoryDataService;
        }

        public IActionResult OnGet(int bookId)
        {
            Book? data =
                _bookDataService.GetById(bookId);

            if (data == null)
            {
                return NotFound();
            }

            Book = data;

            Members =
                _memberDataService.GetList();

            return Page();
        }

        public IActionResult OnPost()
        {
            Book? book =
                _bookDataService.GetById(
                    LentHistory.BookId!.Value);

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