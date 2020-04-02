using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YooTaskForm.Controllers;

namespace YooTaskForm.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()
        {
            InitializeComponent();
           
        }

        private async void BtnSign_Clicked(object sender, EventArgs e)
        {
            UserController user = new UserController();
            string response;
            response = await user.SignUp(EntEmail.Text.ToString(), EntPassword.Text.ToString());


            if (string.IsNullOrEmpty(response))
            {
                await DisplayAlert("Błąd", "Nie udało się zalogować", "Spróbuj ponownie");
            }
            else
            {
                await DisplayAlert("Rejestracja", "przebiegła pomyślnie", "Zaloguj się");
                Application.Current.MainPage = new LoginPage();
            }
        }
    }
}