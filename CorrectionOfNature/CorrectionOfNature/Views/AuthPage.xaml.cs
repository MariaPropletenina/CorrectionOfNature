using CorrectionOfNature.Tables;
using CorrectionOfNature.Views.Menu;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionOfNature.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AuthPage : ContentPage
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        async private void LoginButton_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<TestPassed>();

            var myquery = db.Table<User>()
                .Where(u => u.Login.Equals(nameEntry.Text) && u.Password.Equals(passwordEntry.Text)).FirstOrDefault();

            if (myquery != null)
            {
                AppSettings.Username = nameEntry.Text;
                var query = db.Table<TestPassed>().Where(u => u.User.Equals(AppSettings.Username)).FirstOrDefault();
                if (query != null)
                {
                    AppSettings.TestResult = db.Table<TestPassed>().Where(u => u.User.Equals(AppSettings.Username)).Select(u => u.TestResult).SingleOrDefault();
                    Application.Current.MainPage = new RecommendMenu();
                }
                else App.Current.MainPage = new NavigationPage(new SingleQuiz());
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Ошибка!", "Неправильно введено имя пользователя или пароль.", "Да", "Отмена");

                    if (result)
                        Application.Current.MainPage = new AuthPage();
                    else
                    {
                        Application.Current.MainPage = new AuthPage();
                    }
                });
            }
        }

        async private void SignUpButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RegistPage();
        }
    }
}