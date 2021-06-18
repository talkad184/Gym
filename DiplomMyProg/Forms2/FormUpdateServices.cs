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
    public partial class FormUpdateServices : Form
    {
        public FormUpdateServices()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void TextFillBox()
        {
            textBox1.Text = SQL_F.GetSelectData("NameServices", "Services", SQL_F.TextId);
            textBox2.Text = SQL_F.GetSelectData("PriceServices", "Services", SQL_F.TextId);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            string NameServices = textBox1.Text;
            double PriceServices = double.Parse(textBox2.Text);
            if (NameServices.Length != 0 && PriceServices != 0)
            {
                MySqlCommand command = new MySqlCommand("UPDATE " +
                    "Services SET NameServices = @NameServices, " +
                    "PriceServices = @PriceServices " +
                    "WHERE idServices = " + SQL_F.TextId, SQL_F.con);
                command.Parameters.AddWithValue("NameServices", textBox1.Text);
                command.Parameters.AddWithValue("PriceServices", PriceServices);
                command.ExecuteNonQuery();

                // очищение полей
                ClearData();
            }
            else MessageBox.Show("Пожалуйста заполните все строки");
            SQL_F.con.Close();

            this.Close();
        }

        private void FormUpdateServices_Load(object sender, EventArgs e)
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
    }
}
