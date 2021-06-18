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
    public partial class FormUpdateSchedule : Form
    {
        public FormUpdateSchedule()
        {
            InitializeComponent();
        }

        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();
            foreach (string a in SQL_F.outputData("Stuff", "PostJob"))
            {
                comboBox1.Items.Add(a);
            }
            foreach (string a in SQL_F.outputData("Services", "NameServices"))
            {
                comboBox2.Items.Add(a);
            }
            foreach (string a in SQL_F.outputData("Gym", "Adress"))
            {
                comboBox3.Items.Add(a);
            }
        }

        private void TextFillBox()
        {
            dateTimePicker1.Text = SQL_F.GetSelectData("Date", "Schedule", SQL_F.TextId);
            comboBox1.Text = SQL_F.getId("Stuff", "idStuff", "PostJob", SQL_F.GetSelectData("Stuff_idStuff", "Schedule", SQL_F.TextId));
            comboBox2.Text = SQL_F.getId("Services", "idServices", "NameServices", SQL_F.GetSelectData("Services_idServices", "Schedule", SQL_F.TextId));
            comboBox3.Text = SQL_F.getId("Gym", "idGym", "Adress", SQL_F.GetSelectData("Gym_idGym", "Schedule", SQL_F.TextId));
        }

        private void ClearData()
        {
            dateTimePicker1.Text = "";
            comboBox1.Text = "";
            comboBox2.Text = "";
            comboBox3.Text = "";
        }

        private void FormUpdateSchedule_Load(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            string Date = dateTimePicker1.Text;
            string Stuff = comboBox1.Text;
            string Services = comboBox2.Text;
            string Gym = comboBox3.Text;
            if (Date.Length != 0 && Stuff.Length != 0 && Services.Length != 0 && Gym.Length != 0
                && SQL_F.Validate(Stuff, SQL_F.outputData("stuff", "Surname"))
                && SQL_F.Validate(Services, SQL_F.outputData("services", "NameServices"))
                && SQL_F.Validate(Gym, SQL_F.outputData("gym", "Adress")) )
            {
                MySqlCommand command = new MySqlCommand("UPDATE " +
                    "Schedule SET Date = @Date," +
                    "Stuff_idStuff = @Stuff_idStuff," +
                    "Services_idServices = @Services_idServices," +
                    "Gym_idGym = @Gym_idGym " +
                    "WHERE idSchedule = " + SQL_F.TextId, SQL_F.con);
                command.Parameters.AddWithValue("Date", dateTimePicker1.Text);
                command.Parameters.AddWithValue("Stuff_idStuff", SQL_F.getId("Stuff", "PostJob", "idStuff", comboBox1.Text));
                command.Parameters.AddWithValue("Services_idServices", SQL_F.getId("Services", "NameServices", "idServices", comboBox2.Text));
                command.Parameters.AddWithValue("Gym_idGym", SQL_F.getId("Gym", "Adress", "idGym", comboBox3.Text));
                command.ExecuteNonQuery();

                // очищение полей
                ClearData();
            }
            else MessageBox.Show("Выбраны неверные данные или заполнены не все строки");
            SQL_F.con.Close();
            this.Close();
        }

        private void comboBox3_Click(object sender, EventArgs e)
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

        private void comboBox1_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            FillComboBox();
            SQL_F.con.Close();
        }
    }
}
