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

namespace DiplomMyProg.Forms2
{
    public partial class FormUpdateClient : Form
    {
        public FormUpdateClient()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            string Surname = textBox1.Text;
            string Name = textBox2.Text;
            string Patronymic = textBox3.Text;
            string DofB = dateTimePicker1.Text;
            string Phonenumber = textBox4.Text;
            if (Surname.Length != 0 && Name.Length != 0 && DofB.Length != 0 && Phonenumber.Length != 0)
            {
                MySqlCommand command = new MySqlCommand("UPDATE " +
                    "clients SET Surname = @Surname, " +
                    "Name = @Name," +
                    "Patronymic = @Patronymic, " +
                    "DofB = @DofB, " +
                    "Phonenumber = @Phonenumber " +
                    "WHERE idClients = " + SQL_F.TextId, SQL_F.con);
                command.Parameters.AddWithValue("Surname", textBox1.Text);
                command.Parameters.AddWithValue("Name", textBox2.Text);
                command.Parameters.AddWithValue("Patronymic", textBox3.Text);
                command.Parameters.AddWithValue("DofB", dateTimePicker1.Text);
                command.Parameters.AddWithValue("Phonenumber", textBox4.Text);
                command.ExecuteNonQuery();

                // очищение полей
                ClearData();
            }
            else MessageBox.Show("Пожалуйста заполните все строки");
            SQL_F.con.Close();

            this.Close();
        }

        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            dateTimePicker1.Text = "";
            textBox4.Text = "";
        }

        private void TextFillBox()
        {
            textBox1.Text = SQL_F.GetSelectData("Surname", "clients", SQL_F.TextId);
            textBox2.Text = SQL_F.GetSelectData("Name", "clients", SQL_F.TextId);
            textBox3.Text = SQL_F.GetSelectData("Patronymic", "clients", SQL_F.TextId);
            dateTimePicker1.Text = SQL_F.GetSelectData("DofB", "clients", SQL_F.TextId);
            textBox4.Text = SQL_F.GetSelectData("Phonenumber", "clients", SQL_F.TextId);
        }

        private void FormUpdateClient_Load(object sender, EventArgs e)
        {
            ClearData();
            SQL_F.DB();
            SQL_F.con.Open();
            try
            {
                TextFillBox();
            }
            finally
            {
                SQL_F.con.Close();
            }
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
