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
    public partial class FormNewGym : Form
    {
        public FormNewGym()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_F.DB();
            SQL_F.con.Open();
            string Adress = textBox1.Text;
            string Number = textBox2.Text;
            if (Adress.Length != 0 && Number.Length != 0)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO Gym (Adress, Phonenumber) " +
                    "VALUES (@Adress, @Phonenumber)", SQL_F.con);
                command.Parameters.AddWithValue("Adress", textBox1.Text);
                command.Parameters.AddWithValue("Phonenumber", textBox2.Text);
                command.ExecuteNonQuery();
                ClearData();
            }
            else MessageBox.Show("Пожалуйста заполните все строки");
            SQL_F.con.Close();
            Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
