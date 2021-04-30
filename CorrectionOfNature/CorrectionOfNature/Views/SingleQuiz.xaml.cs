using CorrectionOfNature.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CorrectionOfNature.Tables;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CorrectionOfNature.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SingleQuiz : ContentPage
    {
        int _choice = 0;
        int score = 1;

        public SingleQuiz()
        {
            InitializeComponent();
            ((QuestionViewModel)BindingContext).LoadQuestions();

            btnAnswerOne.Clicked += (sender, ea) =>
            {
                /*if (((QuestionViewModel)BindingContext).CheckIfCorrect(1)) DoAnswer();
                else
                {
                    score = score / 2;
                }*/
                if (((QuestionViewModel)BindingContext).CheckQuestion("Да") 
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(1))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(2))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(3))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(4))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(5))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(6))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(7))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(8))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(9))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(10))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(11))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(12))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(13))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(14))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(15))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(16))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(17))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(18))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(19))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(20))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(21))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(22))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(23))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(24))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(25))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(26))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(27))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(28))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(29))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(30))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(31))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(32))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(33))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(34))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(35))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(36))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(37))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(38))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(39))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(40))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(41))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(42))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(43))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(44))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(45))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(46))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(47))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(48))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(49))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(50))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(51))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(52))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(53))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(54))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(55))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(56))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(57))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(58))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(59))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(60))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(61))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(62))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(63))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(64))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(65))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(66))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(67))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(68))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(69))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(70))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(71))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(72))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(73))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(74))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(75))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(76))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(77))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(78))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(79))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(80))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(81))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(82))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(83))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(84))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(85))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(86))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(87))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(88))
                {
                    AppSettings.Score += score;
                    DoAnswer();
                }
            };

            btnAnswerTwo.Clicked += (sender, ea) =>
            {
                if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(1))
                {
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(2))
                {
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(3))
                {
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(4))
                {
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(5))
                {
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(6))
                {
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(7))
                {
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(8))
                {
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(9))
                {
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(10))
                {
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(11))
                {
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(12))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(13))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(14))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(15))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(16))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(17))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(18))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(19))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(20))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(21))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(22))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(23))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(24))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(25))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(26))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(27))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(28))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(29))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(30))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(31))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(32))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(33))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(34))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(35))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(36))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(37))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(38))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(39))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(40))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(41))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(42))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(43))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(44))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(45))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(46))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(47))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(48))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(49))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(50))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(51))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(52))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(53))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(54))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(55))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(56))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(57))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(58))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(59))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(60))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(61))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(62))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(63))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(64))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(65))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(66))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(67))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(68))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(69))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(70))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(71))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(72))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(73))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(74))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(75))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(76))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(77))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(78))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(79))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(80))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(81))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(82))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(83))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(84))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(85))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(86))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(87))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(88))
                {
                    DoAnswer();
                }
            };
        }

        private void DoAnswer()
        {
            if (AppSettings.CurrentQuestion < AppSettings.QUESTIONS_COUNT)
            {
                AppSettings.CurrentQuestion++;
                ((QuestionViewModel)BindingContext).ChooseNewQuestion();
            }
            else
            {
                NavigateToEndPage();
            }
        }

        private void NavigateToEndPage()
        {
            Application.Current.MainPage = new ThanksForPlaying();
        }
    }
}