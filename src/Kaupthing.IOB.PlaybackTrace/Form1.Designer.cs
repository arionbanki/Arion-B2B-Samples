namespace Kaupthing.IOB.PlaybackTrace
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
			this.IOBUrlTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// IOBUrlTextBox
			// 
			this.IOBUrlTextBox.Location = new System.Drawing.Point(12, 26);
			this.IOBUrlTextBox.Name = "IOBUrlTextBox";
			this.IOBUrlTextBox.Size = new System.Drawing.Size(655, 20);
			this.IOBUrlTextBox.TabIndex = 11;
			this.IOBUrlTextBox.Text = global::Kaupthing.IOB.PlaybackTrace.Properties.Settings.Default.Kaupthing_IOB_PlaybackTrace_StatementsService_IcelandicOnlineBankingStatementsService;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(9, 10);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(94, 13);
			this.label4.TabIndex = 12;
			this.label4.Text = "Web Service URL";
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Xml files|*.xml|All files|*.*";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 52);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "Browse";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(12, 81);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.textBox1.Size = new System.Drawing.Size(655, 424);
			this.textBox1.TabIndex = 14;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(592, 511);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(75, 23);
			this.button2.TabIndex = 15;
			this.button2.Text = "Send";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.SendButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(682, 563);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.IOBUrlTextBox);
			this.Controls.Add(this.label4);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox IOBUrlTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button2;
	}
}

