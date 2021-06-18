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
    public partial class FormUpdateVisit : Form
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
        }

        private void TextFillBox()
        {
            dateTimePicker2.Text = SQL_F.GetSelectData("DateVisit", "Visit", SQL_F.TextId);
            maskedTextBox1.Text = dateTimePicker2.Text;
            comboBox1.Text = SQL_F.getId("Cards", "idCards", "idCards", SQL_F.GetSelectData("Cards_idCards", "Visit", SQL_F.TextId));
            dateTimePicker1.Text = SQL_F.getId("Schedule", "idSchedule", "Date", SQL_F.GetSelectData("Schedule_idSchedule", "Visit", SQL_F.TextId));
            comboBox2.Text = dateTimePicker1.Text;
        }

        private void ClearData()
        {
            dateTimePicker1.Text = "";
            dateTimePicker2.Text = "";
            maskedTextBox1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
        }

        public FormUpdateVisit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            string Date = maskedTextBox1.Text;
            string Cards = comboBox1.Text;
            string Schedule = comboBox2.Text;
            if (Date.Length != 0 && Cards.Length != 0 && Schedule.Length != 0
                && SQL_F.Validate(Cards, SQL_F.outputData("Cards", "idCards"))
                && SQL_F.Validate(Schedule, masDate) )
            {
                MySqlCommand command = new MySqlCommand("UPDATE " +
                    "Visit SET DateVisit = @DateVisit," +
                    "Cards_idCards = @Cards_idCards," +
                    "Schedule_idSchedule = @Schedule_idSchedule " +
                    "WHERE idVisit = " + SQL_F.TextId, SQL_F.con);
                command.Parameters.AddWithValue("DateVisit", maskedTextBox1.Text);
                command.Parameters.AddWithValue("Cards_idCards", SQL_F.getId("Cards", "idCards", "idCards", comboBox1.Text));
                command.Parameters.AddWithValue("Schedule_idSchedule", SQL_F.getId("Schedule", "Date", "idSchedule", comboBox2.Text));
                command.ExecuteNonQuery();

                // очищение полей
                ClearData();
            }
            else MessageBox.Show("Выбраны неверные данные или заполнены не все строки");
            SQL_F.con.Close();
            this.Close();
        }

        private void FormUpdateVisit_Load(object sender, EventArgs e)
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
            dateTimePicker1.Hide();
            dateTimePicker2.Hide();
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
