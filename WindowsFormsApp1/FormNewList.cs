using SebastiansDictionary_Library;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormNewList : Form
    {

        public FormNewList()
        {
            InitializeComponent();
        }
        //Method for checking strings for special characters.
        public static bool IsAllLettersOrDigits(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetterOrDigit(c))
                    return false;
            }
            return true;
        }
        //Method for checking strings for only letters.
        public static bool IsAllLetters(string s)
        {
            foreach (char c in s)
            {
                if (!Char.IsLetter(c))
                    return false;
            }
            return true;
        }

        //Closes the form without any changes made - DONE!
        private void button2_CancelNewList_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
 

        //Creates a new list and saves it to a file - DONE!
        private void button1_SaveNewList_Click(object sender, EventArgs e)
        {
            
            string[] seperator = { "\r\n" };
            string[] languages = textBox2_Languages.Text.Split(seperator, StringSplitOptions.RemoveEmptyEntries);

            WordList newList = new WordList(textBox1_ListName.Text, languages);

            if (textBox1_ListName.Text == null || textBox1_ListName.Text == "")
            {
                MessageBox.Show("Please enter a title!");
            }
            else
            {               
                newList.Save();             
                Close();
            }
        }

        //Enables the Save-button when text changes in the textbox - DONE!
        private void textBox2_Languages_TextChanged(object sender, EventArgs e)
        {          
            if (textBox2_Languages.Lines.Length < 2 || textBox2_Languages.Text == "")
            {
                button1_SaveNewList.Enabled = false;
            }
            else
                button1_SaveNewList.Enabled = true;
        }

        private void textBox1_ListName_TextChanged(object sender, EventArgs e)
        {
            if (IsAllLettersOrDigits(textBox1_ListName.Text) == false)
            {
                MessageBox.Show("Title can't have any Special Characters!");
            }            
        }
    }

}
