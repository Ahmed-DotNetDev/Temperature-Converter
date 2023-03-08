namespace temperature_converter
{
	partial class Form1
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
			this.btnconvert = new System.Windows.Forms.Button();
			this.lblcelsius = new System.Windows.Forms.TextBox();
			this.lblfahrenheit = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnconvert
			// 
			this.btnconvert.BackColor = System.Drawing.Color.Violet;
			this.btnconvert.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnconvert.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnconvert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.btnconvert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
			this.btnconvert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnconvert.Location = new System.Drawing.Point(242, 195);
			this.btnconvert.Name = "btnconvert";
			this.btnconvert.Size = new System.Drawing.Size(188, 37);
			this.btnconvert.TabIndex = 0;
			this.btnconvert.Text = "Convert";
			this.btnconvert.UseVisualStyleBackColor = false;
			this.btnconvert.Click += new System.EventHandler(this.btnconvert_Click);
			// 
			// lblcelsius
			// 
			this.lblcelsius.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.lblcelsius.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblcelsius.Location = new System.Drawing.Point(242, 110);
			this.lblcelsius.Name = "lblcelsius";
			this.lblcelsius.Size = new System.Drawing.Size(188, 26);
			this.lblcelsius.TabIndex = 1;
			// 
			// lblfahrenheit
			// 
			this.lblfahrenheit.BackColor = System.Drawing.SystemColors.ScrollBar;
			this.lblfahrenheit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblfahrenheit.Location = new System.Drawing.Point(242, 287);
			this.lblfahrenheit.Name = "lblfahrenheit";
			this.lblfahrenheit.Size = new System.Drawing.Size(188, 26);
			this.lblfahrenheit.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.label1.Location = new System.Drawing.Point(92, 106);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 24);
			this.label1.TabIndex = 3;
			this.label1.Text = "Celsius";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
			this.label2.Location = new System.Drawing.Point(92, 287);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 24);
			this.label2.TabIndex = 4;
			this.label2.Text = "Fahrenheit";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(175, 21);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(357, 42);
			this.label3.TabIndex = 5;
			this.label3.Text = "Celsius to Fahrenheit";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox1.Image = global::temperature_converter.Properties.Resources._52_521784_small_png_close_button_icon;
			this.pictureBox1.Location = new System.Drawing.Point(612, 270);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(48, 43);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.ClientSize = new System.Drawing.Size(707, 369);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblfahrenheit);
			this.Controls.Add(this.lblcelsius);
			this.Controls.Add(this.btnconvert);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnconvert;
		private System.Windows.Forms.TextBox lblcelsius;
		private System.Windows.Forms.TextBox lblfahrenheit;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}

