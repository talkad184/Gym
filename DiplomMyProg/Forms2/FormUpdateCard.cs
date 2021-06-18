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
    public partial class FormUpdateCard : Form
    {
        public FormUpdateCard()
        {
            InitializeComponent();
        }

        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            foreach (string a in SQL_F.outputData("Abonements", "NameAbonements"))
            {
                comboBox1.Items.Add(a);
            }
            foreach (string a in SQL_F.outputData("Clients", "idClients"))
            {
                comboBox2.Items.Add(a);
            }
        }

        private void TextFillBox()
        {
            dateTimePicker1.Text = SQL_F.GetSelectData("DateBegin", "Cards", SQL_F.TextId);
            dateTimePicker2.Text = SQL_F.GetSelectData("DateEnd", "Cards", SQL_F.TextId);
            comboBox1.Text = SQL_F.getId("Abonements", "idAbonements", "NameAbonements", SQL_F.GetSelectData("Abonements_idAbonements", "Cards", SQL_F.TextId));
            comboBox2.Text = SQL_F.getId("Clients", "idClients", "idClients", SQL_F.GetSelectData("Clients_idClients", "Cards", SQL_F.TextId));

        }

        private void ClearData()
        {
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            string DateBegin = dateTimePicker1.Text;
            string DateEnd = dateTimePicker2.Text;
            string Abonements = comboBox1.Text;
            string Clients = comboBox2.Text;
            if (DateBegin.Length != 0 && DateEnd.Length != 0  && Abonements.Length != 0 && Clients.Length != 0
                && SQL_F.Validate(Clients, SQL_F.outputData("clients", "Surname"))
                && SQL_F.Validate(Abonements, SQL_F.outputData("abonements", "NameAbonements")) )
            {
                MySqlCommand command = new MySqlCommand("UPDATE " +
                    "cards SET DateBegin = @DateBegin," +
                    "DateEnd = @DateEnd," +
                    "Abonements_idAbonements = @Abonements_idAbonements," +
                    "Clients_idClients = @Clients_idClients " +
                    "WHERE idCards = " + SQL_F.TextId, SQL_F.con);
                command.Parameters.AddWithValue("DateBegin", dateTimePicker1.Text);
                command.Parameters.AddWithValue("DateEnd", dateTimePicker2.Text);
                command.Parameters.AddWithValue("Abonements_idAbonements", SQL_F.getId("Abonements", "NameAbonements", "idAbonements", comboBox1.Text));
                command.Parameters.AddWithValue("Clients_idClients", SQL_F.getId("Clients", "idClients", "idClients", comboBox2.Text));
                command.ExecuteNonQuery();

                // очищение полей
                ClearData();
            }
            else MessageBox.Show("Выбраны неверные данные или заполнены не все строки");
            SQL_F.con.Close();
            this.Close();
        }

        private void FormUpdateCard_Load(object sender, EventArgs e)
        {
            ClearData();
            SQL_F.DB();
            SQL_F.con.Open();
            try
            {
                TextFillBox();
                FillComboBox();
            }
            finally
            {
                SQL_F.con.Close();
            }
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            FillComboBox();
            SQL_F.con.Close();
        }

        private void comboBox2_Click(object sender, EventArgs e)
        {
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
    }
}
