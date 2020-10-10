namespace ProjectStart
{
    partial class FormParking
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
            this.buttonParkMilShip = new System.Windows.Forms.Button();
            this.buttonParkCruiser = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonTakeShip = new System.Windows.Forms.Button();
            this.LabelPlace = new System.Windows.Forms.Label();
            this.maskedTextBoxNumberPlace = new System.Windows.Forms.MaskedTextBox();
            this.labelTakeShip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(1, -1);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(853, 564);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonParkMilShip
            // 
            this.buttonParkMilShip.Location = new System.Drawing.Point(860, 10);
            this.buttonParkMilShip.Name = "buttonParkMilShip";
            this.buttonParkMilShip.Size = new System.Drawing.Size(110, 48);
            this.buttonParkMilShip.TabIndex = 1;
            this.buttonParkMilShip.Text = "Причалить военный корабль";
            this.buttonParkMilShip.UseVisualStyleBackColor = true;
            this.buttonParkMilShip.Click += new System.EventHandler(this.buttonSetMilShip_Click);
            // 
            // buttonParkCruiser
            // 
            this.buttonParkCruiser.Location = new System.Drawing.Point(860, 64);
            this.buttonParkCruiser.Name = "buttonParkCruiser";
            this.buttonParkCruiser.Size = new System.Drawing.Size(109, 53);
            this.buttonParkCruiser.TabIndex = 2;
            this.buttonParkCruiser.Text = "Причалить крейсер";
            this.buttonParkCruiser.UseVisualStyleBackColor = true;
            this.buttonParkCruiser.Click += new System.EventHandler(this.buttonSetCruiser_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonTakeShip);
            this.groupBox1.Controls.Add(this.LabelPlace);
            this.groupBox1.Controls.Add(this.maskedTextBoxNumberPlace);
            this.groupBox1.Controls.Add(this.labelTakeShip);
            this.groupBox1.Location = new System.Drawing.Point(860, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 103);
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
            this.labelTakeShip.Location = new System.Drawing.Point(-3, 0);
            this.labelTakeShip.Name = "labelTakeShip";
            this.labelTakeShip.Size = new System.Drawing.Size(94, 13);
            this.labelTakeShip.TabIndex = 0;
            this.labelTakeShip.Text = "Забрать корабль";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonParkCruiser);
            this.Controls.Add(this.buttonParkMilShip);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonParkMilShip;
        private System.Windows.Forms.Button buttonParkCruiser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelTakeShip;
        private System.Windows.Forms.Button buttonTakeShip;
        private System.Windows.Forms.Label LabelPlace;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxNumberPlace;
    }
}