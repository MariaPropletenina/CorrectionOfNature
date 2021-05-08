using CorrectionOfNature.Data;
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
    public partial class TodoListPage : ContentPage
    {
        public TodoListPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();

            TodoItemDatabase database = await TodoItemDatabase.Instance;
            listView.ItemsSource = await database.GetItemsAsync();
        }

        async void OnItemAdded(object sender, EventArgs e)
        {
            App.Current.MainPage = new NavigationPage(new TodoItemPage
            {
                BindingContext = new TodoItem()
            });
            /*await Navigation.PushAsync(new TodoItemPage
            {
                BindingContext = new TodoItem()
            });*/
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                App.Current.MainPage = new NavigationPage(new TodoItemPage
                {
                    BindingContext = e.SelectedItem as TodoItem
                });
                /*await Navigation.PushAsync(new TodoItemPage
                {
                    BindingContext = e.SelectedItem as TodoItem
                });*/
            }
        }
    }
}