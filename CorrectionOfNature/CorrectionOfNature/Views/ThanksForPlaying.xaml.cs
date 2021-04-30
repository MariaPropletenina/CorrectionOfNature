using CorrectionOfNature.Tables;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionOfNature.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ThanksForPlaying : ContentPage
    {
        public ThanksForPlaying()
        {
            InitializeComponent();
            InsertUser();
            lblScore.Text = AppSettings.Score.ToString();
            lblUsername.Text = AppSettings.Username;
        }

        public void InsertUser()
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            var db = new SQLiteConnection(dbpath);

            UserScore item = new UserScore()
            {
                Username = AppSettings.Username,
                Score = AppSettings.Score
            };

            db.Insert(item);
        }
    }
}