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
    public partial class FormUpdateAbonement : Form
    {
        public FormUpdateAbonement()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            string NameAbonements = textBox1.Text;
            double PriceAbonements = double.Parse(textBox2.Text);
            string CountVisiting = textBox3.Text;
            string CountMonth = textBox4.Text;
            // следующие 3 компонента нужно переделать на combobox, и сделать выбор из тех таблиц
            //MessageBox.Show(DateBegin);
            if (NameAbonements.Length != 0 && PriceAbonements != 0 && CountVisiting.Length != 0 && CountMonth.Length != 0)
            {
                MySqlCommand command = new MySqlCommand("UPDATE " +
                    "abonements SET NameAbonements = @NameAbonements, " +
                    "PriceAbonements = @PriceAbonements," +
                    "CountVisiting = @CountVisiting," +
                    "CountMonth = @CountMonth " +
                    "WHERE idAbonements = " + SQL_F.TextId, SQL_F.con);
                command.Parameters.AddWithValue("NameAbonements", textBox1.Text);
                command.Parameters.AddWithValue("PriceAbonements", PriceAbonements);
                command.Parameters.AddWithValue("CountVisiting", textBox3.Text);
                command.Parameters.AddWithValue("CountMonth", textBox4.Text);

                // этот MessageBox возвращает количество обработанных строк
                //MessageBox.Show(command.ExecuteNonQuery().ToString());
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
            textBox4.Text = "";
        }

        private void TextFillBox()
        {
            textBox1.Text = SQL_F.GetSelectData("NameAbonements", "Abonements", SQL_F.TextId);
            textBox2.Text = SQL_F.GetSelectData("PriceAbonements", "Abonements", SQL_F.TextId);
            textBox3.Text = SQL_F.GetSelectData("CountVisiting", "Abonements", SQL_F.TextId);
            textBox4.Text = SQL_F.GetSelectData("CountMonth", "Abonements", SQL_F.TextId);
        }

        private void FormUpdateAbonement_Load(object sender, EventArgs e)
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

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
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
