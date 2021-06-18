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

namespace DiplomMyProg.Forms
{
    public partial class FormAddNewClient : Form
    {
        public FormAddNewClient()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            textBox4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_F.DB();
            SQL_F.con.Open();
            string Name = textBox1.Text;
            string FirstName = textBox2.Text;
            string Patronymic = textBox3.Text;
            string DofB = dateTimePicker1.Text;
            string PhoneNumb = textBox4.Text;
            if (Name.Length != 0 && FirstName.Length != 0 && PhoneNumb.Length != 0)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO Clients (Surname, Name, Patronymic, DofB, PhoneNumber) " +
                    "VALUES (N'" + Name + "', N'" + FirstName + "', N'" + Patronymic + "', N'" + DofB + "', N'" + PhoneNumb + "')", SQL_F.con);
                command.ExecuteNonQuery().ToString();
                ClearData();
            }
            else MessageBox.Show("Пожалуйста заполните все строки");
            SQL_F.con.Close();
            Hide();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }
    }
}
