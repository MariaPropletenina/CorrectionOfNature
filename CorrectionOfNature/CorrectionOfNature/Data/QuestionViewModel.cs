using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Threading.Tasks;
using CorrectionOfNature.Tables;
using SQLite;
using System.IO;
using Xamarin.Forms;
using CorrectionOfNature.Views;
using System.Linq;

namespace CorrectionOfNature.Data
{
    public class QuestionViewModel : INotifyPropertyChanged
    {
        private int _currentAnswer = 0;
        public int CurrentAnswer
        {
            get { return this._currentAnswer; }
            set
            {
                this._currentAnswer = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("CurrentAnswer"));
            }
        }
        private string _question;
        public string Question
        {
            get { return this._question; }
            set
            {
                this._question = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Question"));
            }
        }

        private string _answer1;
        public string Answer1
        {
            get { return this._answer1; }
            set
            {
                this._answer1 = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer1"));
            }
        }

        private bool _answer1Enabled;
        public bool Answer1Enabled
        {
            get { return this._answer1Enabled; }
            set
            {
                this._answer1Enabled = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer1Enabled"));
            }
        }

        private string _answer2;
        public string Answer2
        {
            get { return this._answer2; }
            set
            {
                this._answer2 = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer2"));
            }
        }

        private bool _answer2Enabled;
        public bool Answer2Enabled
        {
            get { return this._answer2Enabled; }
            set
            {
                this._answer2Enabled = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer2Enabled"));
            }
        }

        private List<XamarinQuiz> _questionList;
        public List<XamarinQuiz> QuestionList
        {
            get { return this._questionList; }
            set
            {
                this._questionList = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("QuestionList"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private bool _isLoading;
        public bool IsLoading
        {
            get { return this._isLoading; }
            set
            {
                this._isLoading = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("IsLoading"));
            }
        }
        
        public async Task LoadQuestions()
        {
            IsLoading = true;
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            var db = new SQLiteConnection(dbpath);
            var xamarinQuizTable = db.Table<XamarinQuiz>();

            QuestionList = xamarinQuizTable.ToList();
            
            IsLoading = false;
            ChooseNewQuestion1();
        }

        public void ChooseNewQuestion1()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[0];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion2()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[1];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;
            
            IsLoading = false;
        }

        public void ChooseNewQuestion3()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[2];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion4()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[3];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion5()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[4];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion6()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[5];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion7()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[6];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion8()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[7];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion9()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[8];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion10()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[9];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion11()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[10];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion12()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[11];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion13()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[12];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion14()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[13];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion15()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[14];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion16()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[15];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion17()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[16];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion18()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[17];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion19()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[18];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion20()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[19];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion21()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[20];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion22()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[21];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion23()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[22];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion24()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[23];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion25()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[24];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion26()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[25];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion27()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[26];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion28()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[27];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion29()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[28];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion30()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[29];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion31()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[30];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion32()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[31];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion33()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[32];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion34()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[33];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion35()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[34];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion36()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[35];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion37()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[36];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion38()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[37];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion39()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[38];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion40()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[39];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion41()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[40];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion42()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[41];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion43()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[42];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion44()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[43];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion45()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[44];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion46()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[45];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion47()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[46];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion48()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[47];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion49()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[48];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion50()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[49];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion51()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[50];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion52()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[51];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion53()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[52];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion54()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[53];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion55()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[54];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion56()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[55];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion57()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[56];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion58()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[57];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion59()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[58];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion60()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[59];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion61()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[60];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion62()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[61];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion63()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[62];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion64()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[63];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion65()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[64];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion66()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[65];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion67()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[66];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion68()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[67];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion69()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[68];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion70()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[69];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion71()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[70];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion72()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[71];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion73()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[72];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion74()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[73];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion75()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[74];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion76()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[75];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion77()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[76];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion78()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[77];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion79()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[78];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion80()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[79];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion81()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[80];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion82()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[81];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion83()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[82];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion84()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[83];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion85()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[84];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion86()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[85];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion87()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[86];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }

        public void ChooseNewQuestion88()
        {
            IsLoading = true;

            XamarinQuiz selectedItem = QuestionList[87];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;

            IsLoading = false;
        }
    }
}
