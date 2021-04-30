using CorrectionOfNature.Data;
using CorrectionOfNature.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Timers;
//using System.Threading;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionOfNature.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskPage : ContentView
    {
        public static Timer MyTimer;
        public event EventHandler ToggleMenu;
        //Context Context = DependencyService.Get<TodoItemDatabase>().GetItemsAsync();
        //var Activity = (Activity)Context;

        public TaskPage()
        {
            InitializeComponent();
            //OnAppearing();
            /*Timer = new System.Timers.Timer(1000); //In milliseconds
            Timer.Elapsed += new ElapsedEventHandler(OnAppearing);
            Timer.AutoReset = true;
            Timer.Enabled = true;*/
            //RunThis();
        }

        void OnMenuTapped(object sender, System.EventArgs e)
        {
            ToggleMenu?.Invoke(sender, e);
        }

        protected async void OnAppearing(object sender, EventArgs e)
        {
            TodoItemDatabase database = await TodoItemDatabase.Instance;
            listView.ItemsSource = await database.GetItemsAsync();
            //BindingContext = listView.ItemsSource as TodoItem;
        }

        private void RunThis()
        {
            
            MyTimer = new System.Timers.Timer(1000); //In milliseconds
            MyTimer.Elapsed += new ElapsedEventHandler(OnAppearing);
            MyTimer.AutoReset = true;
            MyTimer.Enabled = true;
        }

        /*protected override async void OnAppearing()
        {
            base.OnAppearing();

            TodoItemDatabase database = await TodoItemDatabase.Instance;
            listView.ItemsSource = await database.GetItemsAsync();
        }*/

        async void OnItemAdded(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TodoItemPage
            {
                BindingContext = new TodoItem()
            });
            //OnAppearing();
        }

        async void OnListItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                await Navigation.PushAsync(new TodoItemPage
                {
                    BindingContext = e.SelectedItem as TodoItem
                });
            }
            //OnAppearing();
        }

        /*async void OnListItem(object sender, ItemsView e)
        {
            if (e.ItemsSource != null)
            {
                BindingContext = e.ItemsSource as TodoItem;
            }
        }*/
    }
}