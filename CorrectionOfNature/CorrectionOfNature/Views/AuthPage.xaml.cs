using CorrectionOfNature.Tables;
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

            var myquery = db.Table<User>()
                .Where(u => u.Login.Equals(nameEntry.Text) && u.Password.Equals(passwordEntry.Text)).FirstOrDefault();

            if (myquery != null)
            {
                AppSettings.Username = nameEntry.Text;
                //var query1 = db.Table<User>().Select(u => u.Email == myquery.Email);
                //AppSettings.Email = db.Table<User>().Select(u => u.Email.Equals(myquery.Email)).ToString();
                //db.Query<TodoItem>("SELECT [Email] FROM [User] WHERE [Done] = 0");
                //AppSettings.PhoneNumber = db.Table<User>().Select(u => u.PhoneNumber.Equals(myquery.PhoneNumber)).ToString();
                App.Current.MainPage = new NavigationPage(new SingleQuiz());
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