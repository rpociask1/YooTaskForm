using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace YooTaskForm.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MasterPage : MasterDetailPage
    {
        public MasterPage ()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        private void BtnHome_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new HomePage());
        }

        private void BtnChangePassword_Clicked(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ChangePasswordPage());
        }

        private void TapLogout_OnTapped(object sender, EventArgs e)
        {
            Preferences.Set("email", "");
            Preferences.Set("password", "");
            Preferences.Set("accesstoken", "");
            Application.Current.MainPage = new NavigationPage(new LoginPage());
        }

    }
}