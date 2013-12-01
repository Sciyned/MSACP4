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
	partial class EditHelp
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
			this.exitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(53, 29);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(180, 73);
			this.label1.TabIndex = 0;
			this.label1.Text = "Employee information can be updated and will show all old values, just in case th" +
			"e user wishes to see what exactly they are changing.";
			// 
			// exitButton
			// 
			this.exitButton.Location = new System.Drawing.Point(101, 184);
			this.exitButton.Name = "exitButton";
			this.exitButton.Size = new System.Drawing.Size(75, 23);
			this.exitButton.TabIndex = 1;
			this.exitButton.Text = "&Close";
			this.exitButton.UseVisualStyleBackColor = true;
			this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// EditHelp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.exitButton);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "EditHelp";
			this.Text = "EditHelp";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Label label1;
	}
}
