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

namespace DiplomMyProg
{
    public partial class FormDelete : Form
    {
        public FormDelete()
        {
            InitializeComponent();
        }

        private void ClearData()
        {
            comboBox1.Text = "";

        }

        private void FillComboBox()
        {
            comboBox1.Items.Clear();
            foreach (string a in outputDataDelete("information_schema.tables", "table_name"))
            {
                comboBox1.Items.Add(a);
            }
        }

        public static List<string> outputDataDelete(string table, string column)
        {
            List<string> mas = new List<string>();
            string selectQuery = "SELECT " + column + " FROM " + table + " WHERE table_schema = 'mydb'";
            try
            {
                using (MySqlCommand com = new MySqlCommand(selectQuery, SQL_F.con))
                {
                    using (MySqlDataReader rd = com.ExecuteReader())
                    {
                        while (rd.Read())
                        {
                            mas.Add(rd[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return mas;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SQL_F.con.Open();
            string Table = comboBox1.Text;
            //следующие 3 компонента нужно переделать на combobox, и сделать выбор из тех таблиц
            //MessageBox.Show(DateBegin);
            if (Table.Length != 0 && SQL_F.Validate(Table, SQL_F.Output()) )
            {
                SQL_F.con.Open();
                MySqlCommand command = new MySqlCommand("DELETE FROM " + Table + "; ALTER TABLE " + Table + " AUTO_INCREMENT=0;", SQL_F.con);
                command.Parameters.AddWithValue("Table", Table);
                command.ExecuteNonQuery();
                // очищение полей
                ClearData();
            }
            else MessageBox.Show("Выбраны неверные данные");
            SQL_F.con.Close();
            Close();
        }

        private void FormDelete_Load(object sender, EventArgs e)
        {
            SQL_F.DB();
            SQL_F.con.Open();
            FillComboBox();
            SQL_F.con.Close();
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            SQL_F.DB();
            SQL_F.con.Open();
            FillComboBox();
            SQL_F.con.Close();
        }
    }
}
