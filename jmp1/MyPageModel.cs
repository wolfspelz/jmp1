using Microsoft.AspNetCore.Mvc.RazorPages;

namespace jmp1
{
    public class MyPageModel : PageModel
    {
        public MyApp App;
        public ICallbackLogger Log;
        public MyConfig Config;
        public string UiCultureName { get; set; }

        public MyPageModel(MyApp app, string textName)
        {
            App = app;
            Log = App.Log;
            Config = App.Config;
            UiCultureName = Thread.CurrentThread.CurrentUICulture.Name;
        }

        protected static string GetLangFromCultureName(string cultureName)
        {
            return cultureName.Split(new char[] { '-', '_' }).First().ToLower();
        }
    }
}
