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
    public partial class RegistPage : ContentPage
    {
        public RegistPage()
        {
            InitializeComponent();
        }

        private void RegiserButton_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<User>();

            var item = new User()
            {
                //UserName = nameEntry.Text,
                Login = loginEntry.Text,
                Email = emailEntry.Text,
                Password = passwordEntry.Text,
                PhoneNumber = phoneNumberEntry.Text,
                //CurrentUser = nameEntry.Text
            };

            db.Insert(item);
            AppSettings.Email = emailEntry.Text;
            AppSettings.PhoneNumber = phoneNumberEntry.Text;
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await this.DisplayAlert("Добро Пожаловать!", "Регистрация пользователя прошла успешно.", "Да", "Отмена");

                if (result) Application.Current.MainPage = new AuthPage();
            });
        }

        private async void SignInButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new AuthPage();
        }
    }
}