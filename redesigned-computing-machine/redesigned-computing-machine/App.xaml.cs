using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using redesigned_computing_machine.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace redesigned_computing_machine
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();


            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
