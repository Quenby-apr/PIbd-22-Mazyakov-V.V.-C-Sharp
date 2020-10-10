namespace ProjectStart
{
	partial class FormCruiser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCruiser));
            this.pictureBoxCruiser = new System.Windows.Forms.PictureBox();
            this.buttonCreateMilShip = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonCreateCruiser = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCruiser)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCruiser
            // 
            this.pictureBoxCruiser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxCruiser.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxCruiser.Name = "pictureBoxCruiser";
            this.pictureBoxCruiser.Size = new System.Drawing.Size(984, 561);
            this.pictureBoxCruiser.TabIndex = 0;
            this.pictureBoxCruiser.TabStop = false;
            // 
            // buttonCreateMilShip
            // 
            this.buttonCreateMilShip.Location = new System.Drawing.Point(12, 12);
            this.buttonCreateMilShip.Name = "buttonCreateMilShip";
            this.buttonCreateMilShip.Size = new System.Drawing.Size(175, 23);
            this.buttonCreateMilShip.TabIndex = 1;
            this.buttonCreateMilShip.Text = "Создать военный корабль";
            this.buttonCreateMilShip.UseVisualStyleBackColor = true;
            this.buttonCreateMilShip.Click += new System.EventHandler(this.buttonCreateMilShip_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(870, 522);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 2;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(906, 522);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 3;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(942, 522);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 4;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(906, 486);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 5;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonCreateCruiser
            // 
            this.buttonCreateCruiser.Location = new System.Drawing.Point(210, 12);
            this.buttonCreateCruiser.Name = "buttonCreateCruiser";
            this.buttonCreateCruiser.Size = new System.Drawing.Size(175, 23);
            this.buttonCreateCruiser.TabIndex = 6;
            this.buttonCreateCruiser.Text = "Создать крейсер";
            this.buttonCreateCruiser.UseVisualStyleBackColor = true;
            this.buttonCreateCruiser.Click += new System.EventHandler(this.buttonCreateCruiser_Click);
            // 
            // FormCruiser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 561);
            this.Controls.Add(this.buttonCreateCruiser);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonCreateMilShip);
            this.Controls.Add(this.pictureBoxCruiser);
            this.Name = "FormCruiser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Крейсер";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCruiser)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBoxCruiser;
		private System.Windows.Forms.Button buttonCreateMilShip;
		private System.Windows.Forms.Button buttonLeft;
		private System.Windows.Forms.Button buttonDown;
		private System.Windows.Forms.Button buttonRight;
		private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonCreateCruiser;
    }
}

