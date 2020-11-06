using SebastiansDictionary_Library;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FormAddWord : Form
    {
        public FormAddWord()
        {
            InitializeComponent();
            WordList editList = WordList.LoadList(FormWordList.NameOfList);
            foreach (var item in editList.Languages)
            {
                dataGridView_AddWords.Columns.Add(item, FormWordList.Capitilize(item.ToString()));
            }
            dataGridView_AddWords.Rows.Add();
        }

        //Adds Words to list - DONE.
        private void button_AddWordOK_Click(object sender, EventArgs e)
        {
            List<string> words = new List<string>();
            WordList editList = WordList.LoadList(FormWordList.NameOfList);

            for (int i = 0; i < dataGridView_AddWords.Columns.Count; i++)
            {
                foreach (DataGridViewRow item in dataGridView_AddWords.Rows)
                {
                    words.Add(item.Cells[i].Value?.ToString());
                }
            }
            if (words.Contains(null))
            {
                MessageBox.Show("No word entered!");
            }
            else
            {
                string[] translations = words.ToArray();
                editList.Add(translations);
                editList.Save();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        //Closes the form - No changes made - DONE!
        private void button_AddWordCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}

