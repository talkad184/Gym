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
    public partial class FormNewCards : Form
    {
        public FormNewCards()
        {
            InitializeComponent();
        }


        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            foreach (string a in SQL_F.outputData("abonements", "NameAbonements"))
            {
                comboBox1.Items.Add(a);
            }
            foreach (string a in SQL_F.outputData("clients", "Surname"))
            {
                comboBox2.Items.Add(a);
            }

        }


        private void ClearData()
        {
            textBox1.Text = "";
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void TextFillAfterAbonements()
        {
            SQL_F.con.Open();
            textBox1.Text = "";
            textBox1.Text = SQL_F.getId("Abonements", "NameAbonements", "CountVisiting", comboBox1.Text);
            SQL_F.con.Close();
            SQL_F.con.Open();
            string a = SQL_F.getId("Abonements", "NameAbonements", "CountMonth", comboBox1.Text);
            int b = Convert.ToInt32(a);
            dateTimePicker2.Value = DateTime.Now.AddMonths(b);
            SQL_F.con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            string DateBegin = dateTimePicker1.Text;
            string DateEnd = dateTimePicker2.Text;
            string Clients = comboBox2.Text;
            string Abonements = comboBox1.Text;
            int Status = 1;
            //следующие 3 компонента нужно переделать на combobox, и сделать выбор из тех таблиц
            //MessageBox.Show(DateBegin);
            if (Clients.Length != 0 && Abonements.Length != 0
                && SQL_F.Validate(Clients, SQL_F.outputData("clients", "Surname"))
                && SQL_F.Validate(Abonements, SQL_F.outputData("abonements", "NameAbonements")) )
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO " +
                    "Cards (DateBegin, DateEnd, Clients_idClients, Abonements_idAbonements, Status) " +
                    "VALUES (@DateBegin, @DateEnd, @Clients_idClients, @Abonements_idAbonements, @Status)", SQL_F.con);
                command.Parameters.AddWithValue("DateBegin", dateTimePicker1.Text);
                command.Parameters.AddWithValue("DateEnd", dateTimePicker2.Text);
                command.Parameters.AddWithValue("Clients_idClients", SQL_F.getId("Clients", "Surname", "idClients", comboBox2.Text));
                command.Parameters.AddWithValue("Abonements_idAbonements", SQL_F.getId("Abonements", "NameAbonements", "idAbonements", comboBox1.Text));
                command.Parameters.AddWithValue("Status", Status);
                // этот MessageBox возвращает количество обработанных строк
                command.ExecuteNonQuery();

                // очищение полей
                ClearData();
            }
            else MessageBox.Show("Выбраны неверные данные или заполнены не все строки");
            SQL_F.con.Close();
        }

        private void FormNewCards_Load(object sender, EventArgs e)
        {
            SQL_F.DB();
            SQL_F.con.Open();
            FillComboBox();
            SQL_F.con.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextFillAfterAbonements();
        }
    }
}
