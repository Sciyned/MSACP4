/*  Program:        
    Author:         Mike Chiu
    Class:          CISP41
    Date:           
    Description: 

    I certify that the code below is my own work.
 
 Exception(s): N/A

*/

namespace Project4
{
	partial class AboutMainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(75, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(221, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Application Name: Payroll Application";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(75, 83);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(221, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Programmers: Mike Chiu, Oscar Campos";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(75, 158);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(221, 59);
			this.label3.TabIndex = 2;
			this.label3.Text = "Description: Payroll Application is a user-friendly way to update and get employe" +
			"e payroll information.";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(75, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(181, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Version: 1.0.0.0";
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(150, 266);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 4;
			this.exitButton.Text = "E&xit";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// AboutMainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(373, 315);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "AboutMainForm";
			this.Text = "About";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}
