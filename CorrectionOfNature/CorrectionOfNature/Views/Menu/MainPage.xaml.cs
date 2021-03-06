using CorrectionOfNature.Data;
using CorrectionOfNature.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionOfNature.Views.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public event EventHandler ToggleMenu;

        const float FlyoutCornerRadius = 25f;

        bool _isFlyoutOpen = false;
        double _scale;
        uint _flyoutSpeed = 200;
        double _pagePositionX;
        double _flyoutTranslationX;
        public MainPage()
        {
            InitializeComponent();

            _scale = MainContent.Scale;
            _pagePositionX = MainContent.TranslationX;
            MainContent.SizeChanged += OnMainContentSizeChanged;
        }

        void OnMenuTapped(object sender, System.EventArgs e)
        {
            ToggleMenu?.Invoke(sender, e);
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

        void OnMainContentSizeChanged(object sender, EventArgs e)
        {
            MainContent.SizeChanged -= OnMainContentSizeChanged;

            _flyoutTranslationX = MainContent.Width * .75;

            if (Flyout.Children.Count == 1 && Flyout.Children[0] is Layout menuPage)
            {
                var flyoutPadding = Flyout.Width - (Flyout.Width * .8);
                (Flyout.Children[0] as Layout).Padding = new Thickness(0, 0, flyoutPadding, 0);
            }
        }

        void OnToggleMenu(object sender, EventArgs e)
        {
            ToggleFlyout();
        }

        void FlyoutClose(object sender, SwipedEventArgs e)
        {
            if (_isFlyoutOpen)
            {
                ToggleFlyout();
            }    
        }

        void FlyoutOpen(object sender, SwipedEventArgs e)
        {
            if (!_isFlyoutOpen)
            {
                ToggleFlyout();
            }
        }

        void ToggleFlyout()
        {
            if (_isFlyoutOpen)
            {
                MainContent.ScaleTo(_scale, _flyoutSpeed);
                MainContent.TranslateTo(_pagePositionX, Flyout.TranslationY, _flyoutSpeed);
                //MainContent.CornerRadius = 1;
            }
            else
            {
                MainContent.ScaleTo(_scale * .9, _flyoutSpeed);
                MainContent.TranslateTo(Flyout.TranslationX + _flyoutTranslationX, Flyout.TranslationY, _flyoutSpeed);
                //MainContent.CornerRadius = FlyoutCornerRadius;
            }

            _isFlyoutOpen = !_isFlyoutOpen;
        }
    }
}