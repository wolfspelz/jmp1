using Microsoft.AspNetCore.Mvc;

namespace jmp1.Pages
{
    public class IndexModel : MyPageModel
    {
        public IndexModel(MyApp app) : base(app, "Index")
        {
        }

        public IActionResult OnGet(string? code)
        {
            return RedirectPermanent(Config.RedirectPrefix + code ?? "");
        }
    }
}