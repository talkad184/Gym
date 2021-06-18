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
    public partial class FormAddNewShedule : Form
    {
        public FormAddNewShedule()
        {
            InitializeComponent();
        }

        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            foreach (string a in SQL_F.outputData("stuff", "Surname"))
            {
                comboBox1.Items.Add(a);
            }
            foreach (string a in SQL_F.outputData("services", "NameServices"))
            {
                comboBox2.Items.Add(a);
            }
            foreach (string a in SQL_F.outputData("gym", "Adress"))
            {
                comboBox3.Items.Add(a);
            }
        }

        private void FormAddNewShedule_Load(object sender, EventArgs e)
        {
            SQL_F.DB();
            SQL_F.con.Open();
            FillComboBox();
            SQL_F.con.Close();
        }

        private void ClearData()
        {
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            string Date = dateTimePicker1.Text;
            string Stuff = comboBox1.Text;
            string Services = comboBox2.Text;
            string Gym = comboBox3.Text;
           // следующие 3 компонента нужно переделать на combobox, и сделать выбор из тех таблиц
            //MessageBox.Show(DateBegin);
            if (Date.Length != 0 && Stuff.Length != 0 && Services.Length != 0 && Gym.Length != 0
                && SQL_F.Validate(Stuff, SQL_F.outputData("stuff", "Surname"))
                && SQL_F.Validate(Services, SQL_F.outputData("services", "NameServices"))
                && SQL_F.Validate(Gym, SQL_F.outputData("gym", "Adress")) )
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO " +
                    "Schedule (Date, Stuff_idStuff, Services_idServices, Gym_idGym) " +
                    "VALUES (@Date, @Stuff_idStuff, @Services_idServices, @Gym_idGym)", SQL_F.con);
                command.Parameters.AddWithValue("Date", dateTimePicker1.Text);
                command.Parameters.AddWithValue("Stuff_idStuff", SQL_F.getId("Stuff", "Surname", "idStuff", comboBox1.Text));
                command.Parameters.AddWithValue("Services_idServices", SQL_F.getId("services", "NameServices", "idServices", comboBox2.Text));
                command.Parameters.AddWithValue("Gym_idGym", SQL_F.getId("gym", "Adress", "idGym", comboBox3.Text));
                // этот MessageBox возвращает количество обработанных строк
                //MessageBox.Show(command.ExecuteNonQuery().ToString());
                command.ExecuteNonQuery();
                // очищение полей
                ClearData();
            }
            else MessageBox.Show("Выбраны неверные данные или заполнены не все строки");

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

        private void comboBox3_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            FillComboBox();
            SQL_F.con.Close();
        }
    }
}
