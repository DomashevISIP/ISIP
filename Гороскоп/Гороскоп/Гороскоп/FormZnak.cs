using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Гороскоп
{
    public partial class FormZnak : Form
    {
        public FormZnak()
        {
            InitializeComponent();
        }

        private void FormZnak_Load(object sender, EventArgs e)
        {
            if (DataBase.ZnakZodiaka=="Овен")
            {
                lblZnak.Text = "Овен";
                pctBxZnak.Image= Properties.Resources.овен;
                lblOpisanie.Text = "Открывает плеяду знаков по гороскопу Овен. Звезды утверждают, что это трудолюбивые и радостные люди. " +
                    "Они очень активные и самостоятельные, поэтому рано начинают жить отдельно от родителей.";
            }
            if (DataBase.ZnakZodiaka == "Телец")
            {
                lblZnak.Text = "Телец";
                pctBxZnak.Image = Properties.Resources.телец;
                lblOpisanie.Text = "Тельцы чрезвычайно упрямы. Если они вбили себе что-то в голову, то сдвинуть их с намеченного пути практически невозможно." +
                    " Вместе с тем Тельцы очень верные люди. Любят домашний уют и тепло.";
            }
            if (DataBase.ZnakZodiaka == "Близнецы")
            {
                lblZnak.Text = "Близнецы";
                pctBxZnak.Image = Properties.Resources.близнецы;
                lblOpisanie.Text = "Близнецы — это человек-праздник. Там, где он, всегда шумно и весело." +
                    " Близнецы постоянно находятся в поиске новых ощущений, так как не терпят скуки." +
                    " Из-за их двойственности порой страдают близкие люди.";
            }
            if (DataBase.ZnakZodiaka == "Рак")
            {
                lblZnak.Text = "Рак";
                pctBxZnak.Image = Properties.Resources.рак;
                lblOpisanie.Text = "Характеристика человека, который родился под знаком Рака, слегка меланхолична. Представители гороскопа часто не уверены в себе и чересчур ранимы." +
                    " Они любят проводить время дома, в кругу семьи.";
            }
            if (DataBase.ZnakZodiaka == "Лев")
            {
                lblZnak.Text = "Лев";
                pctBxZnak.Image = Properties.Resources.лев;
                lblOpisanie.Text = "Львы активные и любознательные." +
                    " Представители гороскопа обожают быть в центре внимания и падки на лесть." +
                    " Они авторитетны, тщеславны и немного эгоистичны.";
            }
            if (DataBase.ZnakZodiaka == "Дева")
            {
                lblZnak.Text = "Дева";
                pctBxZnak.Image = Properties.Resources.дева;
                lblOpisanie.Text = "юди, родившиеся под знаком, любят и умеют работать, не терпят расточительности и беспорядка." +
                    " Иногда создается впечатление, что Дева чересчур педантична." +
                    " Трудно сходится с людьми из-за поучительности.";
            }
            if (DataBase.ZnakZodiaka == "Весы")
            {
                lblZnak.Text = "Весы";
                pctBxZnak.Image = Properties.Resources.весы;
                lblOpisanie.Text = "Весы очень добрый знак зодиака. Они чувственные, эмоциональные и порой слишком импульсивные." +
                    " Весы не любят конфликты и стараются избегать любого накала ситуации.";
            }
            if (DataBase.ZnakZodiaka == "Скорпион")
            {
                lblZnak.Text = "Скорпион";
                pctBxZnak.Image = Properties.Resources.скорпион;
                lblOpisanie.Text = "Скорпион очень страстный и импульсивный знак зодиака." +
                    " Часто у представителей гороскопа эмоции берут вверх над разумом." +
                    " Но Скорпионы могут быть очень строгими. Они всегда стремятся к лидерству.";
            }
            if (DataBase.ZnakZodiaka == "Стрелец")
            {
                lblZnak.Text = "Стрелец";
                pctBxZnak.Image = Properties.Resources.стрелец;
                lblOpisanie.Text = "Стрельцы уверены в себе и эгоистичны. Они не терпят, когда ограничивают их свободу, и редко отличаются верностью." +
                    " Любят быть в центре внимания, обладают хорошим чувством юмора.";
            }
            if (DataBase.ZnakZodiaka == "Козерог")
            {
                lblZnak.Text = "Козерог";
                pctBxZnak.Image = Properties.Resources.козерог;
                lblOpisanie.Text = "Козероги медлительные и задумчивые." +
                    " Они склонны к самоанализу и самоконтролю." +
                    " Редко проявляют эмоции, предпочитая держать все в себе.";
            }
            if (DataBase.ZnakZodiaka == "Водолей")
            {
                lblZnak.Text = "Водолей";
                pctBxZnak.Image = Properties.Resources.водолей;
                lblOpisanie.Text = "Знак зодиака Водолей всегда открыт для других людей." +
                    " Он дружелюбный и общительный, иногда обладает слишком мягким характером.";
            }
            if (DataBase.ZnakZodiaka == "Рыбы")
            {
                lblZnak.Text = "Рыбы";
                pctBxZnak.Image = Properties.Resources.рыбы;
                lblOpisanie.Text = "Рыбы очень нежные и мечтательные. Их легко обидеть и ранить, при этом они надолго это запоминают и страдают." +
                    " Психика Рыб пластична, поэтому их чувствительность не влияет негативно на жизнь Рыб.";
            }
            Random rnd = new Random();
            int value = rnd.Next(1, 10);
            switch(value)
            {
                case 1:
                    lblPredskazanieSeg.Text = DataBase.Predskazanie1Segodnia;
                    break;
                case 2:
                    lblPredskazanieSeg.Text = DataBase.Predskazanie2Segodnia;
                    break;
                case 3:
                    lblPredskazanieSeg.Text = DataBase.Predskazanie3Segodnia;
                    break;
                case 4:
                    lblPredskazanieSeg.Text = DataBase.Predskazanie4Segodnia;
                    break;
                case 5:
                    lblPredskazanieSeg.Text = DataBase.Predskazanie5Segodnia;
                    break;
                case 6:
                    lblPredskazanieSeg.Text = DataBase.Predskazanie6Segodnia;
                    break;
                case 7:
                    lblPredskazanieSeg.Text = DataBase.Predskazanie7Segodnia;
                    break;
                case 8:
                    lblPredskazanieSeg.Text = DataBase.Predskazanie8Segodnia;
                    break;
                case 9:
                    lblPredskazanieSeg.Text = DataBase.Predskazanie9Segodnia;
                    break;
                case 10:
                    lblPredskazanieSeg.Text = DataBase.Predskazanie10Segodnia;
                    break;
            }
            Random rnd1 = new Random();
            int value1 = rnd.Next(1, 7);
            switch (value1)
            {
                case 1:
                    lblYear.Text = DataBase.Predskazanie1Year;
                    break;
                case 2:
                    lblYear.Text = DataBase.Predskazanie2Year;
                    break;
                case 3:
                    lblYear.Text = DataBase.Predskazanie3Year;
                    break;
                case 4:
                    lblYear.Text = DataBase.Predskazanie4Year;
                    break;
                case 5:
                    lblYear.Text = DataBase.Predskazanie5Year;
                    break;
                case 6:
                    lblYear.Text = DataBase.Predskazanie6Year;
                    break;
                case 7:
                    lblYear.Text = DataBase.Predskazanie7Year;
                    break;
            }
        }

        private void lblPredskazanieSegodna_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
               "Вы действительно хотите выйти?",
               "?",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button2,
               MessageBoxOptions.DefaultDesktopOnly);

            if (result == DialogResult.Yes) Application.Exit();
        }
    }
}
