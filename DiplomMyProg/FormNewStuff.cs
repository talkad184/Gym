using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using DiplomMyProg;
using System.Runtime.InteropServices;

namespace DiplomMyProg
{
    public partial class FormNewStuff : Form
    {
        public FormNewStuff()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_F.DB();
            SQL_F.con.Open();
            string Name = textBox1.Text;
            string Surname = textBox2.Text;
            string Patronymic = textBox3.Text;
            string PostJob = textBox4.Text;
            string PhoneNumber = textBox5.Text;
            string Salary = textBox6.Text;

            if (Name.Length != 0 && Surname.Length != 0 && PhoneNumber.Length != 0 && PostJob.Length != 0 && Salary.Length != 0)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO Stuff (Name, Surname, Patronymic, PostJob, PhoneNumber, Salary) " +
                    "VALUES (@Name, @Surname, @Patronymic, @PostJob, @PhoneNumber, @Salary)", SQL_F.con);
                command.Parameters.AddWithValue("Name", textBox1.Text);
                command.Parameters.AddWithValue("Surname", textBox2.Text);
                command.Parameters.AddWithValue("Patronymic", textBox3.Text);
                command.Parameters.AddWithValue("PostJob", textBox4.Text);
                command.Parameters.AddWithValue("PhoneNumber", textBox5.Text);
                command.Parameters.AddWithValue("Salary", textBox6.Text);
                command.ExecuteNonQuery();
                ClearData();
            }
            else MessageBox.Show("Пожалуйста заполните все строки");
            SQL_F.con.Close();
            Close();
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
