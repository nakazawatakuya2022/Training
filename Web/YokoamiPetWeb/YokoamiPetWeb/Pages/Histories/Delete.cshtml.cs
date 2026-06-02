using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using YokoamiPetWeb.Models;
using YokoamiPetWeb.Services;

namespace YokoamiPetWeb.Pages.Histories
{
    public class DeleteModel : PageModel
    {
        private readonly IHistoryDataService _historyDataService;

        public DeleteModel(IHistoryDataService historyDataService)
        {
            _historyDataService = historyDataService;
        }

        public History History { get; set; } = new();

        public IActionResult OnGet(int id)
        {
            History? history = _historyDataService.GetById(id);

            if (history == null)
            {
                return NotFound();
            }

            History = history;

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            _historyDataService.Delete(id);

            return RedirectToPage("./Index");
        }
    }
}