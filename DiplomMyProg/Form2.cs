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
    public partial class Form2 : Form
    {

        private Button currentButton;
        private Form activeForm2;

        public Form2()
        {
            InitializeComponent();
            button_CloseChildForm2.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(21, 51, 76);
                    currentButton.ForeColor = Color.MediumPurple;
                    currentButton.Font = new System.Drawing.Font("Raavi", 12F);
                    button_CloseChildForm2.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.MediumPurple;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Raavi", 10F);
                }
            }
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "Панель администратора";
            panelTitleBar.BackColor = Color.MidnightBlue;
            currentButton = null;
            button_CloseChildForm2.Visible = false;
        }

        private void OpenChildForm(Form childForm2, object btnSender)
        {
            if (activeForm2 != null)
                activeForm2.Close();
            ActivateButton(btnSender);
            activeForm2 = childForm2;
            childForm2.TopLevel = false;
            childForm2.FormBorderStyle = FormBorderStyle.None;
            childForm2.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm2);
            this.panelDesktop.Tag = childForm2;
            childForm2.BringToFront();
            childForm2.Show();
            labelTitle.Text = childForm2.Text;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button_Max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void button_Min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button_OpenPanel_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms2.FormPanel(), sender);
        }

        private void button_CloseChildForm2_Click(object sender, EventArgs e)
        {
            if (activeForm2 != null)
                activeForm2.Close();
            Reset();
        }

        private void button_Refresh_Click(object sender, EventArgs e)
        {
            SQL_F.DB();
            SQL_F.con.Open();
            if (SQL_F.Validate(comboBox1.Text, SQL_F.Output()))
            {
                SQL_F.tablesname = comboBox1.Text;
                OpenChildForm(new Forms2.FormDataGridView(), sender);
            }
            else MessageBox.Show("Неверное имя таблицы");
        }

        private void comboBox1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            SQL_F.DB();
            SQL_F.con.Open();
            foreach (string a in SQL_F.Output())
                comboBox1.Items.Add(a);
            SQL_F.con.Close();
        }
    }
}
