using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiplomMyProg.Forms
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox_login.Text == "admin" && textBox_password.Text == "pass")
            {
                Form2 Form2 = new Form2();
                Form2.Show();
                this.Hide();

            }
            //else if (textBox_password.Text != "admin" && textBox_password.Text != "pass")
            //{
            //    MessageBox.Show("Неверный логин или пароль.");
            //}
        }
    }
}
