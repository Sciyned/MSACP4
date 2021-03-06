﻿/*  Program:        
    Author:         Mike Chiu
    Class:          CISP41
    Date:           
    Description: 

    I certify that the code below is my own work.
 
 Exception(s): N/A

*/

namespace Project4
{
	partial class EditEmployee
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
			this.basicGroupBox = new System.Windows.Forms.GroupBox();
			this.employeeLastNameTextField = new System.Windows.Forms.TextBox();
			this.employeeFirstNameTextField = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.employmentGroupBox = new System.Windows.Forms.GroupBox();
			this.employeeDepartmentComboBox = new System.Windows.Forms.ComboBox();
			this.employeePositionComboBox = new System.Windows.Forms.ComboBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.deductionsGroupBox = new System.Windows.Forms.GroupBox();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.newFsaTextField = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.fsaCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.newRetirementTextField = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.retirementCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.newLifeInsuranceTextField = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lifeInsuranceCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.newMedicalTextField = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.medicalInsuranceCheckBox = new System.Windows.Forms.CheckBox();
			this.financialGroupBox = new System.Windows.Forms.GroupBox();
			this.newRateTextField = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.hourlyRadioButton = new System.Windows.Forms.RadioButton();
			this.salaryRadioButton = new System.Windows.Forms.RadioButton();
			this.updateButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.basicGroupBox.SuspendLayout();
			this.employmentGroupBox.SuspendLayout();
			this.deductionsGroupBox.SuspendLayout();
			this.groupBox7.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.financialGroupBox.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Select Employee ID:";
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.fileToolStripMenuItem,
									this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(633, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.updateInformationToolStripMenuItem,
									this.toolStripSeparator1,
									this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// updateInformationToolStripMenuItem
			// 
			this.updateInformationToolStripMenuItem.Name = "updateInformationToolStripMenuItem";
			this.updateInformationToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.updateInformationToolStripMenuItem.Text = "&Update Information";
			this.updateInformationToolStripMenuItem.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpToolStripMenuItem1});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(99, 22);
			this.helpToolStripMenuItem1.Text = "&Help";
			this.helpToolStripMenuItem1.Click += new System.EventHandler(this.HelpToolStripMenuItem1Click);
			// 
			// employeeIDComboBox
			// 
			this.employeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.employeeIDComboBox.FormattingEnabled = true;
			this.employeeIDComboBox.Location = new System.Drawing.Point(130, 34);
			this.employeeIDComboBox.Name = "employeeIDComboBox";
			this.employeeIDComboBox.Size = new System.Drawing.Size(145, 21);
			this.employeeIDComboBox.TabIndex = 3;
			this.employeeIDComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeIDComboBoxSelectedIndexChanged);
			// 
			// basicGroupBox
			// 
			this.basicGroupBox.Controls.Add(this.employeeLastNameTextField);
			this.basicGroupBox.Controls.Add(this.employeeFirstNameTextField);
			this.basicGroupBox.Controls.Add(this.label3);
			this.basicGroupBox.Controls.Add(this.label2);
			this.basicGroupBox.Enabled = false;
			this.basicGroupBox.Location = new System.Drawing.Point(12, 64);
			this.basicGroupBox.Name = "basicGroupBox";
			this.basicGroupBox.Size = new System.Drawing.Size(263, 76);
			this.basicGroupBox.TabIndex = 5;
			this.basicGroupBox.TabStop = false;
			this.basicGroupBox.Text = "Basic Information";
			// 
			// employeeLastNameTextField
			// 
			this.employeeLastNameTextField.Location = new System.Drawing.Point(93, 44);
			this.employeeLastNameTextField.Name = "employeeLastNameTextField";
			this.employeeLastNameTextField.Size = new System.Drawing.Size(152, 20);
			this.employeeLastNameTextField.TabIndex = 3;
			// 
			// employeeFirstNameTextField
			// 
			this.employeeFirstNameTextField.Location = new System.Drawing.Point(93, 17);
			this.employeeFirstNameTextField.Name = "employeeFirstNameTextField";
			this.employeeFirstNameTextField.Size = new System.Drawing.Size(152, 20);
			this.employeeFirstNameTextField.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(7, 47);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 1;
			this.label3.Text = "Last Name:";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(7, 20);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 0;
			this.label2.Text = "First Name:";
			// 
			// employmentGroupBox
			// 
			this.employmentGroupBox.Controls.Add(this.employeeDepartmentComboBox);
			this.employmentGroupBox.Controls.Add(this.employeePositionComboBox);
			this.employmentGroupBox.Controls.Add(this.label5);
			this.employmentGroupBox.Controls.Add(this.label4);
			this.employmentGroupBox.Enabled = false;
			this.employmentGroupBox.Location = new System.Drawing.Point(12, 146);
			this.employmentGroupBox.Name = "employmentGroupBox";
			this.employmentGroupBox.Size = new System.Drawing.Size(263, 91);
			this.employmentGroupBox.TabIndex = 6;
			this.employmentGroupBox.TabStop = false;
			this.employmentGroupBox.Text = "Employment Information";
			// 
			// employeeDepartmentComboBox
			// 
			this.employeeDepartmentComboBox.FormattingEnabled = true;
			this.employeeDepartmentComboBox.Items.AddRange(new object[] {
									"HR",
									"Accounting",
									"R&D",
									"Sales",
									"Production"});
			this.employeeDepartmentComboBox.Location = new System.Drawing.Point(93, 51);
			this.employeeDepartmentComboBox.Name = "employeeDepartmentComboBox";
			this.employeeDepartmentComboBox.Size = new System.Drawing.Size(152, 21);
			this.employeeDepartmentComboBox.TabIndex = 4;
			// 
			// employeePositionComboBox
			// 
			this.employeePositionComboBox.FormattingEnabled = true;
			this.employeePositionComboBox.Items.AddRange(new object[] {
									"Manager",
									"Engineer",
									"Technician",
									"Clerk",
									"Producer"});
			this.employeePositionComboBox.Location = new System.Drawing.Point(93, 24);
			this.employeePositionComboBox.Name = "employeePositionComboBox";
			this.employeePositionComboBox.Size = new System.Drawing.Size(152, 21);
			this.employeePositionComboBox.TabIndex = 3;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(7, 54);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 2;
			this.label5.Text = "Department:";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(6, 27);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 1;
			this.label4.Text = "Position:";
			// 
			// deductionsGroupBox
			// 
			this.deductionsGroupBox.Controls.Add(this.groupBox7);
			this.deductionsGroupBox.Controls.Add(this.groupBox6);
			this.deductionsGroupBox.Controls.Add(this.groupBox5);
			this.deductionsGroupBox.Controls.Add(this.groupBox4);
			this.deductionsGroupBox.Enabled = false;
			this.deductionsGroupBox.Location = new System.Drawing.Point(291, 34);
			this.deductionsGroupBox.Name = "deductionsGroupBox";
			this.deductionsGroupBox.Size = new System.Drawing.Size(330, 252);
			this.deductionsGroupBox.TabIndex = 7;
			this.deductionsGroupBox.TabStop = false;
			this.deductionsGroupBox.Text = "Deductions";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.newFsaTextField);
			this.groupBox7.Controls.Add(this.label13);
			this.groupBox7.Controls.Add(this.fsaCheckBox);
			this.groupBox7.Location = new System.Drawing.Point(168, 129);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(155, 110);
			this.groupBox7.TabIndex = 3;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Flexible Spending Account";
			// 
			// newFsaTextField
			// 
			this.newFsaTextField.Enabled = false;
			this.newFsaTextField.Location = new System.Drawing.Point(7, 74);
			this.newFsaTextField.Name = "newFsaTextField";
			this.newFsaTextField.Size = new System.Drawing.Size(133, 20);
			this.newFsaTextField.TabIndex = 4;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(7, 47);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 3;
			this.label13.Text = "Amount:";
			// 
			// fsaCheckBox
			// 
			this.fsaCheckBox.Enabled = false;
			this.fsaCheckBox.Location = new System.Drawing.Point(7, 20);
			this.fsaCheckBox.Name = "fsaCheckBox";
			this.fsaCheckBox.Size = new System.Drawing.Size(104, 24);
			this.fsaCheckBox.TabIndex = 0;
			this.fsaCheckBox.Text = "Have an FSA";
			this.fsaCheckBox.UseVisualStyleBackColor = true;
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.newRetirementTextField);
			this.groupBox6.Controls.Add(this.label11);
			this.groupBox6.Controls.Add(this.retirementCheckBox);
			this.groupBox6.Location = new System.Drawing.Point(6, 129);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(156, 110);
			this.groupBox6.TabIndex = 2;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "401K/Retirement";
			// 
			// newRetirementTextField
			// 
			this.newRetirementTextField.Enabled = false;
			this.newRetirementTextField.Location = new System.Drawing.Point(6, 74);
			this.newRetirementTextField.Name = "newRetirementTextField";
			this.newRetirementTextField.Size = new System.Drawing.Size(135, 20);
			this.newRetirementTextField.TabIndex = 4;
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(6, 47);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 3;
			this.label11.Text = "Amount:";
			// 
			// retirementCheckBox
			// 
			this.retirementCheckBox.Location = new System.Drawing.Point(7, 20);
			this.retirementCheckBox.Name = "retirementCheckBox";
			this.retirementCheckBox.Size = new System.Drawing.Size(104, 24);
			this.retirementCheckBox.TabIndex = 0;
			this.retirementCheckBox.Text = "Have 401K Plan";
			this.retirementCheckBox.UseVisualStyleBackColor = true;
			this.retirementCheckBox.CheckedChanged += new System.EventHandler(this.RetirementCheckBoxCheckedChanged);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.newLifeInsuranceTextField);
			this.groupBox5.Controls.Add(this.label9);
			this.groupBox5.Controls.Add(this.lifeInsuranceCheckBox);
			this.groupBox5.Location = new System.Drawing.Point(169, 20);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(155, 103);
			this.groupBox5.TabIndex = 1;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Life Insurance";
			// 
			// newLifeInsuranceTextField
			// 
			this.newLifeInsuranceTextField.Enabled = false;
			this.newLifeInsuranceTextField.Location = new System.Drawing.Point(6, 70);
			this.newLifeInsuranceTextField.Name = "newLifeInsuranceTextField";
			this.newLifeInsuranceTextField.Size = new System.Drawing.Size(133, 20);
			this.newLifeInsuranceTextField.TabIndex = 4;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(6, 47);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 3;
			this.label9.Text = "Amount:";
			// 
			// lifeInsuranceCheckBox
			// 
			this.lifeInsuranceCheckBox.Enabled = false;
			this.lifeInsuranceCheckBox.Location = new System.Drawing.Point(7, 20);
			this.lifeInsuranceCheckBox.Name = "lifeInsuranceCheckBox";
			this.lifeInsuranceCheckBox.Size = new System.Drawing.Size(104, 24);
			this.lifeInsuranceCheckBox.TabIndex = 0;
			this.lifeInsuranceCheckBox.Text = "Have Insurance";
			this.lifeInsuranceCheckBox.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.newMedicalTextField);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.medicalInsuranceCheckBox);
			this.groupBox4.Location = new System.Drawing.Point(7, 20);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(156, 103);
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Medical/Dental";
			// 
			// newMedicalTextField
			// 
			this.newMedicalTextField.Enabled = false;
			this.newMedicalTextField.Location = new System.Drawing.Point(6, 70);
			this.newMedicalTextField.Name = "newMedicalTextField";
			this.newMedicalTextField.Size = new System.Drawing.Size(135, 20);
			this.newMedicalTextField.TabIndex = 4;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(6, 47);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 3;
			this.label7.Text = "Amount:";
			// 
			// medicalInsuranceCheckBox
			// 
			this.medicalInsuranceCheckBox.Enabled = false;
			this.medicalInsuranceCheckBox.Location = new System.Drawing.Point(7, 20);
			this.medicalInsuranceCheckBox.Name = "medicalInsuranceCheckBox";
			this.medicalInsuranceCheckBox.Size = new System.Drawing.Size(104, 24);
			this.medicalInsuranceCheckBox.TabIndex = 0;
			this.medicalInsuranceCheckBox.Text = "Have Insurance";
			this.medicalInsuranceCheckBox.UseVisualStyleBackColor = true;
			// 
			// financialGroupBox
			// 
			this.financialGroupBox.Controls.Add(this.newRateTextField);
			this.financialGroupBox.Controls.Add(this.label17);
			this.financialGroupBox.Controls.Add(this.hourlyRadioButton);
			this.financialGroupBox.Controls.Add(this.salaryRadioButton);
			this.financialGroupBox.Enabled = false;
			this.financialGroupBox.Location = new System.Drawing.Point(12, 243);
			this.financialGroupBox.Name = "financialGroupBox";
			this.financialGroupBox.Size = new System.Drawing.Size(263, 83);
			this.financialGroupBox.TabIndex = 8;
			this.financialGroupBox.TabStop = false;
			this.financialGroupBox.Text = "Financial Information";
			// 
			// newRateTextField
			// 
			this.newRateTextField.Location = new System.Drawing.Point(95, 46);
			this.newRateTextField.Name = "newRateTextField";
			this.newRateTextField.Size = new System.Drawing.Size(100, 20);
			this.newRateTextField.TabIndex = 10;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(6, 46);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 23);
			this.label17.TabIndex = 9;
			this.label17.Text = "Rate:";
			// 
			// hourlyRadioButton
			// 
			this.hourlyRadioButton.Location = new System.Drawing.Point(93, 19);
			this.hourlyRadioButton.Name = "hourlyRadioButton";
			this.hourlyRadioButton.Size = new System.Drawing.Size(104, 24);
			this.hourlyRadioButton.TabIndex = 2;
			this.hourlyRadioButton.TabStop = true;
			this.hourlyRadioButton.Text = "Hourly";
			this.hourlyRadioButton.UseVisualStyleBackColor = true;
			// 
			// salaryRadioButton
			// 
			this.salaryRadioButton.Location = new System.Drawing.Point(8, 19);
			this.salaryRadioButton.Name = "salaryRadioButton";
			this.salaryRadioButton.Size = new System.Drawing.Size(104, 24);
			this.salaryRadioButton.TabIndex = 1;
			this.salaryRadioButton.TabStop = true;
			this.salaryRadioButton.Text = "Salary";
			this.salaryRadioButton.UseVisualStyleBackColor = true;
			// 
			// updateButton
			// 
			this.updateButton.Location = new System.Drawing.Point(291, 292);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(162, 23);
			this.updateButton.TabIndex = 9;
			this.updateButton.Text = "&Update Employee Information";
			this.updateButton.UseVisualStyleBackColor = true;
			this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Location = new System.Drawing.Point(460, 292);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(154, 23);
			this.cancelButton.TabIndex = 10;
			this.cancelButton.Text = "&Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// EditEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(633, 333);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.updateButton);
			this.Controls.Add(this.financialGroupBox);
			this.Controls.Add(this.deductionsGroupBox);
			this.Controls.Add(this.employmentGroupBox);
			this.Controls.Add(this.basicGroupBox);
			this.Controls.Add(this.employeeIDComboBox);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "EditEmployee";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "EditEmployee";
			this.Load += new System.EventHandler(this.EditEmployee_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.basicGroupBox.ResumeLayout(false);
			this.basicGroupBox.PerformLayout();
			this.employmentGroupBox.ResumeLayout(false);
			this.deductionsGroupBox.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			this.groupBox7.PerformLayout();
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.financialGroupBox.ResumeLayout(false);
			this.financialGroupBox.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem updateInformationToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox newRateTextField;
		private System.Windows.Forms.RadioButton salaryRadioButton;
		private System.Windows.Forms.RadioButton hourlyRadioButton;
		private System.Windows.Forms.GroupBox financialGroupBox;
		private System.Windows.Forms.CheckBox retirementCheckBox;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox newRetirementTextField;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.CheckBox fsaCheckBox;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox newFsaTextField;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.CheckBox lifeInsuranceCheckBox;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox newLifeInsuranceTextField;
		private System.Windows.Forms.CheckBox medicalInsuranceCheckBox;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox newMedicalTextField;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox deductionsGroupBox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox employeePositionComboBox;
		private System.Windows.Forms.ComboBox employeeDepartmentComboBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox employmentGroupBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox employeeFirstNameTextField;
		private System.Windows.Forms.TextBox employeeLastNameTextField;
		private System.Windows.Forms.GroupBox basicGroupBox;
		private System.Windows.Forms.ComboBox employeeIDComboBox;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label label1;
	}
}
