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
        //AuthPage AuthPage = new AuthPage();

        //string username;
        public MenuPage(/*string user*/)
        {
            SetValue(NavigationPage.HasNavigationBarProperty, false);
            InitializeComponent();
            //UsernameLabel.Text = authPage.Username();
            //this.username = user;
            //UsernameLabel.Text = username;
            /*var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            var db = new SQLiteConnection(dbpath);
            var un = db.Table<User>()
            var username = db.Table<User>().Where(u => u.CurrentUser.Equals(u.UserName));
            UsernameLabel.Text = username.ToString();*/
            /*if (username != null)
            {
                UsernameLabel.Text = username.ToString();
            }*/
        }

        private async void LogoutButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AuthPage());
        }

        private async void RecommendButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecommendMenu(/*username*/));
        }

        private async void TaskButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }

        private async void ReportButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ReportMenu());
        }

        private async void ConfiguratorButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfiguratorMenu());
        }

        private async void ChatButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ChatMenu(authPage.Username()));
        }
    }
}