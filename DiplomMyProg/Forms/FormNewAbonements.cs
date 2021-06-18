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
    public partial class FormNewAbonements : Form
    {

        public int c;

        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            foreach (string a in SQL_F.outputData("Services", "NameServices"))
            {
                comboBox1.Items.Add(a);
            }
        }


        private void TextFillAfterAbonements()
        {
            SQL_F.con.Open();
            textBox3.Text = "";
            string a = SQL_F.getId("Services", "NameServices", "PriceServices", comboBox1.Text);
            SQL_F.con.Close();
            decimal b = Convert.ToDecimal(a);
            b = b * c;
            int d = Convert.ToInt32(b);
            textBox3.Text = d.ToString();
        }

        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            comboBox1.Text = "";
        }


        public FormNewAbonements()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_F.DB();
            SQL_F.con.Open();
            string CountVisiting = textBox1.Text;
            string CountMonth = textBox2.Text;
            string PriceAbonements = textBox3.Text;
            string Name = textBox4.Text;
            if (PriceAbonements.Length != 0 && CountVisiting.Length != 0 && CountMonth.Length != 0 && CountVisiting.Length != 0)
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO " +
                    "abonements (NameAbonements, PriceAbonements, CountVisiting, CountMonth) " +
                    "VALUES (@Name, @PriceAbonements, @CountVisiting, @CountMonth)", SQL_F.con);
                command.Parameters.AddWithValue("CountVisiting", textBox1.Text);
                command.Parameters.AddWithValue("CountMonth", textBox2.Text);
                command.Parameters.AddWithValue("PriceAbonements", PriceAbonements);
                command.Parameters.AddWithValue("Name", textBox4.Text);
                command.ExecuteNonQuery();

                // очищение полей
                ClearData();
            }
            else MessageBox.Show("Пожалуйста заполните все строки");
            SQL_F.con.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void FormNewAbonements_Load(object sender, EventArgs e)
        {
            SQL_F.DB();
            SQL_F.con.Open();
            FillComboBox();
            SQL_F.con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            TextFillAfterAbonements();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0)
            {
                c = Convert.ToInt32(textBox1.Text);
            }
            else c = 0;
        }
    }
}
