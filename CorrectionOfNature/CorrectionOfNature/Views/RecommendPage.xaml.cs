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
    public partial class RecommendPage : ContentView
    {
        public RecommendPage()
        {
            InitializeComponent();
        }

        public event EventHandler ToggleMenu;

        void OnMenuTapped(object sender, System.EventArgs e)
        {
            ToggleMenu?.Invoke(sender, e);
        }

        private void test_Clicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new SingleQuiz());
        }
    }
}