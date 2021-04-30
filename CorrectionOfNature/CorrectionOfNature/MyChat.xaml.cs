using CorrectionOfNature.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionOfNature
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyChat : ContentPage
    {
        ChatPageViewModel vm;

        public MyChat(string username)
        {
            InitializeComponent();

            BindingContext = vm = new ChatPageViewModel(username);
        }
    }
}