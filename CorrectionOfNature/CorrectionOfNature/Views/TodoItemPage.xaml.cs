using CorrectionOfNature.Data;
using CorrectionOfNature.Views.Menu;
using CorrectionOfNature.Tables;
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
    public partial class TodoItemPage : ContentPage
    {
        public TodoItemPage()
        {
            InitializeComponent();
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            TodoItemDatabase database = await TodoItemDatabase.Instance;
            await database.SaveItemAsync(todoItem);
            //await Navigation.PopAsync();
            App.Current.MainPage = new NavigationPage(new MainPage());
        }

        async void OnDeleteClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            TodoItemDatabase database = await TodoItemDatabase.Instance;
            await database.DeleteItemAsync(todoItem);
            //await Navigation.PopAsync();
            App.Current.MainPage = new NavigationPage(new MainPage());
        }

        async void OnCancelClicked(object sender, EventArgs e)
        {
            //await Navigation.PopAsync();
            App.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}