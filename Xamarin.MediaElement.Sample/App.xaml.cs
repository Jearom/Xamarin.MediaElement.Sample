using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.MediaElement.Sample.Services;
using Xamarin.MediaElement.Sample.Views;

namespace Xamarin.MediaElement.Sample
{
    public partial class App : Application
    {

        public App()
        {
            Device.SetFlags(new string[] { "MediaElement_Experimental" });
            InitializeComponent();
            DependencyService.Register<MockDataStore>();
            LogUnhandledExceptions();
            MainPage = new MainPage();
        }

        static void LogUnhandledExceptions()
        {
            AppDomain.CurrentDomain.UnhandledException += (sender, args) =>
            {
                System.Exception ex = (System.Exception)args.ExceptionObject;

                //Log.Error($" Mobkit Unhandled Error : { ex.GetType().Name} : {ex.Message}");
                Debug.WriteLine($"{ ex.GetType().Name + " : " + ex.Message}");
                Debug.WriteLine($"Mobkit : { ex.StackTrace}");
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
