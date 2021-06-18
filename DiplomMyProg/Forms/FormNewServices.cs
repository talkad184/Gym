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
    public partial class FormNewServices : Form
    {
        public FormNewServices()
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
            string NameService = textBox1.Text;
            string PriceService = textBox2.Text;
            if (NameService.Length != 0 && PriceService.Length != 0)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO services (NameServices, PriceServices) " +
                    "VALUES (@NameServices, @PriceServices)", SQL_F.con);
                command.Parameters.AddWithValue("NameServices", textBox1.Text);
                command.Parameters.AddWithValue("PriceServices", textBox2.Text);
                command.ExecuteNonQuery();
                ClearData();
            }
            else MessageBox.Show("Пожалуйста заполните все строки");
            SQL_F.con.Close();
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
