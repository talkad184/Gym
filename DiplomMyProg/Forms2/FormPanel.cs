using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomMyProg.Forms2
{
    public partial class FormPanel : Form
    {
        public FormPanel()
        {
            InitializeComponent();
        }

        private void button_NewStuff_Click(object sender, EventArgs e)
        {
            FormNewStuff FormNewStuff = new FormNewStuff();
            FormNewStuff.Top = this.Top;
            FormNewStuff.Left = this.Left;
            FormNewStuff.Show();
            this.Hide();
        }

        private void button_NewGym_Click(object sender, EventArgs e)
        {
            FormNewGym FormNewGym = new FormNewGym();
            FormNewGym.Show();
            this.Hide();
        }

        private void button_DeleteTable_Click(object sender, EventArgs e)
        {
            FormDelete FormDelete = new FormDelete();
            FormDelete.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormServerConnect newForm = new FormServerConnect();
            newForm.Show();
        }
    }
}
