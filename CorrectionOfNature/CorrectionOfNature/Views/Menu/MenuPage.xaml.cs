using CorrectionOfNature.Tables;
using CorrectionOfNature.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionOfNature.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentView
    {
        public MenuPage()
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            UsernameLabel.Text = AppSettings.Username;
        }

        private void LogoutButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AuthPage();
        }

        private void RecommendButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RecommendMenu();
        }

        private void TaskButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new MainPage();
        }

        private void ReportButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ReportMenu();
        }

        private void ConfiguratorButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ConfiguratorMenu();
        }

        private void ChatButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new ChatMenu();
        }
    }
}