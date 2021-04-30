using CorrectionOfNature.Data;
using CorrectionOfNature.Views.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionOfNature.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestPage : ContentPage
    {
        string username;
        public TestPage(/*string user*/)
        {
            InitializeComponent();
            //this.username = user;

            btnStart.IsEnabled = false;

            entryUsername.TextChanged += delegate
            {
                if (entryUsername.Text.Trim() != String.Empty) btnStart.IsEnabled = true;
                else btnStart.IsEnabled = false;
            };
        }

        private async void TaskButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecommendMenu(/*username*/));
        }

        public void NavigateToQuiz(object sender, EventArgs args)
        {
            AppSettings.Username = entryUsername.Text;
            Application.Current.MainPage = new SingleQuiz();
        }
    }
}