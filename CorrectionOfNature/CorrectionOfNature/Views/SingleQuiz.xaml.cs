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
        int choice1, choice2, choice3, choice4, choice5, choice6, choice7, choice8, choice9, choice10, choice11,
            choice12, choice13, choice14, choice15, choice16, choice17, choice18, choice19, choice20, choice21,
            choice22, choice23, choice24, choice25, choice26, choice27, choice28, choice29, choice30, choice31,
            choice32, choice33, choice34, choice35, choice36, choice37, choice38, choice39, choice40, choice41,
            choice42, choice43, choice44, choice45, choice46, choice47, choice48, choice49, choice50, choice51, 
            choice52, choice53, choice54, choice55, choice56, choice57, choice58, choice59, choice60, choice61, 
            choice62, choice63, choice64, choice65, choice66, choice67, choice68, choice69, choice70, choice71, 
            choice72, choice73, choice74, choice75, choice76, choice77, choice78, choice79, choice80, choice81, 
            choice82, choice83, choice84, choice85, choice86, choice87, choice88 = 0;

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
                    //AppSettings.Score += score;
                    choice1 += 1;
                    DoAnswer();
                    //return;
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(2))
                {
                    choice2 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(3))
                {
                    choice3 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(4))
                {
                    choice4 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(5))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(6))
                {
                    choice6 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(7))
                {
                    choice7 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(8))
                {
                    choice8 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(9))
                {
                    choice9 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(10))
                {
                    choice10 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(11))
                {
                    choice11 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(12))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(13))
                {
                    choice13 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(14))
                {
                    choice14 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(15))
                {
                    choice15 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(16))
                {
                    choice16 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(17))
                {
                    choice17 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(18))
                {
                    choice18 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(19))
                {
                    choice19 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(20))
                {
                    choice20 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(21))
                {
                    choice21 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(22))
                {
                    choice22 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(23))
                {
                    choice23 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(24))
                {
                    choice24 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(25))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(26))
                {
                    choice26 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(27))
                {
                    choice27 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(28))
                {
                    choice28 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(29))
                {
                    choice29 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(30))
                {
                    choice30 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(31))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(32))
                {
                    choice32 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(33))
                {
                    choice33 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(34))
                {
                    choice34 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(35))
                {
                    choice35 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(36))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(37))
                {
                    choice37 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(38))
                {
                    choice38 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(39))
                {
                    choice39 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(40))
                {
                    choice40 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(41))
                {
                    choice41 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(42))
                {
                    choice42 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(43))
                {
                    choice43 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(44))
                {
                    choice44 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(45))
                {
                    choice45 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(46))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(47))
                {
                    choice47 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(48))
                {
                    choice48 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(49))
                {
                    choice49 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(50))
                {
                    choice50 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(51))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(52))
                {
                    choice52 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(53))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(54))
                {
                    choice54 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(55))
                {
                    choice55 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(56))
                {
                    choice56 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(57))
                {
                    choice57 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(58))
                {
                    choice58 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(59))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(60))
                {
                    choice60 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(61))
                {
                    choice61 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(62))
                {
                    choice62 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(63))
                {
                    choice63 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(64))
                {
                    choice64 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(65))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(66))
                {
                    choice66 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(67))
                {
                    choice67 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(68))
                {
                    choice68 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(69))
                {
                    choice69 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(70))
                {
                    choice70 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(71))
                {
                    choice71 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(72))
                {
                    choice72 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(73))
                {
                    choice73 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(74))
                {
                    choice74 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(75))
                {
                    choice75 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(76))
                {
                    choice76 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(77))
                {
                    choice77 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(78))
                {
                    choice78 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(79))
                {
                    choice79 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(80))
                {
                    choice80 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(81))
                {
                    choice81 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(82))
                {
                    choice82 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(83))
                {
                    choice83 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(84))
                {
                    choice84 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(85))
                {
                    choice85 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(86))
                {
                    choice86 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(87))
                {
                    choice87 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Да")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(88))
                {
                    choice88 += 1;
                    DoAnswer();
                }
            };

            btnAnswerTwo.Clicked += (sender, ea) =>
            {
                if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(1))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(2))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(3))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(4))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(5))
                {
                    choice5 += 1;
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(6))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(7))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(8))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(9))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(10))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(11))
                {
                    DoAnswer();
                }
                else if (((QuestionViewModel)BindingContext).CheckQuestion("Нет")
                    && ((QuestionViewModel)BindingContext).CheckIfCorrect(12))
                {
                    choice12 += 1;
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
                    choice25 += 1;
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
                    choice36 += 1;
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
                    choice46 += 1;
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
                    choice51 += 1;
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
                    choice59 += 1;
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
            AppSettings.Score1 = (choice7 + choice19 + choice22 + choice29 + choice41
                + choice44 + choice63 + choice66 + choice73 + choice85 + choice88 + choice51) * 2;

            AppSettings.Score2 = (choice2 + choice15 + choice24 + choice34 + choice37
                + choice56 + choice68 + choice78 + choice81 + choice12 + choice46 + choice59) * 2;

            AppSettings.Score3 = (choice4 + choice14 + choice17 + choice26 + choice39
                + choice48 + choice58 + choice61 + choice70 + choice80 + choice83 + choice36) * 2;

            AppSettings.Score4 = (choice8 + choice20 + choice30 + choice42 + choice52
                + choice64 + choice74 + choice86) * 3;

            AppSettings.Score5 = (choice1 + choice11 + choice23 + choice33 + choice45
                + choice55 + choice67 + choice77) * 3;

            AppSettings.Score6 = (choice9 + choice21 + choice43 + choice75 + choice87) * 3;

            AppSettings.Score7 = (choice16 + choice27 + choice38 + choice49 + choice60
                + choice71 + choice82 + choice5) * 3;

            AppSettings.Score8 = (choice10 + choice32 + choice54 + choice76) * 6;

            AppSettings.Score9 = (choice3 + choice13 + choice35 + choice47 + choice57
                + choice69 + choice79 + choice25) * 3;

            AppSettings.Score10 = (choice6 + choice18 + choice28 + choice40 + choice50
                + choice62 + choice72 + choice84) * 3;

            Application.Current.MainPage = new ThanksForPlaying();
        }
    }
}