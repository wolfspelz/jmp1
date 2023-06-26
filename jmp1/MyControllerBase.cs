using Microsoft.AspNetCore.Mvc;

namespace jmp1
{
    public class MyControllerBase : Controller
    {
        public MyApp App;
        public ICallbackLogger Log;
        public MyConfig Config;
        public string UiCultureName { get; set; }

        public MyControllerBase(MyApp app)
        {
            App = app;
            Log = App.Log;
            Config = App.Config;
            UiCultureName = Thread.CurrentThread.CurrentUICulture.Name;
        }
    }
}
