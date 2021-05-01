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
        public TestPage()
        {
            InitializeComponent();

            btnStart.IsEnabled = false;

            entryUsername.TextChanged += delegate
            {
                if (entryUsername.Text.Trim() != String.Empty) btnStart.IsEnabled = true;
                else btnStart.IsEnabled = false;
            };
        }

        private async void TaskButton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RecommendMenu());
        }

        public void NavigateToQuiz(object sender, EventArgs args)
        {
            Application.Current.MainPage = new SingleQuiz();
        }
    }
}