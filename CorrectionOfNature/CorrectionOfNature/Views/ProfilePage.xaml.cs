using CorrectionOfNature.Services;
using CorrectionOfNature.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Plugin.Media;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionOfNature.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ProfilePage : ContentView
    {
        public ProfilePage()
        {
            InitializeComponent();

            Login.Text = AppSettings.Username;
            Email.Text = AppSettings.Email;
            PhoneNumber.Text = AppSettings.PhoneNumber;

            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            using (var db = new SQLiteConnection(dbpath))
            {
                var avatar = db.Query<Avatar>("SELECT [Content] FROM [Avatar]").LastOrDefault();

                if (avatar != null)
                {
                    byte[] b = avatar.Content;
                    Stream ms = new MemoryStream(b);
                    image.Source = ImageSource.FromStream(() => ms);
                }
            }
        }

        async void OnPickPhotoButtonClicked(object sender, EventArgs e)
        {
            /*(sender as Button).IsEnabled = false;

            Stream stream = await DependencyService.Get<IPhotoPickerService>().GetImageStreamAsync();
            
            if (stream != null)
            {
                image.Source = ImageSource.FromStream(() => stream);
            }*/

            if (!CrossMedia.Current.IsPickPhotoSupported)
            {
                return;
            }

            var file = await Plugin.Media.CrossMedia.Current.PickPhotoAsync(new Plugin.Media.Abstractions.PickMediaOptions
            {
                PhotoSize = Plugin.Media.Abstractions.PhotoSize.Full,
            });

            if (file == null)
                return;

            var bytesToStream = GetImageBytes(file.GetStream());

            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<Avatar>();
            Avatar item = new Avatar()
            {
                Content = bytesToStream
            };
            db.Insert(item);

            image.Source = ImageSource.FromStream(() =>
            {
                var stream = file.GetStream();
                file.Dispose();
                return stream;
            });

            //(sender as Button).IsEnabled = true;
        }

        private byte[] GetImageBytes(Stream stream)
        {
            byte[] ImageBytes;
            using (var memoryStream = new System.IO.MemoryStream())
            {
                stream.CopyTo(memoryStream);
                ImageBytes = memoryStream.ToArray();
            }
            return ImageBytes;
        }

        public event EventHandler ToggleMenu;

        void OnMenuTapped(object sender, System.EventArgs e)
        {
            ToggleMenu?.Invoke(sender, e);
        }
    }
}