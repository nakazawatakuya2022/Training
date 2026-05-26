using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HiddenField.Pages
{
    public class HiddenTestModel : PageModel
    {
        [BindProperty]
        public string? Id { get; set; }

        [BindProperty]
        public string? Readonly { get; set; }

        [BindProperty]
        public string? Disabled { get; set; }

        [BindProperty]
        public string? Hidden { get; set; }

        public void OnGet()
        {
            Id = "初期値";
            Readonly = "初期値";
            Disabled = "初期値";
            Hidden = "初期値";
        }

        public void OnPost()
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Id:"+Id);
            Console.WriteLine("Readonly:" + Readonly);
            Console.WriteLine("Disabled:"+Disabled);
            Console.WriteLine("Hidden:" + Hidden);
            Console.WriteLine("-----------------------------");
        }
    }
}
