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
using CorrectionOfNature.DependencyServices;

namespace CorrectionOfNature.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoItemPage : ContentPage
    {
        INotificationManager notificationManager;
        int notificationNumber = 0;

        public TodoItemPage()
        {
            InitializeComponent();

            notificationManager = DependencyService.Get<INotificationManager>();
            notificationManager.NotificationReceived += (sender, eventArgs) =>
            {
                var evtData = (NotificationEventArgs)eventArgs;
                ShowNotification(evtData.Title, evtData.Message);
            };
        }

        async void OnSaveClicked(object sender, EventArgs e)
        {
            var todoItem = (TodoItem)BindingContext;
            TodoItemDatabase database = await TodoItemDatabase.Instance;
            await database.SaveItemAsync(todoItem);
            //await Navigation.PopAsync();

            notificationNumber++;
            string title = $"Уведомление #{notificationNumber}";
            string message = $"Срок выполнения задачи '{todoItem.Name}' истёк!";
            TimeSpan timeSpan = EndDate.Date - StartDate.Date;
            //TimeSpan timeSpan = this.EndTime.Time;
            //DateTime dateTime = this.EndDate.Date;
            //TimeSpan currentDateTime = new TimeSpan(/*dateTime.Year, dateTime.Month, dateTime.Day, */timeSpan.Hours, timeSpan.Minutes, timeSpan.Seconds);
            notificationManager.SendNotification(title, message, DateTime.Now.AddDays(timeSpan.Days));

            if (SwitchRemember.IsToggled)
            {
                notificationNumber++;
                string title2 = $"Напоминание #{notificationNumber}";
                string message2 = $"Вы создали на выполнение задачу: '{todoItem.Name}'";
                notificationManager.SendNotification(title2, message2, DateTime.Now.AddMinutes(RememberTime.Time.Minutes));
            }

            App.Current.MainPage = new NavigationPage(new MainPage());
        }

        void ShowNotification(string title, string message)
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                var msg = new Label()
                {
                    Text = $"Notification Received:\nTitle: {title}\nMessage: {message}"
                };
                stackLayout.Children.Add(msg);
            });
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