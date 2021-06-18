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
    public partial class FormUpdateStuff : Form
    {
        public FormUpdateStuff()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            string Name = textBox1.Text;
            string Surname = textBox2.Text;
            string Patronymic = textBox3.Text;
            string PostJob = textBox4.Text;
            string Phonenumber = textBox5.Text;
            double Salary = double.Parse(textBox6.Text);
            // следующие 3 компонента нужно переделать на combobox, и сделать выбор из тех таблиц
            //MessageBox.Show(DateBegin);
            if (Name.Length != 0 && Surname.Length != 0 && PostJob.Length != 0 && Phonenumber.Length != 0 && Salary !=0)
            {
                MySqlCommand command = new MySqlCommand("UPDATE " +
                    "Stuff SET Name = @Name, " +
                    "Surname = @Surname," +
                    "Patronymic = @Patronymic," +
                    "PostJob = @PostJob, " +
                    "Phonenumber = @Phonenumber, " +
                    "Salary = @Salary " +
                    "WHERE idStuff = " + SQL_F.TextId, SQL_F.con);
                command.Parameters.AddWithValue("Name", textBox1.Text);
                command.Parameters.AddWithValue("Surname", textBox2.Text);
                command.Parameters.AddWithValue("Patronymic", textBox3.Text);
                command.Parameters.AddWithValue("PostJob", textBox4.Text);
                command.Parameters.AddWithValue("Phonenumber", textBox5.Text);
                command.Parameters.AddWithValue("Salary", Salary);

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
            textBox5.Text = "";
            textBox6.Text = "";
        }

        private void TextFillBox()
        {
            textBox1.Text = SQL_F.GetSelectData("Name", "Stuff", SQL_F.TextId);
            textBox2.Text = SQL_F.GetSelectData("Surname", "Stuff", SQL_F.TextId);
            textBox3.Text = SQL_F.GetSelectData("Patronymic", "Stuff", SQL_F.TextId);
            textBox4.Text = SQL_F.GetSelectData("PostJob", "Stuff", SQL_F.TextId);
            textBox5.Text = SQL_F.GetSelectData("Phonenumber", "Stuff", SQL_F.TextId);
            textBox6.Text = SQL_F.GetSelectData("Salary", "Stuff", SQL_F.TextId);
        }

        private void FormUpdateStuff_Load(object sender, EventArgs e)
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
