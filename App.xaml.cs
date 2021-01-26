using CefSharp;
using CefSharp.Wpf;
using Squirrel;
using System.Windows;

namespace WinPOC461
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

            using (var updateManager = new UpdateManager("https://storage.googleapis.com/risevision-display-notifications/4TKGKVY5GQ5C"))
            {
                await updateManager.UpdateApp();
            }
        }
    }
}
