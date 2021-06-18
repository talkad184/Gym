
namespace DiplomMyProg
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelDesktop2 = new System.Windows.Forms.Panel();
            this.button_OpenPanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Refresh = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button_Min = new System.Windows.Forms.Button();
            this.button_Max = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_CloseChildForm2 = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MediumPurple;
            this.panelMenu.Controls.Add(this.panelDesktop2);
            this.panelMenu.Controls.Add(this.button_OpenPanel);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.button_Refresh);
            this.panelMenu.Controls.Add(this.comboBox1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 662);
            this.panelMenu.TabIndex = 1;
            // 
            // panelDesktop2
            // 
            this.panelDesktop2.Location = new System.Drawing.Point(248, 84);
            this.panelDesktop2.Name = "panelDesktop2";
            this.panelDesktop2.Size = new System.Drawing.Size(728, 577);
            this.panelDesktop2.TabIndex = 6;
            // 
            // button_OpenPanel
            // 
            this.button_OpenPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button_OpenPanel.FlatAppearance.BorderSize = 3;
            this.button_OpenPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_OpenPanel.Font = new System.Drawing.Font("Raavi", 10F);
            this.button_OpenPanel.Location = new System.Drawing.Point(0, 618);
            this.button_OpenPanel.Name = "button_OpenPanel";
            this.button_OpenPanel.Size = new System.Drawing.Size(250, 44);
            this.button_OpenPanel.TabIndex = 5;
            this.button_OpenPanel.Text = "Дополнительно";
            this.button_OpenPanel.UseVisualStyleBackColor = true;
            this.button_OpenPanel.Click += new System.EventHandler(this.button_OpenPanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Raavi", 14F);
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 39);
            this.label1.TabIndex = 4;
            this.label1.Text = "Выберете таблицу";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.UseCompatibleTextRendering = true;
            // 
            // button_Refresh
            // 
            this.button_Refresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Refresh.Font = new System.Drawing.Font("Raavi", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Refresh.Location = new System.Drawing.Point(27, 206);
            this.button_Refresh.Name = "button_Refresh";
            this.button_Refresh.Size = new System.Drawing.Size(201, 34);
            this.button_Refresh.TabIndex = 1;
            this.button_Refresh.Text = "Обновить Базу";
            this.button_Refresh.UseVisualStyleBackColor = true;
            this.button_Refresh.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Arial", 12F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(27, 109);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(201, 26);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.Click += new System.EventHandler(this.comboBox1_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTitleBar.Controls.Add(this.button_Min);
            this.panelTitleBar.Controls.Add(this.button_Max);
            this.panelTitleBar.Controls.Add(this.button_Close);
            this.panelTitleBar.Controls.Add(this.button_CloseChildForm2);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(727, 85);
            this.panelTitleBar.TabIndex = 2;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            // 
            // button_Min
            // 
            this.button_Min.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Min.FlatAppearance.BorderSize = 0;
            this.button_Min.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Min.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Min.Location = new System.Drawing.Point(632, 0);
            this.button_Min.Name = "button_Min";
            this.button_Min.Size = new System.Drawing.Size(33, 24);
            this.button_Min.TabIndex = 4;
            this.button_Min.Text = "O";
            this.button_Min.UseVisualStyleBackColor = true;
            this.button_Min.Click += new System.EventHandler(this.button_Min_Click);
            // 
            // button_Max
            // 
            this.button_Max.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Max.FlatAppearance.BorderSize = 0;
            this.button_Max.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Max.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Max.Location = new System.Drawing.Point(664, 0);
            this.button_Max.Name = "button_Max";
            this.button_Max.Size = new System.Drawing.Size(33, 24);
            this.button_Max.TabIndex = 3;
            this.button_Max.Text = "O";
            this.button_Max.UseVisualStyleBackColor = true;
            this.button_Max.Click += new System.EventHandler(this.button_Max_Click);
            // 
            // button_Close
            // 
            this.button_Close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button_Close.FlatAppearance.BorderSize = 0;
            this.button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Close.Location = new System.Drawing.Point(696, 0);
            this.button_Close.Name = "button_Close";
            this.button_Close.Size = new System.Drawing.Size(31, 24);
            this.button_Close.TabIndex = 2;
            this.button_Close.Text = "O";
            this.button_Close.UseVisualStyleBackColor = true;
            this.button_Close.Click += new System.EventHandler(this.button_Close_Click);
            // 
            // button_CloseChildForm2
            // 
            this.button_CloseChildForm2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_CloseChildForm2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CloseChildForm2.BackgroundImage")));
            this.button_CloseChildForm2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_CloseChildForm2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_CloseChildForm2.FlatAppearance.BorderSize = 0;
            this.button_CloseChildForm2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CloseChildForm2.Location = new System.Drawing.Point(0, 0);
            this.button_CloseChildForm2.Name = "button_CloseChildForm2";
            this.button_CloseChildForm2.Size = new System.Drawing.Size(102, 85);
            this.button_CloseChildForm2.TabIndex = 1;
            this.button_CloseChildForm2.UseVisualStyleBackColor = false;
            this.button_CloseChildForm2.Click += new System.EventHandler(this.button_CloseChildForm2_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Miriam Fixed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(337, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(286, 27);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Панель Администратора";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDesktop.Controls.Add(this.label2);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(250, 85);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(727, 577);
            this.panelDesktop.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Raavi", 12F);
            this.label2.Location = new System.Drawing.Point(85, 208);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(447, 108);
            this.label2.TabIndex = 0;
            this.label2.Text = "Добро пожаловать в панель администратора\r\n\r\n\r\nВыберете таблицу, либо нажмите \"Доп" +
    "олнительно\"";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(977, 662);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(993, 700);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelTitleBar_MouseDown);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button button_Min;
        private System.Windows.Forms.Button button_Max;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button_CloseChildForm2;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Refresh;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button_OpenPanel;
        private System.Windows.Forms.Panel panelDesktop2;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Label label2;
    }
}