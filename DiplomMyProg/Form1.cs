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
    public partial class Form1 : Form
    {
        
        private Button currentButton;
        private Form activeForm;

        public Form1()
        {
            InitializeComponent();
            button_CloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelectThemeColor()
        {
            string color = ThemeColor.ColorList[1];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.FromArgb(21, 51, 76);
                    currentButton.ForeColor = Color.MediumPurple;
                    currentButton.Font = new System.Drawing.Font("Verdana", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    button_CloseChildForm.Visible = true;
                }
            }
        }

        private void ActivateButtonAdd(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButtonAdd();
                    currentButton = (Button)btnSender;
                    button_CloseChildForm.Visible = true;
                }
            }
        }

        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    Color color = SelectThemeColor();
                    previousBtn.BackColor = Color.MediumPurple;
                    previousBtn.ForeColor = Color.Black;
                    previousBtn.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void DisableButtonAdd()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    Color color = SelectThemeColor();
                }
            }
        }

        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void OpenChildFormAdd(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            ActivateButtonAdd(btnSender);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            labelTitle.Text = childForm.Text;
        }

        private void button_NewCard_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNewCards(), sender);
        }

        private void button_NewAbonements_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNewAbonements(), sender);
        }

        private void button_NewService_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormNewServices(), sender);
        }

        private void button_CloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
                activeForm.Close();
                Reset();
        }
        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "Главная страница";
            panelTitleBar.BackColor = Color.MidnightBlue;
            panelLogo.BackColor = Color.Indigo;
            currentButton = null;
            button_CloseChildForm.Visible = false;
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void button1_Click(object sender, EventArgs e)
        {
            Forms.FormAuth fauth = new Forms.FormAuth();
            fauth.Show();      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //SQL_F.DB();
            //SQL_F.con.Open();
            //SQL_F.con.Close();
        }


        private void button_NewClient_Click(object sender, EventArgs e)
        {
            OpenChildFormAdd(new Forms.FormAddNewClient(), sender);
        }

        private void button_Schedule_Click(object sender, EventArgs e)
        {
            OpenChildFormAdd(new Forms.FormAddNewShedule(), sender);
        }

        private void button_Visit_Click(object sender, EventArgs e)
        {
            OpenChildFormAdd(new Forms.FormAddNewVisit(), sender);
        }
    }
}
