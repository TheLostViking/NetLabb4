using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SebastiansDictionary_Library;
namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            WordList.GetList();
            foreach (var item in WordList.GetList())
            {
                listBox1_ShowLists.Items.Add(Path.GetFileNameWithoutExtension(item));
            }
                 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_ShowLists_SelectedIndexChanged(object sender, EventArgs e)
        {
         
        }

        private void listBox2_ShowLanguages_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
                  
}
