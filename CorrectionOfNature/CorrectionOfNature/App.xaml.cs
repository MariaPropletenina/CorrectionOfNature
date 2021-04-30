using CorrectionOfNature.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;
using CorrectionOfNature.Tables;
using System.IO;
//using Microsoft.WindowsAzure.MobileServices;

namespace CorrectionOfNature
{
    public class AppSettings
    {
        public const int QUESTIONS_COUNT = 88;
        public static int CurrentQuestion = 1;
        public static int Score = 0;
        public static string Username = "";
    }

    public partial class App : Application
    {
        //string user;
        public App()
        {
            InitializeComponent();
            /*var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "CorrectionNatureDB.db");
            var db = new SQLiteConnection(dbpath);
            db.CreateTable<XamarinQuiz>();
            db.CreateTable<UserScore>();

            XamarinQuiz item1 = new XamarinQuiz()
            {
                Question = "Является ли ваше настроение в общем весёлым и беззаботным?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 1
            };

            XamarinQuiz item2 = new XamarinQuiz()
            {
                Question = "Восприимчивы ли вы к обидам?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 2
            };

            XamarinQuiz item3 = new XamarinQuiz()
            {
                Question = "Случалось ли вам иногда быстро заплакать?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 3
            };

            XamarinQuiz item4 = new XamarinQuiz()
            {
                Question = "Всегда ли вы считаете себя правым в том деле, которое делаете, и вы не успокаиваетесь, пока не убедитесь в этом?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 4
            };

            XamarinQuiz item5 = new XamarinQuiz()
            {
                Question = "Считаете ли вы себя более смелым, чем в детском возрасте?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 5
            };

            XamarinQuiz item6 = new XamarinQuiz()
            {
                Question = "Может ли ваше настроение меняться от глубокой радости до глубокой печали?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 6
            };

            XamarinQuiz item7 = new XamarinQuiz()
            {
                Question = "Находитесь ли вы в компании в центре внимания?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 7
            };

            XamarinQuiz item8 = new XamarinQuiz()
            {
                Question = "Бывают ли у вас дни, когда вы без достаточных оснований находитесь в угрюмом и раздражительном настроении и ни с кем не хотите разговаривать?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 8
            };

            XamarinQuiz item9 = new XamarinQuiz()
            {
                Question = "Серьёзный ли вы человек?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 9
            };

            XamarinQuiz item10 = new XamarinQuiz()
            {
                Question = "Можете ли вы сильно воодушевиться?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 10
            };

            XamarinQuiz item11 = new XamarinQuiz()
            {
                Question = "Предприимчивы ли вы?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 11
            };

            XamarinQuiz item12 = new XamarinQuiz()
            {
                Question = "Быстро ли вы забываете, если вас кто-нибудь обидит?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 12
            };

            XamarinQuiz item13 = new XamarinQuiz()
            {
                Question = "Мягкосердечный ли вы человек?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 13
            };

            XamarinQuiz item14 = new XamarinQuiz()
            {
                Question = "Пытаетесь ли вы проверить после того, как опустили письмо в почтовый ящик, не осталось ли оно висеть в прорези?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 14
            };

            XamarinQuiz item15 = new XamarinQuiz()
            {
                Question = "Всегда ли вы стараетесь быть добросовестным в работе?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 15
            };

            XamarinQuiz item16 = new XamarinQuiz()
            {
                Question = "Испытывали ли вы в детстве страх перед грозой или собаками?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 16
            };

            XamarinQuiz item17 = new XamarinQuiz()
            {
                Question = "Считаете ли вы других людей недостаточно требовательными друг к другу?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 17
            };

            XamarinQuiz item18 = new XamarinQuiz()
            {
                Question = "Сильно ли зависит ваше настроение от жизненных событий и переживаний?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 18
            };

            XamarinQuiz item19 = new XamarinQuiz()
            {
                Question = "Всегда ли вы прямодушны со своими знакомыми?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 19
            };

            XamarinQuiz item20 = new XamarinQuiz()
            {
                Question = "Часто ли ваше настроение бывает подавленным?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 20
            };

            XamarinQuiz item21 = new XamarinQuiz()
            {
                Question = "Был ли у вас раньше истерический припадок или истощение нервной системы?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 21
            };

            XamarinQuiz item22 = new XamarinQuiz()
            {
                Question = "Склонны ли вы к состояниям сильного внутреннего беспокойства или страстного стремления?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 22
            };

            XamarinQuiz item23 = new XamarinQuiz()
            {
                Question = "Трудно ли вам длительное время просидеть на стуле?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 23
            };

            XamarinQuiz item24 = new XamarinQuiz()
            {
                Question = "Боретесь ли вы за свои интересы, если кто-то поступает с вами несправедливо?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 24
            };

            XamarinQuiz item25 = new XamarinQuiz()
            {
                Question = "Смогли бы вы убить человека?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 25
            };

            XamarinQuiz item26 = new XamarinQuiz()
            {
                Question = "Сильно ли вам мешает косо висящая гардина или неровно настланная скатерть, настолько, что вам хочется немедленно устранить эти недостатки?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 26
            };

            XamarinQuiz item27 = new XamarinQuiz()
            {
                Question = "Испытывали ли вы в детстве страх, когда оставались одни в квартире?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 27
            };

            XamarinQuiz item28 = new XamarinQuiz()
            {
                Question = "Часто ли у вас без причины меняется настроение?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 28
            };

            XamarinQuiz item29 = new XamarinQuiz()
            {
                Question = "Всегда ли вы старательно относитесь к своей деятельности?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 29
            };

            XamarinQuiz item30 = new XamarinQuiz()
            {
                Question = "Быстро ли вы можете разгневаться?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 30
            };

            XamarinQuiz item31 = new XamarinQuiz()
            {
                Question = "Можете ли вы быть бесшабашно веселым?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 31
            };

            XamarinQuiz item32 = new XamarinQuiz()
            {
                Question = "Можете ли вы иногда целиком проникнуться чувством радости?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 32
            };

            XamarinQuiz item33 = new XamarinQuiz()
            {
                Question = "Подходите ли вы для проведения увеселительных мероприятий?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 33
            };

            XamarinQuiz item34 = new XamarinQuiz()
            {
                Question = "Высказываете ли вы обычно людям свое откровенное мнение по тому или иному вопросу?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 34
            };

            XamarinQuiz item35 = new XamarinQuiz()
            {
                Question = "Влияет ли на вас вид крови?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 35
            };

            XamarinQuiz item36 = new XamarinQuiz()
            {
                Question = "Охотно ли вы занимаетесь деятельностью, связанной с большой ответственностью?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 36
            };

            XamarinQuiz item37 = new XamarinQuiz()
            {
                Question = "Склонны ли вы вступиться за человека, с которым поступили несправедливо?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 37
            };

            XamarinQuiz item38 = new XamarinQuiz()
            {
                Question = "Трудно ли вам входить в темный подвал?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 38
            };

            XamarinQuiz item39 = new XamarinQuiz()
            {
                Question = "Выполняете ли вы кропотливую черную работу так же медленно и тщательно, как и любимое вами дело?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 39
            };

            XamarinQuiz item40 = new XamarinQuiz()
            {
                Question = "Являетесь ли вы общительным человеком?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 40
            };

            XamarinQuiz item41 = new XamarinQuiz()
            {
                Question = "Охотно ли вы декламировали в школе стихи?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 41
            };

            XamarinQuiz item42 = new XamarinQuiz()
            {
                Question = "Убегали ли вы ребенком из дома?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 42
            };

            XamarinQuiz item43 = new XamarinQuiz()
            {
                Question = "Тяжело ли вы воспринимаете жизнь?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 43
            };

            XamarinQuiz item44 = new XamarinQuiz()
            {
                Question = "Бывали ли у вас конфликты и неприятности, которые так изматывали вам нервы, что вы не выходили на работу?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 44
            };

            XamarinQuiz item45 = new XamarinQuiz()
            {
                Question = "Можно ли сказать, что вы при неудачах не теряете чувство юмора?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 45
            };

            XamarinQuiz item46 = new XamarinQuiz()
            {
                Question = "Сделаете ли вы первым шаг к примирению, если вас кто-то оскорбит?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 46
            };

            XamarinQuiz item47 = new XamarinQuiz()
            {
                Question = "Любите ли вы животных?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 47
            };

            XamarinQuiz item48 = new XamarinQuiz()
            {
                Question = "Уйдете ли вы с работы или из дому, если у вас там что-то не в порядке?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 48
            };

            XamarinQuiz item49 = new XamarinQuiz()
            {
                Question = "Мучают ли вас неопределенные мысли, что с вами или с вашими родственниками случится какое - нибудь несчастье?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 49
            };

            XamarinQuiz item50 = new XamarinQuiz()
            {
                Question = "Считаете ли вы, что настроение зависит от погоды?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 50
            };

            XamarinQuiz item51 = new XamarinQuiz()
            {
                Question = "Затруднит ли вас выступить на сцене перед большим количеством зрителей?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 51
            };

            XamarinQuiz item52 = new XamarinQuiz()
            {
                Question = "Можете ли вы выйти из себя и дать волю рукам, если вас кто-то умышленно грубо рассердит?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 52
            };

            XamarinQuiz item53 = new XamarinQuiz()
            {
                Question = "Много ли вы общаетесь?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 53
            };

            XamarinQuiz item54 = new XamarinQuiz()
            {
                Question = "Если вы будете чем-либо разочарованы, придете ли в отчаяние?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 54
            };

            XamarinQuiz item55 = new XamarinQuiz()
            {
                Question = "Нравится ли вам работа организаторского характера?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 55
            };

            XamarinQuiz item56 = new XamarinQuiz()
            {
                Question = "Упорно ли вы стремитесь к своей цели, даже если на пути встречается много препятствий?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 56
            };

            XamarinQuiz item57 = new XamarinQuiz()
            {
                Question = "Может ли вас так захватить кинофильм, что слезы выступят на глазах?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 57
            };

            XamarinQuiz item58 = new XamarinQuiz()
            {
                Question = "Трудно ли вам будет заснуть, если вы целый день размышляли над своим будущим или какой - нибудь проблемой?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 58
            };

            XamarinQuiz item59 = new XamarinQuiz()
            {
                Question = "Приходилось ли вам в школьные годы пользоваться подсказками или списывать у товарищей домашнее задание?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 59
            };

            XamarinQuiz item60 = new XamarinQuiz()
            {
                Question = "Трудно ли вам пойти ночью на кладбище?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 60
            };

            XamarinQuiz item61 = new XamarinQuiz()
            {
                Question = "Следите ли вы с большим вниманием, чтобы каждая вещь в доме лежала на своем месте?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 61
            };

            XamarinQuiz item62 = new XamarinQuiz()
            {
                Question = "Приходилось ли вам лечь спать в хорошем настроении, а проснуться в удрученном и несколько часов оставаться в нем?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 62
            };

            XamarinQuiz item63 = new XamarinQuiz()
            {
                Question = "Можете ли вы с легкостью приспособиться к новой ситуации?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 63
            };

            XamarinQuiz item64 = new XamarinQuiz()
            {
                Question = "Есть ли у вас предрасположенность к головной боли?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 64
            };

            XamarinQuiz item65 = new XamarinQuiz()
            {
                Question = "Часто ли вы смеетесь?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 65
            };

            XamarinQuiz item66 = new XamarinQuiz()
            {
                Question = "Можете ли вы быть приветливым с людьми, не открывая своего истинного отношения к ним?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 66
            };

            XamarinQuiz item67 = new XamarinQuiz()
            {
                Question = "Можно ли вас назвать оживленным и бойким человеком?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 67
            };

            XamarinQuiz item68 = new XamarinQuiz()
            {
                Question = "Сильно ли вы страдаете из-за несправедливости?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 68
            };

            XamarinQuiz item69 = new XamarinQuiz()
            {
                Question = "Можно ли вас назвать страстным любителем природы?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 69
            };

            XamarinQuiz item70 = new XamarinQuiz()
            {
                Question = "Есть ли у вас привычка проверять перед сном или перед тем, как уйти, выключен ли газ и свет, закрыта ли дверь?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 70
            };

            XamarinQuiz item71 = new XamarinQuiz()
            {
                Question = "Пугливы ли вы?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 71
            };

            XamarinQuiz item72 = new XamarinQuiz()
            {
                Question = "Бывает ли, что вы чувствуете себя на седьмом небе, хотя объективных причин для этого нет?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 72
            };

            XamarinQuiz item73 = new XamarinQuiz()
            {
                Question = "Охотно ли вы участвовали в юности в кружках художественной самодеятельности, в театральном кружке?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 73
            };

            XamarinQuiz item74 = new XamarinQuiz()
            {
                Question = "Тянет ли вас иногда смотреть вдаль?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 74
            };

            XamarinQuiz item75 = new XamarinQuiz()
            {
                Question = "Смотрите ли вы на будущее пессимистически?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 75
            };

            XamarinQuiz item76 = new XamarinQuiz()
            {
                Question = "Может ли ваше настроение измениться от высочайшей радости до глубокой тоски за короткий период времени?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 76
            };

            XamarinQuiz item77 = new XamarinQuiz()
            {
                Question = "Легко ли поднимается ваше настроение в дружеской компании?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 77
            };

            XamarinQuiz item78 = new XamarinQuiz()
            {
                Question = "Переносите ли вы злость длительное время?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 78
            };

            XamarinQuiz item79 = new XamarinQuiz()
            {
                Question = "Сильно ли вы переживаете, если горе случилось у другого человека?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 79
            };

            XamarinQuiz item80 = new XamarinQuiz()
            {
                Question = "Была ли у вас в школе привычка переписывать лист в тетради, если вы поставили на него кляксу?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 80
            };

            XamarinQuiz item81 = new XamarinQuiz()
            {
                Question = "Можно ли сказать, что вы больше недоверчивы и осторожны, нежели доверчивы?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 81
            };

            XamarinQuiz item82 = new XamarinQuiz()
            {
                Question = "Часто ли вы видите страшные сны?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 82
            };

            XamarinQuiz item83 = new XamarinQuiz()
            {
                Question = "Возникала ли у вас мысль против воли броситься из окна, под приближающийся поезд?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 83
            };

            XamarinQuiz item84 = new XamarinQuiz()
            {
                Question = "Становитесь ли вы радостным в веселом окружении?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 84
            };

            XamarinQuiz item85 = new XamarinQuiz()
            {
                Question = "Легко ли вы можете отвлечься от обременительных вопросов и не думать о них?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 85
            };

            XamarinQuiz item86 = new XamarinQuiz()
            {
                Question = "Трудно ли вам сдержать себя, если вы разозлитесь?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 86
            };

            XamarinQuiz item87 = new XamarinQuiz()
            {
                Question = "Предпочитаете ли вы молчать (да), или вы словоохотливы (нет)?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 87
            };

            XamarinQuiz item88 = new XamarinQuiz()
            {
                Question = "Могли бы вы, если пришлось бы участвовать в театральном представлении, с полным проникновением и перевоплощением войти в роль и забыть о себе?",
                Answer1 = "Да",
                Answer2 = "Нет",
                CurrentAnswer = 88
            };

            db.Insert(item1);
            db.Insert(item2);
            db.Insert(item3);
            db.Insert(item4);
            db.Insert(item5);
            db.Insert(item6);
            db.Insert(item7);
            db.Insert(item8);
            db.Insert(item9);
            db.Insert(item10);
            db.Insert(item11);

            db.Insert(item12);
            db.Insert(item13);
            db.Insert(item14);
            db.Insert(item15);
            db.Insert(item16);
            db.Insert(item17);
            db.Insert(item18);
            db.Insert(item19);
            db.Insert(item20);
            db.Insert(item21);
            db.Insert(item22);

            db.Insert(item23);
            db.Insert(item24);
            db.Insert(item25);
            db.Insert(item26);
            db.Insert(item27);
            db.Insert(item28);
            db.Insert(item29);
            db.Insert(item30);
            db.Insert(item31);
            db.Insert(item32);
            db.Insert(item33);

            db.Insert(item34);
            db.Insert(item35);
            db.Insert(item36);
            db.Insert(item37);
            db.Insert(item38);
            db.Insert(item39);
            db.Insert(item40);
            db.Insert(item41);
            db.Insert(item42);
            db.Insert(item43);
            db.Insert(item44);

            db.Insert(item45);
            db.Insert(item46);
            db.Insert(item47);
            db.Insert(item48);
            db.Insert(item49);
            db.Insert(item50);
            db.Insert(item51);
            db.Insert(item52);
            db.Insert(item53);
            db.Insert(item54);
            db.Insert(item55);

            db.Insert(item56);
            db.Insert(item57);
            db.Insert(item58);
            db.Insert(item59);
            db.Insert(item60);
            db.Insert(item61);
            db.Insert(item62);
            db.Insert(item63);
            db.Insert(item64);
            db.Insert(item65);
            db.Insert(item66);

            db.Insert(item67);
            db.Insert(item68);
            db.Insert(item69);
            db.Insert(item70);
            db.Insert(item71);
            db.Insert(item72);
            db.Insert(item73);
            db.Insert(item74);
            db.Insert(item75);
            db.Insert(item76);
            db.Insert(item77);

            db.Insert(item78);
            db.Insert(item79);
            db.Insert(item80);
            db.Insert(item81);
            db.Insert(item82);
            db.Insert(item83);
            db.Insert(item84);
            db.Insert(item85);
            db.Insert(item86);
            db.Insert(item87);
            db.Insert(item88);*/

            MainPage = new NavigationPage(new AuthPage());
            //MainPage = new NavigationPage(new ChatMenu(user));
            //MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
