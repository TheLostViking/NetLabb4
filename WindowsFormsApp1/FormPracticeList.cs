using SebastiansDictionary_Library;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormPracticeList : Form
    {

        private static string _wordToPractice;
        private static int _counter = 0;
        private static int _numberofTries = 0;
        public FormPracticeList()
        {
            InitializeComponent();

        }

        private void FormPracticeList_Load(object sender, EventArgs e)
        {
            GetPracticeWord();
        }

        private void GetPracticeWord()
        {
            WordList practiceList = WordList.LoadList(FormWordList.NameOfList);
            Word wordtoPractice = practiceList.GetWordToPractice();

            string fromLanguage = practiceList.Languages[wordtoPractice.FromLanguage];
            _wordToPractice = wordtoPractice.Translations[wordtoPractice.FromLanguage];
            string toLanguage = practiceList.Languages[wordtoPractice.ToLanguage];
            string wordID = wordtoPractice.Translations[wordtoPractice.ToLanguage];
            
            label_FromLanguage.Text = FormWordList.Capitilize(fromLanguage);
            label_WordID.Text = $"'{wordID}'";
            label_ToLanguage.Text = FormWordList.Capitilize(toLanguage);
        }

       
        private void button_ResetPractice_Click(object sender, EventArgs e)
        {
            _counter = 0;
            _numberofTries = 0;
            label_CorrectOrNot.Text = "";
            label_Counter.Text = 0.ToString();
            label_NumberOfTries.Text = 0.ToString();
            GetPracticeWord();
        }

        private void textBox_AnswerFromUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (textBox_AnswerFromUser.Text.ToLower() == _wordToPractice.ToLower())
                {
                    label_CorrectOrNot.Text = $"Correct!";
                    _counter++;
                }
                else
                {
                    label_CorrectOrNot.Text = $"Incorrect!";
                }
                _numberofTries++;
                textBox_AnswerFromUser.Clear();
                GetPracticeWord();
            }
            label_Counter.Text = _counter.ToString();
            label_NumberOfTries.Text = _numberofTries.ToString();
        }

        private void button_ExitPractice_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

