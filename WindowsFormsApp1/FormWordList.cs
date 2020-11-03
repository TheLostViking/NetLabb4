using SebastiansDictionary_Library;
using System;
using System.IO;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class FormWordList : Form
    {
        private string filePath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\SebastiansDictionary" + "\\";

        private static string Capitilize(string text)
        {
            return text.Substring(0, 1).ToUpper() + text.Substring(1);
        }
        public FormWordList()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string empty = "No Lists to display...";

            foreach (var item in WordList.GetList())
            {
                listBox1_ShowLists.Items.Add(Path.GetFileNameWithoutExtension(item));
            }

            if (listBox1_ShowLists.Items.Count == 0)
            {
                listBox1_ShowLists.Items.Add(empty);
            }

        }

        //Shows the languages of the selected list - DONE!
        private void listBox1_ShowLists_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox2_ShowLanguages.Items.Clear();
            string[] languages;
            WordList wordList = WordList.LoadList(listBox1_ShowLists.SelectedItem.ToString());
            using (StreamReader sr = new StreamReader(filePath + listBox1_ShowLists.SelectedItem.ToString() + ".dat"))
            {
                languages = sr.ReadLine().TrimEnd(';').Split(';');
            }
            //Adds each language to the second listbox.
            foreach (var item in languages)
            {
                listBox2_ShowLanguages.Items.Add(Capitilize(item));
            }

            //Displays number of words in the selected list.
            label_NumberOfWords.Text = Convert.ToString(wordList.Count());

        }

        private void listBox2_ShowLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //Opens a new Form to add a new list - DONE!
        private void button1_NewList_Click(object sender, EventArgs e)
        {
            using (FormNewList newListForm = new FormNewList())
            {
                newListForm.FormClosing += new FormClosingEventHandler(newListFormClosing);
                newListForm.ShowDialog();
            }
        }

        //Refreshes List View when NewListForm closes - DONE!
        private void newListFormClosing(object sender, FormClosingEventArgs e)
        {
            listBox1_ShowLists.Items.Clear();
            foreach (var item in WordList.GetList())
            {
                listBox1_ShowLists.Items.Add(Path.GetFileNameWithoutExtension(item));
            }
        }

        private void listBox1_ShowLists_DoubleClick(object sender, EventArgs e)
        {
            using (FormEditList editList = new FormEditList())
            {
                editList.ShowDialog();
            }
        }

        private void button_EditListOpen_Click(object sender, EventArgs e)
        {
            using (FormEditList editList = new FormEditList())
            {
                editList.ShowDialog();
            }
        }
    }
}





