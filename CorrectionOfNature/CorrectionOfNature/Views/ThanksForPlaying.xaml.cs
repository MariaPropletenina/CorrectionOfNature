using CorrectionOfNature.Tables;
using CorrectionOfNature.Views.Menu;
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
            lblScore1.Text = AppSettings.Score1.ToString();
            lblScore2.Text = AppSettings.Score2.ToString();
            lblScore3.Text = AppSettings.Score3.ToString();
            lblScore4.Text = AppSettings.Score4.ToString();
            lblScore5.Text = AppSettings.Score5.ToString();
            lblScore6.Text = AppSettings.Score6.ToString();
            lblScore7.Text = AppSettings.Score7.ToString();
            lblScore8.Text = AppSettings.Score8.ToString();
            lblScore9.Text = AppSettings.Score9.ToString();
            lblScore10.Text = AppSettings.Score10.ToString();
        }

        private void TaskButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new RecommendMenu();
        }

        public void InsertUser()
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            var db = new SQLiteConnection(dbpath);

            UserScore item = new UserScore()
            {
                Username = AppSettings.Username,
                Score1 = AppSettings.Score1,
                Score2 = AppSettings.Score2,
                Score3 = AppSettings.Score3,
                Score4 = AppSettings.Score4,
                Score5 = AppSettings.Score5,
                Score6 = AppSettings.Score6,
                Score7 = AppSettings.Score7,
                Score8 = AppSettings.Score8,
                Score9 = AppSettings.Score9,
                Score10 = AppSettings.Score10
            };

            db.Insert(item);
        }
    }
}