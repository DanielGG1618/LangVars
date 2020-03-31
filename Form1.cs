using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LangVars_masterr
{
    public partial class Form1 : Form
    {
        private Dictionary<string, Dictionary<string, string>> dictionaries = new Dictionary<string, Dictionary<string, string>>();

        public Form1()
        {
            Dictionary<string, string> ru_RU = new Dictionary<string, string>();
            Dictionary<string, string> en_UK = new Dictionary<string, string>();
            Dictionary<string, string> uk_UK = new Dictionary<string, string>();

            ru_RU.Add("Новичок", "Новичок");
            ru_RU.Add("Любитель", "Любитель");
            ru_RU.Add("Профи", "Профи");
            ru_RU.Add("Выберите сложность", "Выберите сложность");
            ru_RU.Add("Выберите язык речевой", "Выберите язык");
            ru_RU.Add("Выберите язык орган", "Выберите язык");

            en_UK.Add("Новичок", "Beginner");
            en_UK.Add("Любитель", "Amateur");
            en_UK.Add("Профи", "Pro");
            en_UK.Add("Выберите сложность", "Select the difficulty");
            en_UK.Add("Выберите язык речевой", "Select language");
            en_UK.Add("Выберите язык орган", "Select tongue");

            uk_UK.Add("Новичок", "НовiчокЪ");
            uk_UK.Add("Любитель", "Лiбiель");
            uk_UK.Add("Профи", "TTрофi");
            uk_UK.Add("Выберите сложность", "Вiберiте слозностЬ");
            uk_UK.Add("Выберите язык речевой", "Вiберiте языкЪ");
            uk_UK.Add("Выберите язык орган", "Вiберiте языкЪ");

            dictionaries.Add("ru_RU", ru_RU);
            dictionaries.Add("en_UK", en_UK);
            dictionaries.Add("uk_UK", uk_UK);

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            SetLanguage("en_UK");
        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            SetLanguage("ru_RU");
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            SetLanguage("uk_UK");
        }

        private void SetLanguage(string language)
        {
            label1.Text = dictionaries[language]["Выберите язык речевой"];
            label2.Text = dictionaries[language]["Выберите язык орган"];
            label3.Text = dictionaries[language]["Выберите сложность"];
            button1.Text = dictionaries[language]["Новичок"];
            button2.Text = dictionaries[language]["Любитель"];
            button3.Text = dictionaries[language]["Профи"];
        }
    }
}
