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

namespace DiplomMyProg.Forms2
{

    public partial class FormDataGridView : Form
    {

        private Form activeFormData;

        private void OpenChildForm(Form childForm3, object btnSender)
        {
            if (activeFormData != null)
                activeFormData.Close();
            activeFormData = childForm3;
            childForm3.TopLevel = false;
            childForm3.FormBorderStyle = FormBorderStyle.None;
            this.dataGridView1.Controls.Add(childForm3);
            this.dataGridView1.Tag = childForm3;
            childForm3.Dock = DockStyle.Fill;
            childForm3.BringToFront();
            childForm3.Show();
        }

        public FormDataGridView()
        {
            InitializeComponent();
        }

        private void FormDataGridView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = SQL_F.ShowData(SQL_F.tablesname);
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            if ( dataGridView1.Rows.Count != 0 )
            {
                if (SQL_F.tablesname == "abonements")
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    string selectedCustomersID = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
                    SQL_F.TextId = selectedCustomersID;
                    OpenChildForm(new Forms2.FormUpdateAbonement(), sender);
                }
                if (SQL_F.tablesname == "services")
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    string selectedCustomersID = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
                    SQL_F.TextId = selectedCustomersID;
                    OpenChildForm(new Forms2.FormUpdateServices(), sender);
                }
                if (SQL_F.tablesname == "gym")
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    string selectedCustomersID = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
                    SQL_F.TextId = selectedCustomersID;
                    OpenChildForm(new Forms2.FormUpdateGym(), sender);
                }
                if (SQL_F.tablesname == "stuff")
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    string selectedCustomersID = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
                    SQL_F.TextId = selectedCustomersID;
                    OpenChildForm(new Forms2.FormUpdateStuff(), sender);
                }
                if (SQL_F.tablesname == "clients")
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    string selectedCustomersID = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
                    SQL_F.TextId = selectedCustomersID;
                    OpenChildForm(new Forms2.FormUpdateClient(), sender);
                }
                if (SQL_F.tablesname == "cards")
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    string selectedCustomersID = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
                    SQL_F.TextId = selectedCustomersID;
                    OpenChildForm(new Forms2.FormUpdateCard(), sender);
                }
                if (SQL_F.tablesname == "visit")
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    string selectedCustomersID = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
                    SQL_F.TextId = selectedCustomersID;
                    OpenChildForm(new Forms2.FormUpdateVisit(), sender);
                }
                if (SQL_F.tablesname == "schedule")
                {
                    int selectedIndex = dataGridView1.CurrentCell.RowIndex;
                    string selectedCustomersID = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
                    SQL_F.TextId = selectedCustomersID;
                    OpenChildForm(new Forms2.FormUpdateSchedule(), sender);
                }
            }

        }

        private void deleteData()
        {
            SQL_F.DB();
            int selectedIndex = dataGridView1.CurrentCell.RowIndex;
            string selectedCustomersID = dataGridView1.Rows[selectedIndex].Cells[0].Value.ToString();
            dataGridView1.Rows.RemoveAt(selectedIndex);
            //MessageBox.Show(selectedCustomersID);
            //findAndDelete(selectedCustomersID);
            SQL_F.con.Open();
            string deleteQuery = "DELETE FROM " + SQL_F.tablesname + " WHERE id" + SQL_F.tablesname + " = " + selectedCustomersID;
            SQL_F.con.Close();
            //MessageBox.Show(deleteQuery);
            try
            {
                SQL_F.con.Open();
                MySqlCommand command = new MySqlCommand(deleteQuery, SQL_F.con);
                MySqlDataReader myReader;
                myReader = command.ExecuteReader();
                SQL_F.con.Close();
                SQL_F.con.Open();
                SQL_F.ShowData(SQL_F.tablesname);
                SQL_F.con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("deleteData___" + ex.Message);
            }
        }



        private void buttonDelete_Click(object sender, EventArgs e)
        {
            bool val = false;
            foreach (string a in SQL_F.Output())
            {
                if (SQL_F.tablesname == a)
                {
                    if (dataGridView1.Rows.Count != 0)
                    {
                        deleteData();
                        val = true;
                        MessageBox.Show("удаление прошло!");
                    }
                }
            }
            if (!val)
            {
                MessageBox.Show("Выбраны неверные данные");
            }

        }
    }
}
