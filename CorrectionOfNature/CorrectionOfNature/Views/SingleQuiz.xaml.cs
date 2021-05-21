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
                if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 1)
                {
                    choice1 += 1;
                    DoAnswer1();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 2)
                {
                    choice2 += 1;
                    DoAnswer2();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 3)
                {
                    choice3 += 1;
                    DoAnswer3();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 4)
                {
                    choice4 += 1;
                    DoAnswer4();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 5)
                {
                    DoAnswer5();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 6)
                {
                    choice6 += 1;
                    DoAnswer6();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 7)
                {
                    choice7 += 1;
                    DoAnswer7();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 8)
                {
                    choice8 += 1;
                    DoAnswer8();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 9)
                {
                    choice9 += 1;
                    DoAnswer9();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 10)
                {
                    choice10 += 1;
                    DoAnswer10();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 11)
                {
                    choice11 += 1;
                    DoAnswer11();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 12)
                {
                    DoAnswer12();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 13)
                {
                    choice13 += 1;
                    DoAnswer13();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 14)
                {
                    choice14 += 1;
                    DoAnswer14();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 15)
                {
                    choice15 += 1;
                    DoAnswer15();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 16)
                {
                    choice16 += 1;
                    DoAnswer16();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 17)
                {
                    choice17 += 1;
                    DoAnswer17();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 18)
                {
                    choice18 += 1;
                    DoAnswer18();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 19)
                {
                    choice19 += 1;
                    DoAnswer19();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 20)
                {
                    choice20 += 1;
                    DoAnswer20();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 21)
                {
                    choice21 += 1;
                    DoAnswer21();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 22)
                {
                    choice22 += 1;
                    DoAnswer22();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 23)
                {
                    choice23 += 1;
                    DoAnswer23();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 24)
                {
                    choice24 += 1;
                    DoAnswer24();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 25)
                {
                    DoAnswer25();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 26)
                {
                    choice26 += 1;
                    DoAnswer26();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 27)
                {
                    choice27 += 1;
                    DoAnswer27();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 28)
                {
                    choice28 += 1;
                    DoAnswer28();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 29)
                {
                    choice29 += 1;
                    DoAnswer29();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 30)
                {
                    choice30 += 1;
                    DoAnswer30();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 31)
                {
                    DoAnswer31();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 32)
                {
                    choice32 += 1;
                    DoAnswer32();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 33)
                {
                    choice33 += 1;
                    DoAnswer33();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 34)
                {
                    choice34 += 1;
                    DoAnswer34();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 35)
                {
                    choice35 += 1;
                    DoAnswer35();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 36)
                {
                    DoAnswer36();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 37)
                {
                    choice37 += 1;
                    DoAnswer37();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 38)
                {
                    choice38 += 1;
                    DoAnswer38();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 39)
                {
                    choice39 += 1;
                    DoAnswer39();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 40)
                {
                    choice40 += 1;
                    DoAnswer40();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 41)
                {
                    choice41 += 1;
                    DoAnswer41();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 42)
                {
                    choice42 += 1;
                    DoAnswer42();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 43)
                {
                    choice43 += 1;
                    DoAnswer43();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 44)
                {
                    choice44 += 1;
                    DoAnswer44();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 45)
                {
                    choice45 += 1;
                    DoAnswer45();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 46)
                {
                    DoAnswer46();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 47)
                {
                    choice47 += 1;
                    DoAnswer47();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 48)
                {
                    choice48 += 1;
                    DoAnswer48();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 49)
                {
                    choice49 += 1;
                    DoAnswer49();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 50)
                {
                    choice50 += 1;
                    DoAnswer50();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 51)
                {
                    DoAnswer51();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 52)
                {
                    choice52 += 1;
                    DoAnswer52();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 53)
                {
                    DoAnswer53();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 54)
                {
                    choice54 += 1;
                    DoAnswer54();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 55)
                {
                    choice55 += 1;
                    DoAnswer55();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 56)
                {
                    choice56 += 1;
                    DoAnswer56();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 57)
                {
                    choice57 += 1;
                    DoAnswer57();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 58)
                {
                    choice58 += 1;
                    DoAnswer58();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 59)
                {
                    DoAnswer59();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 60)
                {
                    choice60 += 1;
                    DoAnswer60();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 61)
                {
                    choice61 += 1;
                    DoAnswer61();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 62)
                {
                    choice62 += 1;
                    DoAnswer62();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 63)
                {
                    choice63 += 1;
                    DoAnswer63();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 64)
                {
                    choice64 += 1;
                    DoAnswer64();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 65)
                {
                    DoAnswer65();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 66)
                {
                    choice66 += 1;
                    DoAnswer66();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 67)
                {
                    choice67 += 1;
                    DoAnswer67();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 68)
                {
                    choice68 += 1;
                    DoAnswer68();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 69)
                {
                    choice69 += 1;
                    DoAnswer69();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 70)
                {
                    choice70 += 1;
                    DoAnswer70();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 71)
                {
                    choice71 += 1;
                    DoAnswer71();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 72)
                {
                    choice72 += 1;
                    DoAnswer72();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 73)
                {
                    choice73 += 1;
                    DoAnswer73();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 74)
                {
                    choice74 += 1;
                    DoAnswer74();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 75)
                {
                    choice75 += 1;
                    DoAnswer75();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 76)
                {
                    choice76 += 1;
                    DoAnswer76();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 77)
                {
                    choice77 += 1;
                    DoAnswer77();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 78)
                {
                    choice78 += 1;
                    DoAnswer78();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 79)
                {
                    choice79 += 1;
                    DoAnswer79();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 80)
                {
                    choice80 += 1;
                    DoAnswer80();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 81)
                {
                    choice81 += 1;
                    DoAnswer81();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 82)
                {
                    choice82 += 1;
                    DoAnswer82();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 83)
                {
                    choice83 += 1;
                    DoAnswer83();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 84)
                {
                    choice84 += 1;
                    DoAnswer84();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 85)
                {
                    choice85 += 1;
                    DoAnswer85();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 86)
                {
                    choice86 += 1;
                    DoAnswer86();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 87)
                {
                    choice87 += 1;
                    DoAnswer87();
                }
                else if (((QuestionViewModel)BindingContext).Answer1 == "Да"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 88)
                {
                    choice88 += 1;
                    DoAnswer88();
                }
            };

            btnAnswerTwo.Clicked += (sender, ea) =>
            {
                if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 1)
                {
                    DoAnswer1();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 2)
                {
                    DoAnswer2();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 3)
                {
                    DoAnswer3();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 4)
                {
                    DoAnswer4();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 5)
                {
                    choice5 += 1;
                    DoAnswer5();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 6)
                {
                    DoAnswer6();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 7)
                {
                    DoAnswer7();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 8)
                {
                    DoAnswer8();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 9)
                {
                    DoAnswer9();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 10)
                {
                    DoAnswer10();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 11)
                {
                    DoAnswer11();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 12)
                {
                    choice12 += 1;
                    DoAnswer12();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 13)
                {
                    DoAnswer13();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 14)
                {
                    DoAnswer14();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 15)
                {
                    DoAnswer15();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 16)
                {
                    DoAnswer16();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 17)
                {
                    DoAnswer17();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 18)
                {
                    DoAnswer18();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 19)
                {
                    DoAnswer19();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 20)
                {
                    DoAnswer20();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 21)
                {
                    DoAnswer21();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 22)
                {
                    DoAnswer22();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 23)
                {
                    DoAnswer23();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 24)
                {
                    DoAnswer24();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 25)
                {
                    choice25 += 1;
                    DoAnswer25();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 26)
                {
                    DoAnswer26();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 27)
                {
                    DoAnswer27();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 28)
                {
                    DoAnswer28();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 29)
                {
                    DoAnswer29();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 30)
                {
                    DoAnswer30();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 31)
                {
                    DoAnswer31();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 32)
                {
                    DoAnswer32();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 33)
                {
                    DoAnswer33();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 34)
                {
                    DoAnswer34();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 35)
                {
                    DoAnswer35();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 36)
                {
                    choice36 += 1;
                    DoAnswer36();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 37)
                {
                    DoAnswer37();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 38)
                {
                    DoAnswer38();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 39)
                {
                    DoAnswer39();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 40)
                {
                    DoAnswer40();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 41)
                {
                    DoAnswer41();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 42)
                {
                    DoAnswer42();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 43)
                {
                    DoAnswer43();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 44)
                {
                    DoAnswer44();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 45)
                {
                    DoAnswer45();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 46)
                {
                    choice46 += 1;
                    DoAnswer46();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 47)
                {
                    DoAnswer47();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 48)
                {
                    DoAnswer48();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 49)
                {
                    DoAnswer49();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 50)
                {
                    DoAnswer50();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 51)
                {
                    choice51 += 1;
                    DoAnswer51();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 52)
                {
                    DoAnswer52();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 53)
                {
                    DoAnswer53();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 54)
                {
                    DoAnswer54();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 55)
                {
                    DoAnswer55();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 56)
                {
                    DoAnswer56();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 57)
                {
                    DoAnswer57();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 58)
                {
                    DoAnswer58();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 59)
                {
                    choice59 += 1;
                    DoAnswer59();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 60)
                {
                    DoAnswer60();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 61)
                {
                    DoAnswer61();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 62)
                {
                    DoAnswer62();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 63)
                {
                    DoAnswer63();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 64)
                {
                    DoAnswer64();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 65)
                {
                    DoAnswer65();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 66)
                {
                    DoAnswer66();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 67)
                {
                    DoAnswer67();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 68)
                {
                    DoAnswer68();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 69)
                {
                    DoAnswer69();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 70)
                {
                    DoAnswer70();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 71)
                {
                    DoAnswer71();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 72)
                {
                    DoAnswer72();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 73)
                {
                    DoAnswer73();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 74)
                {
                    DoAnswer74();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 75)
                {
                    DoAnswer75();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 76)
                {
                    DoAnswer76();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 77)
                {
                    DoAnswer77();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 78)
                {
                    DoAnswer78();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 79)
                {
                    DoAnswer79();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 80)
                {
                    DoAnswer80();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 81)
                {
                    DoAnswer81();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 82)
                {
                    DoAnswer82();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 83)
                {
                    DoAnswer83();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 84)
                {
                    DoAnswer84();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 85)
                {
                    DoAnswer85();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 86)
                {
                    DoAnswer86();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 87)
                {
                    DoAnswer87();
                }
                else if (((QuestionViewModel)BindingContext).Answer2 == "Нет"
                    && ((QuestionViewModel)BindingContext).CurrentAnswer == 88)
                {
                    DoAnswer88();
                }
            };
        }

        private void DoAnswer1()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion2();
        }

        private void DoAnswer2()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion3();
        }

        private void DoAnswer3()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion4();
        }

        private void DoAnswer4()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion5();
        }

        private void DoAnswer5()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion6();
        }

        private void DoAnswer6()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion7();
        }

        private void DoAnswer7()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion8();
        }

        private void DoAnswer8()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion9();
        }

        private void DoAnswer9()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion10();
        }

        private void DoAnswer10()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion11();
        }

        private void DoAnswer11()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion12();
        }

        private void DoAnswer12()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion13();
        }

        private void DoAnswer13()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion14();
        }

        private void DoAnswer14()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion15();
        }

        private void DoAnswer15()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion16();
        }

        private void DoAnswer16()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion17();
        }

        private void DoAnswer17()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion18();
        }

        private void DoAnswer18()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion19();
        }

        private void DoAnswer19()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion20();
        }

        private void DoAnswer20()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion21();
        }

        private void DoAnswer21()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion22();
        }

        private void DoAnswer22()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion23();
        }

        private void DoAnswer23()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion24();
        }

        private void DoAnswer24()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion25();
        }

        private void DoAnswer25()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion26();
        }

        private void DoAnswer26()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion27();
        }

        private void DoAnswer27()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion28();
        }

        private void DoAnswer28()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion29();
        }

        private void DoAnswer29()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion30();
        }

        private void DoAnswer30()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion31();
        }

        private void DoAnswer31()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion32();
        }

        private void DoAnswer32()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion33();
        }

        private void DoAnswer33()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion34();
        }

        private void DoAnswer34()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion35();
        }

        private void DoAnswer35()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion36();
        }

        private void DoAnswer36()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion37();
        }

        private void DoAnswer37()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion38();
        }

        private void DoAnswer38()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion39();
        }

        private void DoAnswer39()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion40();
        }

        private void DoAnswer40()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion41();
        }

        private void DoAnswer41()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion42();
        }

        private void DoAnswer42()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion43();
        }

        private void DoAnswer43()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion44();
        }

        private void DoAnswer44()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion45();
        }

        private void DoAnswer45()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion46();
        }

        private void DoAnswer46()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion47();
        }

        private void DoAnswer47()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion48();
        }

        private void DoAnswer48()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion49();
        }

        private void DoAnswer49()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion50();
        }

        private void DoAnswer50()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion51();
        }

        private void DoAnswer51()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion52();
        }

        private void DoAnswer52()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion53();
        }

        private void DoAnswer53()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion54();
        }

        private void DoAnswer54()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion55();
        }

        private void DoAnswer55()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion56();
        }

        private void DoAnswer56()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion57();
        }

        private void DoAnswer57()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion58();
        }

        private void DoAnswer58()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion59();
        }

        private void DoAnswer59()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion60();
        }

        private void DoAnswer60()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion61();
        }

        private void DoAnswer61()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion62();
        }

        private void DoAnswer62()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion63();
        }

        private void DoAnswer63()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion64();
        }

        private void DoAnswer64()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion65();
        }

        private void DoAnswer65()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion66();
        }

        private void DoAnswer66()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion67();
        }

        private void DoAnswer67()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion68();
        }

        private void DoAnswer68()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion69();
        }

        private void DoAnswer69()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion70();
        }

        private void DoAnswer70()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion71();
        }

        private void DoAnswer71()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion72();
        }

        private void DoAnswer72()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion73();
        }

        private void DoAnswer73()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion74();
        }

        private void DoAnswer74()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion75();
        }

        private void DoAnswer75()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion76();
        }

        private void DoAnswer76()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion77();
        }

        private void DoAnswer77()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion78();
        }

        private void DoAnswer78()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion79();
        }

        private void DoAnswer79()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion80();
        }

        private void DoAnswer80()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion81();
        }

        private void DoAnswer81()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion82();
        }

        private void DoAnswer82()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion83();
        }

        private void DoAnswer83()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion84();
        }

        private void DoAnswer84()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion85();
        }

        private void DoAnswer85()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion86();
        }

        private void DoAnswer86()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion87();
        }

        private void DoAnswer87()
        {
            ((QuestionViewModel)BindingContext).ChooseNewQuestion88();
        }

        private void DoAnswer88()
        {
             NavigateToEndPage();
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