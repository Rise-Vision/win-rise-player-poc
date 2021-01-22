using CefSharp;
using CefSharp.Wpf;
using System.Windows;

namespace WinRisePlayerPOC
{
    public partial class App : Application
    {
        public App()
        {
            var settings = new CefSettings();

            Cef.Initialize(settings, performDependencyCheck: true, browserProcessHandler: null);
        }
    }
}
