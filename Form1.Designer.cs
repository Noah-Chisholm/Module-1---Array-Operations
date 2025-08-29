namespace Module_1___Array_Operations
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
			this.lblClassSize = new System.Windows.Forms.Label();
			this.numClassSize = new System.Windows.Forms.NumericUpDown();
			this.numMaxGrade = new System.Windows.Forms.NumericUpDown();
			this.lblMaximumGrade = new System.Windows.Forms.Label();
			this.lstGrades = new System.Windows.Forms.ListBox();
			this.lblMostCommonGrade = new System.Windows.Forms.Label();
			this.lblNumTimes = new System.Windows.Forms.Label();
			this.lblCommonGradeOut = new System.Windows.Forms.Label();
			this.lblNumTimesOut = new System.Windows.Forms.Label();
			this.bntPopulateGrades = new System.Windows.Forms.Button();
			this.btnReset = new System.Windows.Forms.Button();
			this.lblCopy = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.numClassSize)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxGrade)).BeginInit();
			this.SuspendLayout();
			// 
			// lblClassSize
			// 
			this.lblClassSize.AutoSize = true;
			this.lblClassSize.Location = new System.Drawing.Point(12, 9);
			this.lblClassSize.Name = "lblClassSize";
			this.lblClassSize.Size = new System.Drawing.Size(61, 13);
			this.lblClassSize.TabIndex = 0;
			this.lblClassSize.Text = "Class Size: ";
			// 
			// numClassSize
			// 
			this.numClassSize.Location = new System.Drawing.Point(101, 2);
			this.numClassSize.Name = "numClassSize";
			this.numClassSize.Size = new System.Drawing.Size(120, 20);
			this.numClassSize.TabIndex = 1;
			this.numClassSize.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
			// 
			// numMaxGrade
			// 
			this.numMaxGrade.Location = new System.Drawing.Point(101, 35);
			this.numMaxGrade.Name = "numMaxGrade";
			this.numMaxGrade.Size = new System.Drawing.Size(120, 20);
			this.numMaxGrade.TabIndex = 3;
			this.numMaxGrade.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// lblMaximumGrade
			// 
			this.lblMaximumGrade.AutoSize = true;
			this.lblMaximumGrade.Location = new System.Drawing.Point(12, 37);
			this.lblMaximumGrade.Name = "lblMaximumGrade";
			this.lblMaximumGrade.Size = new System.Drawing.Size(86, 13);
			this.lblMaximumGrade.TabIndex = 2;
			this.lblMaximumGrade.Text = "Maximum Grade:";
			// 
			// lstGrades
			// 
			this.lstGrades.FormattingEnabled = true;
			this.lstGrades.Location = new System.Drawing.Point(227, 2);
			this.lstGrades.Name = "lstGrades";
			this.lstGrades.Size = new System.Drawing.Size(120, 95);
			this.lstGrades.TabIndex = 5;
			// 
			// lblMostCommonGrade
			// 
			this.lblMostCommonGrade.AutoSize = true;
			this.lblMostCommonGrade.Location = new System.Drawing.Point(12, 58);
			this.lblMostCommonGrade.Name = "lblMostCommonGrade";
			this.lblMostCommonGrade.Size = new System.Drawing.Size(109, 13);
			this.lblMostCommonGrade.TabIndex = 6;
			this.lblMostCommonGrade.Text = "Most Common Grade:";
			// 
			// lblNumTimes
			// 
			this.lblNumTimes.AutoSize = true;
			this.lblNumTimes.Location = new System.Drawing.Point(12, 71);
			this.lblNumTimes.Name = "lblNumTimes";
			this.lblNumTimes.Size = new System.Drawing.Size(90, 13);
			this.lblNumTimes.TabIndex = 7;
			this.lblNumTimes.Text = "Number of Times:";
			// 
			// lblCommonGradeOut
			// 
			this.lblCommonGradeOut.AutoSize = true;
			this.lblCommonGradeOut.Location = new System.Drawing.Point(127, 58);
			this.lblCommonGradeOut.Name = "lblCommonGradeOut";
			this.lblCommonGradeOut.Size = new System.Drawing.Size(0, 13);
			this.lblCommonGradeOut.TabIndex = 8;
			// 
			// lblNumTimesOut
			// 
			this.lblNumTimesOut.AutoSize = true;
			this.lblNumTimesOut.Location = new System.Drawing.Point(108, 71);
			this.lblNumTimesOut.Name = "lblNumTimesOut";
			this.lblNumTimesOut.Size = new System.Drawing.Size(0, 13);
			this.lblNumTimesOut.TabIndex = 9;
			// 
			// bntPopulateGrades
			// 
			this.bntPopulateGrades.ForeColor = System.Drawing.SystemColors.ControlText;
			this.bntPopulateGrades.Location = new System.Drawing.Point(15, 89);
			this.bntPopulateGrades.Name = "bntPopulateGrades";
			this.bntPopulateGrades.Size = new System.Drawing.Size(112, 23);
			this.bntPopulateGrades.TabIndex = 10;
			this.bntPopulateGrades.Text = "Populate Grades";
			this.bntPopulateGrades.UseVisualStyleBackColor = true;
			this.bntPopulateGrades.Click += new System.EventHandler(this.bntPopulateGrades_Click);
			// 
			// btnReset
			// 
			this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
			this.btnReset.Location = new System.Drawing.Point(133, 89);
			this.btnReset.Name = "btnReset";
			this.btnReset.Size = new System.Drawing.Size(88, 23);
			this.btnReset.TabIndex = 11;
			this.btnReset.Text = "Reset";
			this.btnReset.UseVisualStyleBackColor = true;
			this.btnReset.Click += new System.EventHandler(this.Reset);
			// 
			// lblCopy
			// 
			this.lblCopy.Location = new System.Drawing.Point(111, 218);
			this.lblCopy.Name = "lblCopy";
			this.lblCopy.Size = new System.Drawing.Size(100, 20);
			this.lblCopy.TabIndex = 12;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(788, 500);
			this.Controls.Add(this.lblCopy);
			this.Controls.Add(this.btnReset);
			this.Controls.Add(this.bntPopulateGrades);
			this.Controls.Add(this.lblNumTimesOut);
			this.Controls.Add(this.lblCommonGradeOut);
			this.Controls.Add(this.lblNumTimes);
			this.Controls.Add(this.lblMostCommonGrade);
			this.Controls.Add(this.lstGrades);
			this.Controls.Add(this.numMaxGrade);
			this.Controls.Add(this.lblMaximumGrade);
			this.Controls.Add(this.numClassSize);
			this.Controls.Add(this.lblClassSize);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.numClassSize)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numMaxGrade)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblClassSize;
		private System.Windows.Forms.NumericUpDown numClassSize;
		private System.Windows.Forms.NumericUpDown numMaxGrade;
		private System.Windows.Forms.Label lblMaximumGrade;
		private System.Windows.Forms.ListBox lstGrades;
		private System.Windows.Forms.Label lblMostCommonGrade;
		private System.Windows.Forms.Label lblNumTimes;
		private System.Windows.Forms.Label lblCommonGradeOut;
		private System.Windows.Forms.Label lblNumTimesOut;
		private System.Windows.Forms.Button bntPopulateGrades;
		private System.Windows.Forms.Button btnReset;
		private System.Windows.Forms.TextBox lblCopy;
	}
}

