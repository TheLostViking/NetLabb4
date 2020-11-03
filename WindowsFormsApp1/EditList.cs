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
        private DataGridView editListDataGridView = new DataGridView();
        public FormEditList()
        {
            InitializeComponent();
        }

        private void FormEditList_Load(object sender, EventArgs e)
        {
            editListDataGridView.Columns.AddRange();
        }
    }
}
