using SebastiansDictionary_Library;
using System;
using System.IO;
using System.Windows.Forms;
namespace WindowsFormsApp1
{
    public partial class FormWordList : Form
    {
        private static string AppLocalPath() //Gets the path for LocalApp-directory, creates the directory if it doesn't exists. - DONE!
        {
            string appLocalPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            string appPath = Path.Combine(appLocalPath, "SebastiansDictionary");
            if (!Directory.Exists(appPath))
            {
                Directory.CreateDirectory(appPath);
            }
            return appPath;
        }
        
        //Method to capitilize first letter of strings. 
        public static string Capitilize(string text)
        {
            return text.Substring(0, 1).ToUpper() + text.Substring(1);
        }
        //String for listname.
        private static string _nameOfList;
        //Property for listname, to use in other forms.
        public static string NameOfList
        { 
            get 
            { 
                return _nameOfList;
            }
            set
            {
                _nameOfList = value;
            } 
        }
        public FormWordList()
        {
            InitializeComponent();
            AppLocalPath();
        }
        
        //Adds the lists from filepath to the listbox - DONE!
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
            if (listBox1_ShowLists.SelectedItem != null)
            {
                WordList wordList = WordList.LoadList(listBox1_ShowLists.SelectedItem.ToString());
                foreach (var item in wordList.Languages)
                {
                    listBox2_ShowLanguages.Items.Add(Capitilize(item));
                }
                //Displays number of words in the selected list.
                label_NumberOfWords.Text = Convert.ToString(wordList.Count());
            }
            else
                MessageBox.Show("Please select a list!");
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
        //Same as below, no messagebox - DONE!
        private void listBox1_ShowLists_DoubleClick(object sender, EventArgs e)
        {
            _nameOfList = listBox1_ShowLists.SelectedItem.ToString();
            FormEditList editList = new FormEditList();
            editList.ShowDialog();
        }

        //Opens the Edit List window. If no list is selected, shows message - DONE!
        private void button_EditListOpen_Click(object sender, EventArgs e)
        {
            using (FormEditList editList = new FormEditList())
            {
                editList.FormClosing += new FormClosingEventHandler(editListClosing);
                if (listBox1_ShowLists.SelectedItem != null)
                {
                    _nameOfList = listBox1_ShowLists.SelectedItem.ToString();

                    editList.ShowDialog();
                }
                else
                    MessageBox.Show("Please select a list!");
            }
        }
        //FormClosingEvent for Edit List - DONE!
        private void editListClosing(object sender, FormClosingEventArgs e)
        {
            listBox1_ShowLists.Items.Clear();
            foreach (var item in WordList.GetList())
            {
                listBox1_ShowLists.Items.Add(Path.GetFileNameWithoutExtension(item));
            }
        }
    }
}





