using CefSharp;
using CefSharp.Wpf;
using Squirrel;
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

        protected override async void OnStartup(StartupEventArgs args)
        {
            base.OnStartup(args);

            using (var updateManager = new UpdateManager("C:\\Users\\Santiago\\Source\\Repos\\WinRisePlayerPOC\\Releases"))
            {
                await updateManager.UpdateApp();
            }
        }

    }
}
