using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace Test.SqLite.OnMAUI
{
    [Register("AppDelegate")]
    public class AppDelegate : MauiUIApplicationDelegate
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
    }
}