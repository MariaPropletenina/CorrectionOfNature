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

        /*private string _answer3;
        public string Answer3
        {
            get { return this._answer3; }
            set
            {
                this._answer3 = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer3"));
            }
        }*/

        /*private bool _answer3Enabled;
        public bool Answer3Enabled
        {
            get { return this._answer3Enabled; }
            set
            {
                this._answer3Enabled = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Answer3Enabled"));
            }
        }*/

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
        Random rnd = new Random();

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

        /*private string _message;
        public string Message
        {
            get
            {
                return this._message;
            }
            set
            {
                this._message = value;
                PropertyChanged(this,
                    new PropertyChangedEventArgs("Message"));
            }
        }*/

        public QuestionViewModel()
        {
            //LoadQuestions();
        }

        /*public bool CheckIfCorrect(int correct)
        {
            if (CorrectAnswer == correct)
            {
                Message = "Correcto !!";
                return true;
            }
            Message = "No señor !!";
            return true;
        }*/
        
        public bool CheckQuestion(string current)
        {
            if (Answer1 == current)
            {
                return true;
            }
            return Answer2 == current ? true : true;
        }

        public bool CheckIfCorrect(int correct)
        {
            if (CurrentAnswer == correct)
            {
                /*var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
                var db = new SQLiteConnection(dbpath);
                db.Delete<XamarinQuiz>(CurrentAnswer.Equals(correct));*/
                //var removeThis = QuestionList.Find(u => u.CurrentAnswer.Equals(correct));
                //QuestionList.Remove(removeThis);
                return true;
            }
            return true;
        }

        public async Task LoadQuestions()
        {
            IsLoading = true;
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            var db = new SQLiteConnection(dbpath);
            var xamarinQuizTable = db.Table<XamarinQuiz>();

            QuestionList = xamarinQuizTable.ToList();
            
            IsLoading = false;
            ChooseNewQuestion();
        }

        public void ChooseNewQuestion()
        {
            IsLoading = true;

            int questionNumber = rnd.Next(0, QuestionList.Count);
            XamarinQuiz selectedItem = QuestionList[questionNumber];

            Answer1Enabled = true;
            Answer2Enabled = true;

            Question = selectedItem.Question;
            Answer1 = selectedItem.Answer1;
            Answer2 = selectedItem.Answer2;

            CurrentAnswer = selectedItem.CurrentAnswer;
            //var removeThis = Enumerable.Range(0, QuestionList.Count).Select(x => x = questionNumber);
            //var removeThis = QuestionList.

            IsLoading = false;

            //QuestionList.Clear(QuestionList[questionNumber]);
            //rnd.Next(0, QuestionList.Count);

            //var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            //var db = new SQLiteConnection(dbpath);

            //var removeThis = db.Table<XamarinQuiz>().Where(x => x.Id == questionNumber);
            //var del = (App.Current as App).Id;
            /*var removeThis = db.Table<XamarinQuiz>().Where(x => x.Id == questionNumber);
            db.Delete<XamarinQuiz>(removeThis);*/
            /*var removeThis = QuestionList.Find(u => u.Id.Equals(questionNumber));
            QuestionList.Remove(removeThis);
            db.Update(QuestionList);*/
            //db.Query<XamarinQuiz>("DELETE FROM [XamarinQuiz] WHERE [Id] = {questionNumber}");
            //db.Delete();

            /*var todoItem = (TodoItem)BindingContext;
            TodoItemDatabase database = await TodoItemDatabase.Instance;
            await database.DeleteItemAsync(todoItem);
            await Navigation.PopAsync();*/

            //QuestionList = db.Table<XamarinQuiz>().ToList();
        }
    }
}
