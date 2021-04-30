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
        string name;
        public AuthPage(/*string user*/)
        {
            InitializeComponent();
            //this.username = user = nameEntry.Text;
        }

        public string UsernameElement()
        {
            return nameEntry.Text;
        }

        public string Username()
        {
            return name;
        }

        async private void LoginButton_Clicked(object sender, EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            var db = new SQLiteConnection(dbpath);

            var myquery = db.Table<User>()
                .Where(u => u.UserName.Equals(nameEntry.Text) && u.Password.Equals(passwordEntry.Text)).FirstOrDefault();

            if (myquery != null)
            {
                name = UsernameElement();
                App.Current.MainPage = new NavigationPage(new TestPage(/*nameEntry.Text*/));
            }
            else
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await this.DisplayAlert("Ошибка!", "Неправильно введено имя пользователя или пароль.", "Да", "Отмена");

                    if (result)
                        await Navigation.PushAsync(new AuthPage());
                    else
                    {
                        await Navigation.PushAsync(new AuthPage());
                    }
                });
            }
        }

        async private void SignUpButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistPage());
        }
    }
}