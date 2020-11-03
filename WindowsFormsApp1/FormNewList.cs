using SebastiansDictionary_Library;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormNewList : Form
    {
        
        public FormNewList()
        {
            InitializeComponent();
        }
      

        private void button2_CancelNewList_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void button1_SaveNewList_Click(object sender, EventArgs e)
        {
            string[] seperator = { "\r\n" };
            string[] languages = textBox2_Languages.Text.Split(seperator, StringSplitOptions.RemoveEmptyEntries);
            WordList newList = new WordList(textBox1_ListName.Text, languages);
            newList.Save();
            DialogResult = DialogResult.OK;
            Close();
        }

    }
        
}
