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
<<<<<<< HEAD
			this.updateEmployeeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
=======
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
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
<<<<<<< HEAD
=======
			this.oldFsaTextField = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.fsaCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.newRetirementTextField = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
<<<<<<< HEAD
=======
			this.oldRetirementTextField = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.retirementCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.newLifeInsuranceTextField = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
<<<<<<< HEAD
=======
			this.oldLifeInsuranceTextField = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.lifeInsuranceCheckBox = new System.Windows.Forms.CheckBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.newMedicalTextField = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
<<<<<<< HEAD
=======
			this.oldMedicalTextField = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.medicalInsuranceCheckBox = new System.Windows.Forms.CheckBox();
			this.financialGroupBox = new System.Windows.Forms.GroupBox();
			this.newRateTextField = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
<<<<<<< HEAD
			this.newHoursTextField = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
=======
			this.oldRateTextField = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.newHoursTextField = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.originalHoursTextField = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
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
			this.label1.Location = new System.Drawing.Point(12, 38);
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
<<<<<<< HEAD
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.updateEmployeeInformationToolStripMenuItem,
									this.toolStripSeparator1,
									this.exitToolStripMenuItem});
=======
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
<<<<<<< HEAD
			// updateEmployeeInformationToolStripMenuItem
			// 
			this.updateEmployeeInformationToolStripMenuItem.Name = "updateEmployeeInformationToolStripMenuItem";
			this.updateEmployeeInformationToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.updateEmployeeInformationToolStripMenuItem.Text = "&Update Employee Information";
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
			this.exitToolStripMenuItem.Text = "&Close";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItemClick);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.helpToolStripMenuItem1});
=======
			// helpToolStripMenuItem
			// 
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "&Help";
			// 
<<<<<<< HEAD
			// helpToolStripMenuItem1
			// 
			this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
			this.helpToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
			this.helpToolStripMenuItem1.Text = "&Help";
			this.helpToolStripMenuItem1.Click += new System.EventHandler(this.HelpToolStripMenuItem1Click);
			// 
=======
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			// employeeIDComboBox
			// 
			this.employeeIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.employeeIDComboBox.FormattingEnabled = true;
			this.employeeIDComboBox.Location = new System.Drawing.Point(130, 35);
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
			this.basicGroupBox.Location = new System.Drawing.Point(12, 65);
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
			this.employmentGroupBox.Location = new System.Drawing.Point(12, 147);
			this.employmentGroupBox.Name = "employmentGroupBox";
			this.employmentGroupBox.Size = new System.Drawing.Size(263, 91);
			this.employmentGroupBox.TabIndex = 6;
			this.employmentGroupBox.TabStop = false;
			this.employmentGroupBox.Text = "Employment Information";
			// 
			// employeeDepartmentComboBox
			// 
			this.employeeDepartmentComboBox.FormattingEnabled = true;
			this.employeeDepartmentComboBox.Location = new System.Drawing.Point(93, 51);
			this.employeeDepartmentComboBox.Name = "employeeDepartmentComboBox";
			this.employeeDepartmentComboBox.Size = new System.Drawing.Size(152, 21);
			this.employeeDepartmentComboBox.TabIndex = 4;
			// 
			// employeePositionComboBox
			// 
			this.employeePositionComboBox.FormattingEnabled = true;
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
			this.deductionsGroupBox.Location = new System.Drawing.Point(291, 35);
			this.deductionsGroupBox.Name = "deductionsGroupBox";
<<<<<<< HEAD
			this.deductionsGroupBox.Size = new System.Drawing.Size(330, 272);
=======
			this.deductionsGroupBox.Size = new System.Drawing.Size(330, 387);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.deductionsGroupBox.TabIndex = 7;
			this.deductionsGroupBox.TabStop = false;
			this.deductionsGroupBox.Text = "Deductions";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.newFsaTextField);
			this.groupBox7.Controls.Add(this.label13);
<<<<<<< HEAD
			this.groupBox7.Controls.Add(this.fsaCheckBox);
			this.groupBox7.Location = new System.Drawing.Point(169, 139);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(155, 113);
=======
			this.groupBox7.Controls.Add(this.oldFsaTextField);
			this.groupBox7.Controls.Add(this.label12);
			this.groupBox7.Controls.Add(this.fsaCheckBox);
			this.groupBox7.Location = new System.Drawing.Point(169, 208);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(155, 173);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.groupBox7.TabIndex = 3;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Flexible Spending Account";
			// 
			// newFsaTextField
			// 
			this.newFsaTextField.Enabled = false;
<<<<<<< HEAD
			this.newFsaTextField.Location = new System.Drawing.Point(7, 75);
=======
			this.newFsaTextField.Location = new System.Drawing.Point(7, 132);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.newFsaTextField.Name = "newFsaTextField";
			this.newFsaTextField.Size = new System.Drawing.Size(133, 20);
			this.newFsaTextField.TabIndex = 4;
			// 
			// label13
			// 
<<<<<<< HEAD
			this.label13.Location = new System.Drawing.Point(7, 48);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 3;
			this.label13.Text = "Amount:";
=======
			this.label13.Location = new System.Drawing.Point(7, 105);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(100, 23);
			this.label13.TabIndex = 3;
			this.label13.Text = "New Amount:";
			// 
			// oldFsaTextField
			// 
			this.oldFsaTextField.Location = new System.Drawing.Point(7, 78);
			this.oldFsaTextField.Name = "oldFsaTextField";
			this.oldFsaTextField.ReadOnly = true;
			this.oldFsaTextField.Size = new System.Drawing.Size(133, 20);
			this.oldFsaTextField.TabIndex = 2;
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(7, 51);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(100, 23);
			this.label12.TabIndex = 1;
			this.label12.Text = "Original Value:";
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			// 
			// fsaCheckBox
			// 
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
<<<<<<< HEAD
			this.groupBox6.Controls.Add(this.retirementCheckBox);
			this.groupBox6.Location = new System.Drawing.Point(7, 139);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(156, 113);
=======
			this.groupBox6.Controls.Add(this.oldRetirementTextField);
			this.groupBox6.Controls.Add(this.label10);
			this.groupBox6.Controls.Add(this.retirementCheckBox);
			this.groupBox6.Location = new System.Drawing.Point(7, 208);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(156, 173);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.groupBox6.TabIndex = 2;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "401K/Retirement";
			// 
			// newRetirementTextField
			// 
			this.newRetirementTextField.Enabled = false;
<<<<<<< HEAD
			this.newRetirementTextField.Location = new System.Drawing.Point(7, 75);
=======
			this.newRetirementTextField.Location = new System.Drawing.Point(7, 132);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.newRetirementTextField.Name = "newRetirementTextField";
			this.newRetirementTextField.Size = new System.Drawing.Size(135, 20);
			this.newRetirementTextField.TabIndex = 4;
			// 
			// label11
			// 
<<<<<<< HEAD
			this.label11.Location = new System.Drawing.Point(7, 48);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 3;
			this.label11.Text = "Amount:";
=======
			this.label11.Location = new System.Drawing.Point(7, 105);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 23);
			this.label11.TabIndex = 3;
			this.label11.Text = "New Amount:";
			// 
			// oldRetirementTextField
			// 
			this.oldRetirementTextField.Location = new System.Drawing.Point(7, 78);
			this.oldRetirementTextField.Name = "oldRetirementTextField";
			this.oldRetirementTextField.ReadOnly = true;
			this.oldRetirementTextField.Size = new System.Drawing.Size(135, 20);
			this.oldRetirementTextField.TabIndex = 2;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(7, 51);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 23);
			this.label10.TabIndex = 1;
			this.label10.Text = "Original Value:";
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			// 
			// retirementCheckBox
			// 
			this.retirementCheckBox.Location = new System.Drawing.Point(7, 20);
			this.retirementCheckBox.Name = "retirementCheckBox";
			this.retirementCheckBox.Size = new System.Drawing.Size(104, 24);
			this.retirementCheckBox.TabIndex = 0;
			this.retirementCheckBox.Text = "Have 401K Plan";
			this.retirementCheckBox.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.newLifeInsuranceTextField);
			this.groupBox5.Controls.Add(this.label9);
<<<<<<< HEAD
			this.groupBox5.Controls.Add(this.lifeInsuranceCheckBox);
			this.groupBox5.Location = new System.Drawing.Point(169, 20);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(155, 109);
=======
			this.groupBox5.Controls.Add(this.oldLifeInsuranceTextField);
			this.groupBox5.Controls.Add(this.label8);
			this.groupBox5.Controls.Add(this.lifeInsuranceCheckBox);
			this.groupBox5.Location = new System.Drawing.Point(169, 20);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(155, 181);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.groupBox5.TabIndex = 1;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Life Insurance";
			// 
			// newLifeInsuranceTextField
			// 
			this.newLifeInsuranceTextField.Enabled = false;
<<<<<<< HEAD
			this.newLifeInsuranceTextField.Location = new System.Drawing.Point(7, 70);
=======
			this.newLifeInsuranceTextField.Location = new System.Drawing.Point(7, 128);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.newLifeInsuranceTextField.Name = "newLifeInsuranceTextField";
			this.newLifeInsuranceTextField.Size = new System.Drawing.Size(133, 20);
			this.newLifeInsuranceTextField.TabIndex = 4;
			// 
			// label9
			// 
<<<<<<< HEAD
			this.label9.Location = new System.Drawing.Point(7, 47);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 3;
			this.label9.Text = "Amount:";
=======
			this.label9.Location = new System.Drawing.Point(7, 105);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 23);
			this.label9.TabIndex = 3;
			this.label9.Text = "New Amount:";
			// 
			// oldLifeInsuranceTextField
			// 
			this.oldLifeInsuranceTextField.Location = new System.Drawing.Point(7, 78);
			this.oldLifeInsuranceTextField.Name = "oldLifeInsuranceTextField";
			this.oldLifeInsuranceTextField.ReadOnly = true;
			this.oldLifeInsuranceTextField.Size = new System.Drawing.Size(133, 20);
			this.oldLifeInsuranceTextField.TabIndex = 2;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(7, 51);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 1;
			this.label8.Text = "Original Value:";
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			// 
			// lifeInsuranceCheckBox
			// 
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
<<<<<<< HEAD
			this.groupBox4.Controls.Add(this.medicalInsuranceCheckBox);
			this.groupBox4.Location = new System.Drawing.Point(7, 20);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(156, 109);
=======
			this.groupBox4.Controls.Add(this.oldMedicalTextField);
			this.groupBox4.Controls.Add(this.label6);
			this.groupBox4.Controls.Add(this.medicalInsuranceCheckBox);
			this.groupBox4.Location = new System.Drawing.Point(7, 20);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(156, 181);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.groupBox4.TabIndex = 0;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Medical/Dental";
			// 
			// newMedicalTextField
			// 
			this.newMedicalTextField.Enabled = false;
<<<<<<< HEAD
			this.newMedicalTextField.Location = new System.Drawing.Point(7, 70);
=======
			this.newMedicalTextField.Location = new System.Drawing.Point(7, 128);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.newMedicalTextField.Name = "newMedicalTextField";
			this.newMedicalTextField.Size = new System.Drawing.Size(135, 20);
			this.newMedicalTextField.TabIndex = 4;
			// 
			// label7
			// 
<<<<<<< HEAD
			this.label7.Location = new System.Drawing.Point(7, 47);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 3;
			this.label7.Text = "Amount:";
=======
			this.label7.Location = new System.Drawing.Point(7, 105);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 3;
			this.label7.Text = "New Amount:";
			// 
			// oldMedicalTextField
			// 
			this.oldMedicalTextField.Location = new System.Drawing.Point(7, 78);
			this.oldMedicalTextField.Name = "oldMedicalTextField";
			this.oldMedicalTextField.ReadOnly = true;
			this.oldMedicalTextField.Size = new System.Drawing.Size(135, 20);
			this.oldMedicalTextField.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(7, 51);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 1;
			this.label6.Text = "Original Value:";
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			// 
			// medicalInsuranceCheckBox
			// 
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
<<<<<<< HEAD
			this.financialGroupBox.Controls.Add(this.newHoursTextField);
			this.financialGroupBox.Controls.Add(this.label15);
=======
			this.financialGroupBox.Controls.Add(this.oldRateTextField);
			this.financialGroupBox.Controls.Add(this.label16);
			this.financialGroupBox.Controls.Add(this.newHoursTextField);
			this.financialGroupBox.Controls.Add(this.label15);
			this.financialGroupBox.Controls.Add(this.originalHoursTextField);
			this.financialGroupBox.Controls.Add(this.label14);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.financialGroupBox.Controls.Add(this.hourlyRadioButton);
			this.financialGroupBox.Controls.Add(this.salaryRadioButton);
			this.financialGroupBox.Enabled = false;
			this.financialGroupBox.Location = new System.Drawing.Point(12, 244);
			this.financialGroupBox.Name = "financialGroupBox";
<<<<<<< HEAD
			this.financialGroupBox.Size = new System.Drawing.Size(263, 105);
=======
			this.financialGroupBox.Size = new System.Drawing.Size(263, 178);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.financialGroupBox.TabIndex = 8;
			this.financialGroupBox.TabStop = false;
			this.financialGroupBox.Text = "Financial Information";
			// 
			// newRateTextField
			// 
<<<<<<< HEAD
			this.newRateTextField.Location = new System.Drawing.Point(101, 69);
=======
			this.newRateTextField.Location = new System.Drawing.Point(97, 140);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.newRateTextField.Name = "newRateTextField";
			this.newRateTextField.Size = new System.Drawing.Size(100, 20);
			this.newRateTextField.TabIndex = 10;
			// 
			// label17
			// 
<<<<<<< HEAD
			this.label17.Location = new System.Drawing.Point(12, 69);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 23);
			this.label17.TabIndex = 9;
			this.label17.Text = "Rate:";
			// 
			// newHoursTextField
			// 
			this.newHoursTextField.Location = new System.Drawing.Point(101, 43);
=======
			this.label17.Location = new System.Drawing.Point(8, 140);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(100, 23);
			this.label17.TabIndex = 9;
			this.label17.Text = "New Rate:";
			// 
			// oldRateTextField
			// 
			this.oldRateTextField.Location = new System.Drawing.Point(97, 110);
			this.oldRateTextField.Name = "oldRateTextField";
			this.oldRateTextField.ReadOnly = true;
			this.oldRateTextField.Size = new System.Drawing.Size(100, 20);
			this.oldRateTextField.TabIndex = 8;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(8, 113);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(100, 23);
			this.label16.TabIndex = 7;
			this.label16.Text = "Original Rate:";
			// 
			// newHoursTextField
			// 
			this.newHoursTextField.Location = new System.Drawing.Point(97, 74);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.newHoursTextField.Name = "newHoursTextField";
			this.newHoursTextField.Size = new System.Drawing.Size(100, 20);
			this.newHoursTextField.TabIndex = 6;
			// 
			// label15
			// 
<<<<<<< HEAD
			this.label15.Location = new System.Drawing.Point(12, 46);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 5;
			this.label15.Text = "Hours:";
=======
			this.label15.Location = new System.Drawing.Point(8, 77);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(100, 23);
			this.label15.TabIndex = 5;
			this.label15.Text = "New Hours:";
			// 
			// originalHoursTextField
			// 
			this.originalHoursTextField.Location = new System.Drawing.Point(97, 47);
			this.originalHoursTextField.Name = "originalHoursTextField";
			this.originalHoursTextField.ReadOnly = true;
			this.originalHoursTextField.Size = new System.Drawing.Size(100, 20);
			this.originalHoursTextField.TabIndex = 4;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(8, 50);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(100, 23);
			this.label14.TabIndex = 3;
			this.label14.Text = "Original Hours:";
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
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
<<<<<<< HEAD
			this.updateButton.Location = new System.Drawing.Point(291, 313);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(163, 23);
=======
			this.updateButton.Location = new System.Drawing.Point(72, 438);
			this.updateButton.Name = "updateButton";
			this.updateButton.Size = new System.Drawing.Size(185, 23);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.updateButton.TabIndex = 9;
			this.updateButton.Text = "&Update Employee Information";
			this.updateButton.UseVisualStyleBackColor = true;
			// 
			// cancelButton
			// 
<<<<<<< HEAD
			this.cancelButton.Location = new System.Drawing.Point(460, 313);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(161, 23);
=======
			this.cancelButton.Location = new System.Drawing.Point(305, 438);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(185, 23);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
			this.cancelButton.TabIndex = 10;
			this.cancelButton.Text = "&Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			// 
			// EditEmployee
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
			this.ClientSize = new System.Drawing.Size(633, 362);
=======
			this.ClientSize = new System.Drawing.Size(633, 473);
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
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
<<<<<<< HEAD
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem updateEmployeeInformationToolStripMenuItem;
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox newRateTextField;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox newHoursTextField;
=======
		private System.Windows.Forms.Button cancelButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.TextBox oldRateTextField;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox newRateTextField;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox originalHoursTextField;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox newHoursTextField;
		private System.Windows.Forms.Label label16;
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
		private System.Windows.Forms.RadioButton salaryRadioButton;
		private System.Windows.Forms.RadioButton hourlyRadioButton;
		private System.Windows.Forms.GroupBox financialGroupBox;
		private System.Windows.Forms.CheckBox retirementCheckBox;
<<<<<<< HEAD
=======
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox oldRetirementTextField;
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox newRetirementTextField;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.CheckBox fsaCheckBox;
<<<<<<< HEAD
=======
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox oldFsaTextField;
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox newFsaTextField;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.CheckBox lifeInsuranceCheckBox;
<<<<<<< HEAD
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox newLifeInsuranceTextField;
		private System.Windows.Forms.CheckBox medicalInsuranceCheckBox;
=======
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox oldLifeInsuranceTextField;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox newLifeInsuranceTextField;
		private System.Windows.Forms.CheckBox medicalInsuranceCheckBox;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox oldMedicalTextField;
>>>>>>> 66872ad6c547cf3fb10a7995613a093fc56e4bd7
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
