using CorrectionOfNature.Data;
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
    public partial class ChatMenu : ContentPage
    {
        ChatPageViewModel vm;

        const float FlyoutCornerRadius = 25f;

        //public event EventHandler ToggleMenu;

        bool _isFlyoutOpen = false;
        double _scale;
        uint _flyoutSpeed = 200;
        double _pagePositionX;
        double _flyoutTranslationX;

        public ChatMenu(string username)
        {
            InitializeComponent();

            BindingContext = vm = new ChatPageViewModel(username);

            _scale = ChatContent.Scale;
            _pagePositionX = ChatContent.TranslationX;
            ChatContent.SizeChanged += OnMainContentSizeChanged;
        }

        /*void OnMenuTapped(object sender, System.EventArgs e)
        {
            ToggleMenu?.Invoke(sender, e);
        }*/

        void OnMainContentSizeChanged(object sender, EventArgs e)
        {
            ChatContent.SizeChanged -= OnMainContentSizeChanged;

            _flyoutTranslationX = ChatContent.Width * .75;

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
                ToggleFlyout();
        }

        void FlyoutOpen(object sender, SwipedEventArgs e)
        {
            if (!_isFlyoutOpen)
                ToggleFlyout();
        }

        void ToggleFlyout()
        {
            if (_isFlyoutOpen)
            {
                ChatContent.ScaleTo(_scale, _flyoutSpeed);
                ChatContent.TranslateTo(_pagePositionX, Flyout.TranslationY, _flyoutSpeed);
                //ChatContent.CornerRadius = FlyoutCornerRadius;
            }
            else
            {
                ChatContent.ScaleTo(_scale * .9, _flyoutSpeed);
                ChatContent.TranslateTo(Flyout.TranslationX + _flyoutTranslationX, Flyout.TranslationY, _flyoutSpeed);
                //ChatContent.CornerRadius = FlyoutCornerRadius;
            }

            _isFlyoutOpen = !_isFlyoutOpen;
        }

        /*async void Button_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(UserName.Text))
            {
                await DisplayAlert("Easy Chat", "Please enter username", "OK");
                return;
            }

            await Navigation.PushAsync(new MyChat(UserName.Text));
        }*/
    }
}