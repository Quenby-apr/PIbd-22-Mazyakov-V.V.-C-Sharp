namespace ProjectStart
{
    partial class FormDocks
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.buttonParkShip = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            this.LabelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxNumberPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelTakeShip = new System.Windows.Forms.Label();
            this.listBoxDocks = new System.Windows.Forms.ListBox();
            this.labelParking = new System.Windows.Forms.Label();
            this.textBoxNewLevelName = new System.Windows.Forms.TextBox();
            this.buttonCreateParking = new System.Windows.Forms.Button();
            this.buttonDeleteParking = new System.Windows.Forms.Button();
            this.menuStripDocks = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialogDocks = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialogDocks = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.menuStripDocks.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 27);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(853, 536);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkShip
            // 
            this.buttonParkShip.Location = new System.Drawing.Point(863, 286);
            this.buttonParkShip.Name = "buttonParkShip";
            this.buttonParkShip.Size = new System.Drawing.Size(118, 48);
            this.buttonParkShip.TabIndex = 1;
            this.buttonParkShip.Text = "Причалить корабль";
            this.buttonParkShip.UseVisualStyleBackColor = true;
            this.buttonParkShip.Click += new System.EventHandler(this.buttonSetMilShip_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeShip);
            this.groupBox1.Controls.Add(this.LabelPlace);
            this.groupBox1.Controls.Add(this.maskedTextBoxNumberPlace);
            this.groupBox1.Controls.Add(this.labelTakeShip);
            this.groupBox1.Location = new System.Drawing.Point(860, 382);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 101);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // buttonTakeShip
            // 
            this.buttonTakeShip.Location = new System.Drawing.Point(16, 62);
            this.buttonTakeShip.Name = "buttonTakeShip";
            this.buttonTakeShip.Size = new System.Drawing.Size(75, 23);
            this.buttonTakeShip.TabIndex = 3;
            this.buttonTakeShip.Text = "Забрать";
            this.buttonTakeShip.UseVisualStyleBackColor = true;
            this.buttonTakeShip.Click += new System.EventHandler(this.buttonTakeShip_Click);
            // 
            // LabelPlace
            // 
            this.LabelPlace.AutoSize = true;
            this.LabelPlace.Location = new System.Drawing.Point(0, 26);
            this.LabelPlace.Name = "LabelPlace";
            this.LabelPlace.Size = new System.Drawing.Size(41, 13);
            this.LabelPlace.TabIndex = 2;
            this.LabelPlace.Text = "место:";
            // 
            // maskedTextBoxNumberPlace
            // 
            this.maskedTextBoxNumberPlace.Location = new System.Drawing.Point(47, 23);
            this.maskedTextBoxNumberPlace.Name = "maskedTextBoxNumberPlace";
            this.maskedTextBoxNumberPlace.Size = new System.Drawing.Size(49, 20);
            this.maskedTextBoxNumberPlace.TabIndex = 1;
            // 
            // labelTakeShip
            // 
            this.labelTakeShip.AutoSize = true;
            this.labelTakeShip.Location = new System.Drawing.Point(0, 0);
            this.labelTakeShip.Name = "labelTakeShip";
            this.labelTakeShip.Size = new System.Drawing.Size(94, 13);
            this.labelTakeShip.TabIndex = 0;
            this.labelTakeShip.Text = "Забрать корабль";
            // 
            // listBoxDocks
            // 
            this.listBoxDocks.FormattingEnabled = true;
            this.listBoxDocks.Location = new System.Drawing.Point(863, 109);
            this.listBoxDocks.Name = "listBoxDocks";
            this.listBoxDocks.Size = new System.Drawing.Size(118, 95);
            this.listBoxDocks.TabIndex = 4;
            this.listBoxDocks.SelectedIndexChanged += new System.EventHandler(this.listBoxParkings_SelectedIndexChanged);
            // 
            // labelParking
            // 
            this.labelParking.AutoSize = true;
            this.labelParking.Location = new System.Drawing.Point(896, 9);
            this.labelParking.Name = "labelParking";
            this.labelParking.Size = new System.Drawing.Size(37, 13);
            this.labelParking.TabIndex = 5;
            this.labelParking.Text = "Доки:";
            // 
            // textBoxNewLevelName
            // 
            this.textBoxNewLevelName.Location = new System.Drawing.Point(863, 34);
            this.textBoxNewLevelName.Name = "textBoxNewLevelName";
            this.textBoxNewLevelName.Size = new System.Drawing.Size(118, 20);
            this.textBoxNewLevelName.TabIndex = 6;
            // 
            // buttonCreateParking
            // 
            this.buttonCreateParking.Location = new System.Drawing.Point(863, 60);
            this.buttonCreateParking.Name = "buttonCreateParking";
            this.buttonCreateParking.Size = new System.Drawing.Size(118, 35);
            this.buttonCreateParking.TabIndex = 7;
            this.buttonCreateParking.Text = "Добавить док";
            this.buttonCreateParking.UseVisualStyleBackColor = true;
            this.buttonCreateParking.Click += new System.EventHandler(this.buttonAddDocks_Click);
            // 
            // buttonDeleteParking
            // 
            this.buttonDeleteParking.Location = new System.Drawing.Point(863, 210);
            this.buttonDeleteParking.Name = "buttonDeleteParking";
            this.buttonDeleteParking.Size = new System.Drawing.Size(118, 35);
            this.buttonDeleteParking.TabIndex = 8;
            this.buttonDeleteParking.Text = "Удалить док";
            this.buttonDeleteParking.UseVisualStyleBackColor = true;
            this.buttonDeleteParking.Click += new System.EventHandler(this.buttonDelDocks_Click);
            // 
            // menuStripDocks
            // 
            this.menuStripDocks.BackColor = System.Drawing.SystemColors.Control;
            this.menuStripDocks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStripDocks.Location = new System.Drawing.Point(0, 0);
            this.menuStripDocks.Name = "menuStripDocks";
            this.menuStripDocks.Size = new System.Drawing.Size(984, 24);
            this.menuStripDocks.TabIndex = 9;
            this.menuStripDocks.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // saveFileDialogDocks
            // 
            this.saveFileDialogDocks.Filter = "«txt file | *.txt";
            // 
            // openFileDialogDocks
            // 
            this.openFileDialogDocks.Filter = "«txt file | *.txt";
            // 
            // FormDocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonDeleteParking);
            this.Controls.Add(this.buttonCreateParking);
            this.Controls.Add(this.textBoxNewLevelName);
            this.Controls.Add(this.labelParking);
            this.Controls.Add(this.listBoxDocks);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonParkShip);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStripDocks);
            this.MainMenuStrip = this.menuStripDocks;
            this.Name = "FormDocks";
            this.Text = "FormDocks";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStripDocks.ResumeLayout(false);
            this.menuStripDocks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkShip;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTakeShip;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.Label LabelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberPlace;
        private System.Windows.Forms.ListBox listBoxDocks;
        private System.Windows.Forms.Label labelParking;
        private System.Windows.Forms.TextBox textBoxNewLevelName;
        private System.Windows.Forms.Button buttonCreateParking;
        private System.Windows.Forms.Button buttonDeleteParking;
        private System.Windows.Forms.MenuStrip menuStripDocks;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialogDocks;
        private System.Windows.Forms.OpenFileDialog openFileDialogDocks;
    }
}