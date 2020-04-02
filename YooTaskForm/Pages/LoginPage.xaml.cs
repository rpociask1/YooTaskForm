using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using Xamarin.Essentials;
using YooTaskForm.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Net.Http;
using System.Net.Http.Headers;
using YooTaskForm.Controllers;

namespace YooTaskForm.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this,false);
               
        }

       

        private void TapSignUp_Tapped(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SignUpPage());
        }

        private void TapSignUp_OnTapped(object sender, EventArgs e)
        {
             Navigation.PushAsync(new SignUpPage());
        }

        private async void BtnLogin_Clicked(object sender, EventArgs e)
        {
            UserController login = new UserController();
            string response;
            
            if (!(string.IsNullOrEmpty(EntEmail.Text) || string.IsNullOrEmpty(EntPassword.Text)))
            {
                response = await login.Login(EntEmail.Text, EntPassword.Text);

            
                
                if (string.IsNullOrEmpty(response))
                {
                    await DisplayAlert("Błąd", "Nie udało się zalogować", "Spróbuj ponownie");
                }
                else
                {
                    Preferences.Set("email", EntEmail.Text);
                    Preferences.Set("password", EntPassword.Text);
                    Preferences.Set("accesstoken", response);
                    Application.Current.MainPage = new MasterPage();
                }
            }
            else
            {
                await DisplayAlert("Błąd", "Login i hasło nie mogą być puste!", "Spróbuj ponownie");
            }
            

           
        }
    }
}