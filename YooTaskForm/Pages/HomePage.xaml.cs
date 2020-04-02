using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using YooTaskForm.Models;

namespace YooTaskForm.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

        }
        private void LvProjects_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var selectedProject = e.SelectedItem as Project;
          //  Navigation.PushAsync(new ProjectPage(selectedProject.Id));

        }
    }
}