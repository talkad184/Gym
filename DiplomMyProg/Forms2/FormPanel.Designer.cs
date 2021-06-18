
namespace DiplomMyProg.Forms2
{
    partial class FormPanel
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
            this.button_NewStuff = new System.Windows.Forms.Button();
            this.button_NewGym = new System.Windows.Forms.Button();
            this.button_DeleteTable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_NewStuff
            // 
            this.button_NewStuff.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_NewStuff.FlatAppearance.BorderSize = 2;
            this.button_NewStuff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewStuff.Font = new System.Drawing.Font("Raavi", 12F);
            this.button_NewStuff.Location = new System.Drawing.Point(218, 52);
            this.button_NewStuff.Name = "button_NewStuff";
            this.button_NewStuff.Size = new System.Drawing.Size(369, 56);
            this.button_NewStuff.TabIndex = 0;
            this.button_NewStuff.Text = "Добавить сотрудника";
            this.button_NewStuff.UseCompatibleTextRendering = true;
            this.button_NewStuff.UseVisualStyleBackColor = true;
            this.button_NewStuff.Click += new System.EventHandler(this.button_NewStuff_Click);
            // 
            // button_NewGym
            // 
            this.button_NewGym.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_NewGym.FlatAppearance.BorderSize = 2;
            this.button_NewGym.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_NewGym.Font = new System.Drawing.Font("Raavi", 12F);
            this.button_NewGym.Location = new System.Drawing.Point(217, 145);
            this.button_NewGym.Name = "button_NewGym";
            this.button_NewGym.Size = new System.Drawing.Size(369, 56);
            this.button_NewGym.TabIndex = 1;
            this.button_NewGym.Text = "Добавить зал";
            this.button_NewGym.UseCompatibleTextRendering = true;
            this.button_NewGym.UseVisualStyleBackColor = true;
            this.button_NewGym.Click += new System.EventHandler(this.button_NewGym_Click);
            // 
            // button_DeleteTable
            // 
            this.button_DeleteTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_DeleteTable.FlatAppearance.BorderSize = 2;
            this.button_DeleteTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteTable.Font = new System.Drawing.Font("Raavi", 12F);
            this.button_DeleteTable.Location = new System.Drawing.Point(217, 301);
            this.button_DeleteTable.Name = "button_DeleteTable";
            this.button_DeleteTable.Size = new System.Drawing.Size(369, 56);
            this.button_DeleteTable.TabIndex = 2;
            this.button_DeleteTable.Text = "Очистить таблицу";
            this.button_DeleteTable.UseCompatibleTextRendering = true;
            this.button_DeleteTable.UseVisualStyleBackColor = true;
            this.button_DeleteTable.Click += new System.EventHandler(this.button_DeleteTable_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.FlatAppearance.BorderSize = 2;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Raavi", 12F);
            this.button1.Location = new System.Drawing.Point(217, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(369, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Подключение к серверу";
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_DeleteTable);
            this.Controls.Add(this.button_NewGym);
            this.Controls.Add(this.button_NewStuff);
            this.Name = "FormPanel";
            this.Text = "Панель Администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_NewStuff;
        private System.Windows.Forms.Button button_NewGym;
        private System.Windows.Forms.Button button_DeleteTable;
        private System.Windows.Forms.Button button1;
    }
}