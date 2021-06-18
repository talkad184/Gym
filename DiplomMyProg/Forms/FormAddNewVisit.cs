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

namespace DiplomMyProg.Forms
{
    public partial class FormAddNewVisit : Form
    {

        private List<string> masDate = new List<string>();

        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            foreach (string a in SQL_F.outputData("Cards", "idCards"))
            {
                comboBox1.Items.Add(a);
            }
            foreach (string a in SQL_F.outputData("Schedule", "Date"))
            {
                dateTimePicker1.Text = a;
                masDate.Add(dateTimePicker1.Text);
                comboBox2.Items.Add(dateTimePicker1.Text);
            }
            dateTimePicker1.Hide();
        }


        private void ClearData()
        {
            maskedTextBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        public FormAddNewVisit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            string DateVisit = maskedTextBox1.Text;
            string Cards_idCards = comboBox1.Text;
            string Schedule_idSchedule = comboBox2.Text;
            dateTimePicker1.Text = Schedule_idSchedule;
            // следующие 3 компонента нужно переделать на combobox, и сделать выбор из тех таблиц
            //MessageBox.Show(DateBegin);

            //if (SQL_F.Validate(dateTimePicker1.Text, masDate))
            //{
            //    MessageBox.Show("дата совпадает");
            //}
            //else MessageBox.Show("дата не совпадает. " + dateTimePicker1.Text + "   " + comboBox2.Items[0] );

            if (DateVisit.Length != 0 && Cards_idCards.Length != 0 && Schedule_idSchedule.Length != 0
                && SQL_F.Validate(Cards_idCards, SQL_F.outputData("Cards", "idCards"))
                && SQL_F.Validate(Schedule_idSchedule, masDate))
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO " +
                    "Visit (DateVisit, Cards_idCards, Schedule_idSchedule) " +
                    "VALUES (@DateVisit, @Cards_idCards, @Schedule_idSchedule)", SQL_F.con);
                command.Parameters.AddWithValue("DateVisit", maskedTextBox1.Text);
                command.Parameters.AddWithValue("Cards_idCards", SQL_F.getId("Cards", "idCards", "idCards", comboBox1.Text));
                command.Parameters.AddWithValue("Schedule_idSchedule", SQL_F.getId("Schedule", "Date", "idSchedule", comboBox2.Text));
                // этот MessageBox возвращает количество обработанных строк
                //MessageBox.Show(command.ExecuteNonQuery().ToString());
                command.ExecuteNonQuery();
                // очищение полей
                ClearData();
            }
            else MessageBox.Show("Выбраны неверные данные или заполнены не все строки");
            SQL_F.con.Close();
        }

        private void FormAddNewVisit_Load(object sender, EventArgs e)
        {
            SQL_F.DB();
            SQL_F.con.Open();
            FillComboBox();
            SQL_F.con.Close();
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
    }
}
