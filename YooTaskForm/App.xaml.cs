using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YooTaskForm.Pages;
using Xamarin.Essentials;
namespace YooTaskForm
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if(!string.IsNullOrEmpty(Preferences.Get("accesstoken","")))
            {
                MainPage = new MasterPage();
            }
            else if (string.IsNullOrEmpty(Preferences.Get("email", "")) || string.IsNullOrEmpty(Preferences.Get("password", "")))
            {
                MainPage = new NavigationPage(new LoginPage());
            }

           // MainPage = new NavigationPage(new LoginPage());
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
