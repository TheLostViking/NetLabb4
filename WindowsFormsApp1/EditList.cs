using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SebastiansDictionary_Library;

namespace WindowsFormsApp1
{
    public partial class FormEditList : Form
    {
       //The Form initializes and colums and rows added to the datagrid. - DONE!
        public FormEditList()
        {
            InitializeComponent();
           
        }
        private void FormEditList_Load(object sender, EventArgs e)
        {
            AddColumns();
            AddRows();
        }
        //Method to add columns to the grid. - DONE!
        private void AddColumns()
        {
            WordList editList = WordList.LoadList(FormWordList.NameOfList);
            foreach (var item in editList.Languages)
            {
                dataGridView_EditListGrid.Columns.Add(item, FormWordList.Capitilize(item.ToString()));
            }
        }
        //Method to add rows to the grid. - DONE!
        private void AddRows()
        {
            WordList editList = WordList.LoadList(FormWordList.NameOfList);
            editList.List(0, x =>
            {
                dataGridView_EditListGrid.Rows.Add(x);
            });
        }         
        //Method to refresh the grid when a word has been added to the shown list - DONE!
        private void formAddWordClosing(object sender, FormClosingEventArgs e)
        {
            dataGridView_EditListGrid.Columns.Clear();
            AddColumns();
            AddRows();
        }
        //Opens a new form to add words - DONE
        private void button_AddWord_Click(object sender, EventArgs e)
        {
            using (FormAddWord addWord = new FormAddWord()) 
            {
                addWord.FormClosing += new FormClosingEventHandler(formAddWordClosing);
                addWord.ShowDialog();
            }
        }
        //Removes word at selected row and from list. - DONE!
        private void button_RemoveWord_Click(object sender, EventArgs e)
        {
            int row = dataGridView_EditListGrid.CurrentCell.RowIndex;
            WordList editList = WordList.LoadList(FormWordList.NameOfList);
            editList.Remove(row, dataGridView_EditListGrid.CurrentCell.Value.ToString());
            dataGridView_EditListGrid.Rows.RemoveAt(row);
            
            editList.Save();
        }
        //Exits the form without changes. - DONE!
        private void button_ExitEditList_Click(object sender, EventArgs e)
        {
            Close();
        }
        //Opens the practice form - DONE!
        private void button_Practice_Click(object sender, EventArgs e)
        {
            FormPracticeList formPractice = new FormPracticeList();
            formPractice.ShowDialog();
        }
    }

       
}
