
namespace DiplomMyProg
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button_NewService = new System.Windows.Forms.Button();
            this.button_NewAbonements = new System.Windows.Forms.Button();
            this.button_NewCard = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.button_Min = new System.Windows.Forms.Button();
            this.button_Max = new System.Windows.Forms.Button();
            this.button_Close = new System.Windows.Forms.Button();
            this.button_CloseChildForm = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Visit = new System.Windows.Forms.Button();
            this.button_Schedule = new System.Windows.Forms.Button();
            this.button_NewClient = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.MediumPurple;
            this.panelMenu.Controls.Add(this.button_NewService);
            this.panelMenu.Controls.Add(this.button_NewAbonements);
            this.panelMenu.Controls.Add(this.button_NewCard);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 562);
            this.panelMenu.TabIndex = 0;
            // 
            // button_NewService
            // 
            this.button_NewService.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_NewService.FlatAppearance.BorderSize = 0;
            this.button_NewService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewService.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NewService.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_NewService.Location = new System.Drawing.Point(0, 263);
            this.button_NewService.Name = "button_NewService";
            this.button_NewService.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_NewService.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_NewService.Size = new System.Drawing.Size(250, 89);
            this.button_NewService.TabIndex = 3;
            this.button_NewService.Text = "Новая Услуга";
            this.button_NewService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_NewService.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_NewService.UseVisualStyleBackColor = true;
            this.button_NewService.Click += new System.EventHandler(this.button_NewService_Click);
            // 
            // button_NewAbonements
            // 
            this.button_NewAbonements.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_NewAbonements.FlatAppearance.BorderSize = 0;
            this.button_NewAbonements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewAbonements.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NewAbonements.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_NewAbonements.Location = new System.Drawing.Point(0, 174);
            this.button_NewAbonements.Name = "button_NewAbonements";
            this.button_NewAbonements.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_NewAbonements.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_NewAbonements.Size = new System.Drawing.Size(250, 89);
            this.button_NewAbonements.TabIndex = 2;
            this.button_NewAbonements.Text = "Новый Абонемент";
            this.button_NewAbonements.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_NewAbonements.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_NewAbonements.UseVisualStyleBackColor = true;
            this.button_NewAbonements.Click += new System.EventHandler(this.button_NewAbonements_Click);
            // 
            // button_NewCard
            // 
            this.button_NewCard.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_NewCard.FlatAppearance.BorderSize = 0;
            this.button_NewCard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewCard.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NewCard.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_NewCard.Location = new System.Drawing.Point(0, 85);
            this.button_NewCard.Name = "button_NewCard";
            this.button_NewCard.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.button_NewCard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button_NewCard.Size = new System.Drawing.Size(250, 89);
            this.button_NewCard.TabIndex = 1;
            this.button_NewCard.Text = "Новая Карта";
            this.button_NewCard.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button_NewCard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button_NewCard.UseVisualStyleBackColor = true;
            this.button_NewCard.Click += new System.EventHandler(this.button_NewCard_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Indigo;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 85);
            this.panelLogo.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.MidnightBlue;
            this.panelTitleBar.Controls.Add(this.button_Min);
            this.panelTitleBar.Controls.Add(this.button_Max);
            this.panelTitleBar.Controls.Add(this.button_Close);
            this.panelTitleBar.Controls.Add(this.button_CloseChildForm);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(727, 85);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
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
            // button_CloseChildForm
            // 
            this.button_CloseChildForm.BackColor = System.Drawing.Color.MidnightBlue;
            this.button_CloseChildForm.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button_CloseChildForm.BackgroundImage")));
            this.button_CloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.button_CloseChildForm.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button_CloseChildForm.FlatAppearance.BorderSize = 0;
            this.button_CloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_CloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.button_CloseChildForm.Name = "button_CloseChildForm";
            this.button_CloseChildForm.Size = new System.Drawing.Size(102, 85);
            this.button_CloseChildForm.TabIndex = 1;
            this.button_CloseChildForm.UseVisualStyleBackColor = false;
            this.button_CloseChildForm.Click += new System.EventHandler(this.button_CloseChildForm_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Miriam Fixed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelTitle.Location = new System.Drawing.Point(337, 31);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(213, 27);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Главная страница";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelDesktop.Controls.Add(this.button1);
            this.panelDesktop.Controls.Add(this.button_Visit);
            this.panelDesktop.Controls.Add(this.button_Schedule);
            this.panelDesktop.Controls.Add(this.button_NewClient);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(250, 85);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(727, 477);
            this.panelDesktop.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(570, 425);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 52);
            this.button1.TabIndex = 3;
            this.button1.Text = "Панель Администратора";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_Visit
            // 
            this.button_Visit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Visit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Visit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Visit.Location = new System.Drawing.Point(100, 260);
            this.button_Visit.Name = "button_Visit";
            this.button_Visit.Size = new System.Drawing.Size(555, 59);
            this.button_Visit.TabIndex = 2;
            this.button_Visit.Text = "Учёт посещений";
            this.button_Visit.UseVisualStyleBackColor = true;
            this.button_Visit.Click += new System.EventHandler(this.button_Visit_Click);
            // 
            // button_Schedule
            // 
            this.button_Schedule.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_Schedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Schedule.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Schedule.Location = new System.Drawing.Point(100, 160);
            this.button_Schedule.Name = "button_Schedule";
            this.button_Schedule.Size = new System.Drawing.Size(555, 59);
            this.button_Schedule.TabIndex = 1;
            this.button_Schedule.Text = "Сделать запись в расписание";
            this.button_Schedule.UseVisualStyleBackColor = true;
            this.button_Schedule.Click += new System.EventHandler(this.button_Schedule_Click);
            // 
            // button_NewClient
            // 
            this.button_NewClient.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_NewClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_NewClient.Location = new System.Drawing.Point(100, 60);
            this.button_NewClient.Name = "button_NewClient";
            this.button_NewClient.Size = new System.Drawing.Size(555, 59);
            this.button_NewClient.TabIndex = 0;
            this.button_NewClient.Text = "Добавить нового клиента";
            this.button_NewClient.UseVisualStyleBackColor = true;
            this.button_NewClient.Click += new System.EventHandler(this.button_NewClient_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(977, 562);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MinimumSize = new System.Drawing.Size(750, 550);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelDesktop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button button_NewCard;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button button_NewAbonements;
        private System.Windows.Forms.Button button_NewService;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Button button_CloseChildForm;
        private System.Windows.Forms.Button button_Min;
        private System.Windows.Forms.Button button_Max;
        private System.Windows.Forms.Button button_Close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_Visit;
        private System.Windows.Forms.Button button_Schedule;
        private System.Windows.Forms.Button button_NewClient;
    }
}

