namespace ProjectStart
{
    partial class FormShipConfig
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
            this.groupBoxParameters = new System.Windows.Forms.GroupBox();
            this.checkBoxControlSystem = new System.Windows.Forms.CheckBox();
            this.checkBoxAntiaircraft = new System.Windows.Forms.CheckBox();
            this.checkBoxMissleSystem = new System.Windows.Forms.CheckBox();
            this.numericUpDownWeight = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMaxSpeed = new System.Windows.Forms.NumericUpDown();
            this.labelWeidth = new System.Windows.Forms.Label();
            this.labelMaxSpeed = new System.Windows.Forms.Label();
            this.pictureBoxShip = new System.Windows.Forms.PictureBox();
            this.groupBoxTypeShip = new System.Windows.Forms.GroupBox();
            this.labelCruiser = new System.Windows.Forms.Label();
            this.labelMilShip = new System.Windows.Forms.Label();
            this.panelShip = new System.Windows.Forms.Panel();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelColorYellow = new System.Windows.Forms.Panel();
            this.panelColorGreen = new System.Windows.Forms.Panel();
            this.panelColorFuchsia = new System.Windows.Forms.Panel();
            this.panelColorAqua = new System.Windows.Forms.Panel();
            this.panelColorBlue = new System.Windows.Forms.Panel();
            this.panelColorRed = new System.Windows.Forms.Panel();
            this.panelColorWhite = new System.Windows.Forms.Panel();
            this.panelColorBlack = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.groupBoxParameters.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).BeginInit();
            this.groupBoxTypeShip.SuspendLayout();
            this.panelShip.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxParameters
            // 
            this.groupBoxParameters.Controls.Add(this.checkBoxControlSystem);
            this.groupBoxParameters.Controls.Add(this.checkBoxAntiaircraft);
            this.groupBoxParameters.Controls.Add(this.checkBoxMissleSystem);
            this.groupBoxParameters.Controls.Add(this.numericUpDownWeight);
            this.groupBoxParameters.Controls.Add(this.numericUpDownMaxSpeed);
            this.groupBoxParameters.Controls.Add(this.labelWeidth);
            this.groupBoxParameters.Controls.Add(this.labelMaxSpeed);
            this.groupBoxParameters.Location = new System.Drawing.Point(109, 258);
            this.groupBoxParameters.Name = "groupBoxParameters";
            this.groupBoxParameters.Size = new System.Drawing.Size(336, 177);
            this.groupBoxParameters.TabIndex = 0;
            this.groupBoxParameters.TabStop = false;
            this.groupBoxParameters.Text = "Параметры";
            // 
            // checkBoxControlSystem
            // 
            this.checkBoxControlSystem.AutoSize = true;
            this.checkBoxControlSystem.Location = new System.Drawing.Point(179, 136);
            this.checkBoxControlSystem.Name = "checkBoxControlSystem";
            this.checkBoxControlSystem.Size = new System.Drawing.Size(119, 17);
            this.checkBoxControlSystem.TabIndex = 6;
            this.checkBoxControlSystem.Text = "управление огнём";
            this.checkBoxControlSystem.UseVisualStyleBackColor = true;
            // 
            // checkBoxAntiaircraft
            // 
            this.checkBoxAntiaircraft.AutoSize = true;
            this.checkBoxAntiaircraft.Location = new System.Drawing.Point(179, 90);
            this.checkBoxAntiaircraft.Name = "checkBoxAntiaircraft";
            this.checkBoxAntiaircraft.Size = new System.Drawing.Size(128, 17);
            this.checkBoxAntiaircraft.TabIndex = 5;
            this.checkBoxAntiaircraft.Text = "зенитный комплекс";
            this.checkBoxAntiaircraft.UseVisualStyleBackColor = true;
            // 
            // checkBoxMissleSystem
            // 
            this.checkBoxMissleSystem.AutoSize = true;
            this.checkBoxMissleSystem.Location = new System.Drawing.Point(179, 41);
            this.checkBoxMissleSystem.Name = "checkBoxMissleSystem";
            this.checkBoxMissleSystem.Size = new System.Drawing.Size(119, 17);
            this.checkBoxMissleSystem.TabIndex = 4;
            this.checkBoxMissleSystem.Text = "ракетная система";
            this.checkBoxMissleSystem.UseVisualStyleBackColor = true;
            // 
            // numericUpDownWeight
            // 
            this.numericUpDownWeight.Location = new System.Drawing.Point(59, 136);
            this.numericUpDownWeight.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownWeight.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownWeight.Name = "numericUpDownWeight";
            this.numericUpDownWeight.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownWeight.TabIndex = 3;
            this.numericUpDownWeight.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownMaxSpeed
            // 
            this.numericUpDownMaxSpeed.Location = new System.Drawing.Point(59, 67);
            this.numericUpDownMaxSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMaxSpeed.Name = "numericUpDownMaxSpeed";
            this.numericUpDownMaxSpeed.Size = new System.Drawing.Size(65, 20);
            this.numericUpDownMaxSpeed.TabIndex = 2;
            this.numericUpDownMaxSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // labelWeidth
            // 
            this.labelWeidth.AutoSize = true;
            this.labelWeidth.Location = new System.Drawing.Point(34, 108);
            this.labelWeidth.Name = "labelWeidth";
            this.labelWeidth.Size = new System.Drawing.Size(71, 13);
            this.labelWeidth.TabIndex = 1;
            this.labelWeidth.Text = "Вес корабля";
            // 
            // labelMaxSpeed
            // 
            this.labelMaxSpeed.AutoSize = true;
            this.labelMaxSpeed.Location = new System.Drawing.Point(34, 41);
            this.labelMaxSpeed.Name = "labelMaxSpeed";
            this.labelMaxSpeed.Size = new System.Drawing.Size(90, 13);
            this.labelMaxSpeed.TabIndex = 0;
            this.labelMaxSpeed.Text = "Макс. скорость:";
            // 
            // pictureBoxShip
            // 
            this.pictureBoxShip.Location = new System.Drawing.Point(14, 24);
            this.pictureBoxShip.Name = "pictureBoxShip";
            this.pictureBoxShip.Size = new System.Drawing.Size(247, 182);
            this.pictureBoxShip.TabIndex = 1;
            this.pictureBoxShip.TabStop = false;
            // 
            // groupBoxTypeShip
            // 
            this.groupBoxTypeShip.Controls.Add(this.labelCruiser);
            this.groupBoxTypeShip.Controls.Add(this.labelMilShip);
            this.groupBoxTypeShip.Location = new System.Drawing.Point(30, 47);
            this.groupBoxTypeShip.Name = "groupBoxTypeShip";
            this.groupBoxTypeShip.Size = new System.Drawing.Size(200, 182);
            this.groupBoxTypeShip.TabIndex = 2;
            this.groupBoxTypeShip.TabStop = false;
            this.groupBoxTypeShip.Text = "Тип корабля";
            // 
            // labelCruiser
            // 
            this.labelCruiser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCruiser.Location = new System.Drawing.Point(25, 108);
            this.labelCruiser.Name = "labelCruiser";
            this.labelCruiser.Size = new System.Drawing.Size(140, 40);
            this.labelCruiser.TabIndex = 1;
            this.labelCruiser.Text = "Крейсер";
            this.labelCruiser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCruiser.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCruiser_MouseDown);
            // 
            // labelMilShip
            // 
            this.labelMilShip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMilShip.Location = new System.Drawing.Point(25, 39);
            this.labelMilShip.Name = "labelMilShip";
            this.labelMilShip.Size = new System.Drawing.Size(140, 40);
            this.labelMilShip.TabIndex = 0;
            this.labelMilShip.Text = "Военный корабль";
            this.labelMilShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMilShip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelMilShip_MouseDown);
            // 
            // panelShip
            // 
            this.panelShip.AllowDrop = true;
            this.panelShip.Controls.Add(this.pictureBoxShip);
            this.panelShip.Location = new System.Drawing.Point(246, 12);
            this.panelShip.Name = "panelShip";
            this.panelShip.Size = new System.Drawing.Size(278, 226);
            this.panelShip.TabIndex = 3;
            this.panelShip.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelShip_DragDrop);
            this.panelShip.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelShip_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelColorYellow);
            this.groupBoxColor.Controls.Add(this.panelColorGreen);
            this.groupBoxColor.Controls.Add(this.panelColorFuchsia);
            this.groupBoxColor.Controls.Add(this.panelColorAqua);
            this.groupBoxColor.Controls.Add(this.panelColorBlue);
            this.groupBoxColor.Controls.Add(this.panelColorRed);
            this.groupBoxColor.Controls.Add(this.panelColorWhite);
            this.groupBoxColor.Controls.Add(this.panelColorBlack);
            this.groupBoxColor.Controls.Add(this.labelDopColor);
            this.groupBoxColor.Controls.Add(this.labelMainColor);
            this.groupBoxColor.Location = new System.Drawing.Point(571, 23);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(281, 231);
            this.groupBoxColor.TabIndex = 4;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Цвета";
            // 
            // panelColorYellow
            // 
            this.panelColorYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelColorYellow.Location = new System.Drawing.Point(27, 165);
            this.panelColorYellow.Name = "panelColorYellow";
            this.panelColorYellow.Size = new System.Drawing.Size(50, 50);
            this.panelColorYellow.TabIndex = 3;
            // 
            // panelColorGreen
            // 
            this.panelColorGreen.BackColor = System.Drawing.Color.Green;
            this.panelColorGreen.Location = new System.Drawing.Point(83, 165);
            this.panelColorGreen.Name = "panelColorGreen";
            this.panelColorGreen.Size = new System.Drawing.Size(50, 50);
            this.panelColorGreen.TabIndex = 3;
            // 
            // panelColorFuchsia
            // 
            this.panelColorFuchsia.BackColor = System.Drawing.Color.Fuchsia;
            this.panelColorFuchsia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelColorFuchsia.Location = new System.Drawing.Point(149, 165);
            this.panelColorFuchsia.Name = "panelColorFuchsia";
            this.panelColorFuchsia.Size = new System.Drawing.Size(50, 50);
            this.panelColorFuchsia.TabIndex = 3;
            // 
            // panelColorAqua
            // 
            this.panelColorAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelColorAqua.Location = new System.Drawing.Point(205, 165);
            this.panelColorAqua.Name = "panelColorAqua";
            this.panelColorAqua.Size = new System.Drawing.Size(50, 50);
            this.panelColorAqua.TabIndex = 3;
            // 
            // panelColorBlue
            // 
            this.panelColorBlue.BackColor = System.Drawing.Color.Blue;
            this.panelColorBlue.Location = new System.Drawing.Point(205, 92);
            this.panelColorBlue.Name = "panelColorBlue";
            this.panelColorBlue.Size = new System.Drawing.Size(50, 50);
            this.panelColorBlue.TabIndex = 4;
            // 
            // panelColorRed
            // 
            this.panelColorRed.BackColor = System.Drawing.Color.Red;
            this.panelColorRed.Location = new System.Drawing.Point(149, 92);
            this.panelColorRed.Name = "panelColorRed";
            this.panelColorRed.Size = new System.Drawing.Size(50, 50);
            this.panelColorRed.TabIndex = 3;
            // 
            // panelColorWhite
            // 
            this.panelColorWhite.BackColor = System.Drawing.Color.White;
            this.panelColorWhite.Location = new System.Drawing.Point(83, 92);
            this.panelColorWhite.Name = "panelColorWhite";
            this.panelColorWhite.Size = new System.Drawing.Size(50, 50);
            this.panelColorWhite.TabIndex = 3;
            // 
            // panelColorBlack
            // 
            this.panelColorBlack.BackColor = System.Drawing.Color.Black;
            this.panelColorBlack.Location = new System.Drawing.Point(27, 92);
            this.panelColorBlack.Name = "panelColorBlack";
            this.panelColorBlack.Size = new System.Drawing.Size(50, 50);
            this.panelColorBlack.TabIndex = 2;
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(155, 24);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(100, 35);
            this.labelDopColor.TabIndex = 1;
            this.labelDopColor.Text = "Доп. цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(27, 24);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(100, 35);
            this.labelMainColor.TabIndex = 0;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelBaseColor_DragEnter);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(751, 299);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 40);
            this.buttonAdd.TabIndex = 5;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(751, 361);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 40);
            this.buttonCancel.TabIndex = 6;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormShipConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 454);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelShip);
            this.Controls.Add(this.groupBoxTypeShip);
            this.Controls.Add(this.groupBoxParameters);
            this.Name = "FormShipConfig";
            this.Text = "FormShipConfig";
            this.groupBoxParameters.ResumeLayout(false);
            this.groupBoxParameters.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownWeight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShip)).EndInit();
            this.groupBoxTypeShip.ResumeLayout(false);
            this.panelShip.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxParameters;
        private System.Windows.Forms.Label labelWeidth;
        private System.Windows.Forms.Label labelMaxSpeed;
        private System.Windows.Forms.NumericUpDown numericUpDownWeight;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxSpeed;
        private System.Windows.Forms.CheckBox checkBoxControlSystem;
        private System.Windows.Forms.CheckBox checkBoxAntiaircraft;
        private System.Windows.Forms.CheckBox checkBoxMissleSystem;
        private System.Windows.Forms.PictureBox pictureBoxShip;
        private System.Windows.Forms.GroupBox groupBoxTypeShip;
        private System.Windows.Forms.Label labelCruiser;
        private System.Windows.Forms.Label labelMilShip;
        private System.Windows.Forms.Panel panelShip;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelColorYellow;
        private System.Windows.Forms.Panel panelColorGreen;
        private System.Windows.Forms.Panel panelColorFuchsia;
        private System.Windows.Forms.Panel panelColorAqua;
        private System.Windows.Forms.Panel panelColorBlue;
        private System.Windows.Forms.Panel panelColorRed;
        private System.Windows.Forms.Panel panelColorWhite;
        private System.Windows.Forms.Panel panelColorBlack;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}