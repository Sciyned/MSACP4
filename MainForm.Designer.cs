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
	partial class PayrollMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PayrollMainForm));
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.editEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monthlySummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.completeSummaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.positionLabel = new System.Windows.Forms.Label();
            this.departmentComboBox = new System.Windows.Forms.ComboBox();
            this.positionComboBox = new System.Windows.Forms.ComboBox();
            this.basicInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.employeeLastNameComboBox = new System.Windows.Forms.ComboBox();
            this.employeeFirstNameComboBox = new System.Windows.Forms.ComboBox();
            this.employeeIDComboBox = new System.Windows.Forms.ComboBox();
            this.addInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.financialInfoGroupBox = new System.Windows.Forms.GroupBox();
            this.hoursTextField = new System.Windows.Forms.TextBox();
            this.hoursLabel = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.fsaCheckBox = new System.Windows.Forms.CheckBox();
            this.fourCheckBox = new System.Windows.Forms.CheckBox();
            this.lifeInsuranceCheckBox = new System.Windows.Forms.CheckBox();
            this.medicalCheckBox = new System.Windows.Forms.CheckBox();
            this.rateTextField = new System.Windows.Forms.TextBox();
            this.rateLabel = new System.Windows.Forms.Label();
            this.hourlyRadioButton = new System.Windows.Forms.RadioButton();
            this.salaryRadioButton = new System.Windows.Forms.RadioButton();
            this.monthGroupBox = new System.Windows.Forms.GroupBox();
            this.monthComboBox = new System.Windows.Forms.ComboBox();
            this.monthLabel = new System.Windows.Forms.Label();
            this.updateButton = new System.Windows.Forms.Button();
            this.removeButton = new System.Windows.Forms.Button();
            this.printButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.employeeMonthlyDocument = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.menuStrip1.SuspendLayout();
            this.basicInfoGroupBox.SuspendLayout();
            this.addInfoGroupBox.SuspendLayout();
            this.financialInfoGroupBox.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.monthGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Location = new System.Drawing.Point(7, 25);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(35, 23);
            this.employeeIDLabel.TabIndex = 0;
            this.employeeIDLabel.Text = "ID:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(7, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Name:";
            // 
            // departmentLabel
            // 
            this.departmentLabel.Location = new System.Drawing.Point(6, 54);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(67, 23);
            this.departmentLabel.TabIndex = 2;
            this.departmentLabel.Text = "Department:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.Location = new System.Drawing.Point(7, 76);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(48, 23);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.Location = new System.Drawing.Point(7, 110);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(34, 23);
            this.lastNameLabel.TabIndex = 4;
            this.lastNameLabel.Text = "Last:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(341, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "payrollMenuStrip";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveFileToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.saveFileToolStripMenuItem.Text = "&Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.saveFileToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(217, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.printToolStripMenuItem.Text = "&Print Employee Information";
            this.printToolStripMenuItem.Click += new System.EventHandler(this.printButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(217, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(220, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateEmployeeToolStripMenuItem,
            this.removeEmployeeToolStripMenuItem,
            this.toolStripSeparator3,
            this.editEmployeeToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // updateEmployeeToolStripMenuItem
            // 
            this.updateEmployeeToolStripMenuItem.Name = "updateEmployeeToolStripMenuItem";
            this.updateEmployeeToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.updateEmployeeToolStripMenuItem.Text = "&Update Employee";
            this.updateEmployeeToolStripMenuItem.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeEmployeeToolStripMenuItem
            // 
            this.removeEmployeeToolStripMenuItem.Name = "removeEmployeeToolStripMenuItem";
            this.removeEmployeeToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.removeEmployeeToolStripMenuItem.Text = "&Remove Employee";
            this.removeEmployeeToolStripMenuItem.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(212, 6);
            // 
            // editEmployeeToolStripMenuItem
            // 
            this.editEmployeeToolStripMenuItem.Name = "editEmployeeToolStripMenuItem";
            this.editEmployeeToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.editEmployeeToolStripMenuItem.Text = "Edit Em&ployee Information";
            this.editEmployeeToolStripMenuItem.Click += new System.EventHandler(this.EditEmployeeToolStripMenuItemClick);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monthlySummaryToolStripMenuItem,
            this.completeSummaryToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // monthlySummaryToolStripMenuItem
            // 
            this.monthlySummaryToolStripMenuItem.Name = "monthlySummaryToolStripMenuItem";
            this.monthlySummaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.monthlySummaryToolStripMenuItem.Text = "&Monthly Summary";
            // 
            // completeSummaryToolStripMenuItem
            // 
            this.completeSummaryToolStripMenuItem.Name = "completeSummaryToolStripMenuItem";
            this.completeSummaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.completeSummaryToolStripMenuItem.Text = "&Complete Summary";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.aboutToolStripMenuItem.Text = "&About Payroll Application";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // positionLabel
            // 
            this.positionLabel.Location = new System.Drawing.Point(6, 27);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(51, 23);
            this.positionLabel.TabIndex = 6;
            this.positionLabel.Text = "Position:";
            // 
            // departmentComboBox
            // 
            this.departmentComboBox.FormattingEnabled = true;
            this.departmentComboBox.Items.AddRange(new object[] {
            "HR",
            "Accounting",
            "R&D",
            "Sales",
            "Production"});
            this.departmentComboBox.Location = new System.Drawing.Point(79, 51);
            this.departmentComboBox.Name = "departmentComboBox";
            this.departmentComboBox.Size = new System.Drawing.Size(137, 21);
            this.departmentComboBox.TabIndex = 10;
            // 
            // positionComboBox
            // 
            this.positionComboBox.FormattingEnabled = true;
            this.positionComboBox.Items.AddRange(new object[] {
            "Manager",
            "Engineer",
            "Technician",
            "Clerk",
            "Producer"});
            this.positionComboBox.Location = new System.Drawing.Point(79, 24);
            this.positionComboBox.Name = "positionComboBox";
            this.positionComboBox.Size = new System.Drawing.Size(137, 21);
            this.positionComboBox.TabIndex = 11;
            // 
            // basicInfoGroupBox
            // 
            this.basicInfoGroupBox.Controls.Add(this.employeeLastNameComboBox);
            this.basicInfoGroupBox.Controls.Add(this.employeeFirstNameComboBox);
            this.basicInfoGroupBox.Controls.Add(this.employeeIDComboBox);
            this.basicInfoGroupBox.Controls.Add(this.employeeIDLabel);
            this.basicInfoGroupBox.Controls.Add(this.label2);
            this.basicInfoGroupBox.Controls.Add(this.firstNameLabel);
            this.basicInfoGroupBox.Controls.Add(this.lastNameLabel);
            this.basicInfoGroupBox.Location = new System.Drawing.Point(12, 85);
            this.basicInfoGroupBox.Name = "basicInfoGroupBox";
            this.basicInfoGroupBox.Size = new System.Drawing.Size(317, 144);
            this.basicInfoGroupBox.TabIndex = 13;
            this.basicInfoGroupBox.TabStop = false;
            this.basicInfoGroupBox.Text = "Basic Information";
            // 
            // employeeLastNameComboBox
            // 
            this.employeeLastNameComboBox.FormattingEnabled = true;
            this.employeeLastNameComboBox.Location = new System.Drawing.Point(95, 110);
            this.employeeLastNameComboBox.Name = "employeeLastNameComboBox";
            this.employeeLastNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeLastNameComboBox.TabIndex = 7;
            this.employeeLastNameComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeLastNameComboBox_SelectedIndexChanged);
            // 
            // employeeFirstNameComboBox
            // 
            this.employeeFirstNameComboBox.FormattingEnabled = true;
            this.employeeFirstNameComboBox.Location = new System.Drawing.Point(95, 76);
            this.employeeFirstNameComboBox.Name = "employeeFirstNameComboBox";
            this.employeeFirstNameComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeFirstNameComboBox.TabIndex = 6;
            this.employeeFirstNameComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeFirstNameComboBox_SelectedIndexChanged);
            // 
            // employeeIDComboBox
            // 
            this.employeeIDComboBox.FormattingEnabled = true;
            this.employeeIDComboBox.Location = new System.Drawing.Point(95, 25);
            this.employeeIDComboBox.Name = "employeeIDComboBox";
            this.employeeIDComboBox.Size = new System.Drawing.Size(121, 21);
            this.employeeIDComboBox.TabIndex = 5;
            this.employeeIDComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeIDComboBox_SelectedIndexChanged);
            // 
            // addInfoGroupBox
            // 
            this.addInfoGroupBox.Controls.Add(this.positionLabel);
            this.addInfoGroupBox.Controls.Add(this.departmentLabel);
            this.addInfoGroupBox.Controls.Add(this.departmentComboBox);
            this.addInfoGroupBox.Controls.Add(this.positionComboBox);
            this.addInfoGroupBox.Location = new System.Drawing.Point(12, 235);
            this.addInfoGroupBox.Name = "addInfoGroupBox";
            this.addInfoGroupBox.Size = new System.Drawing.Size(317, 100);
            this.addInfoGroupBox.TabIndex = 14;
            this.addInfoGroupBox.TabStop = false;
            this.addInfoGroupBox.Text = "Additional Information";
            // 
            // financialInfoGroupBox
            // 
            this.financialInfoGroupBox.Controls.Add(this.hoursTextField);
            this.financialInfoGroupBox.Controls.Add(this.hoursLabel);
            this.financialInfoGroupBox.Controls.Add(this.groupBox4);
            this.financialInfoGroupBox.Controls.Add(this.rateTextField);
            this.financialInfoGroupBox.Controls.Add(this.rateLabel);
            this.financialInfoGroupBox.Controls.Add(this.hourlyRadioButton);
            this.financialInfoGroupBox.Controls.Add(this.salaryRadioButton);
            this.financialInfoGroupBox.Location = new System.Drawing.Point(12, 342);
            this.financialInfoGroupBox.Name = "financialInfoGroupBox";
            this.financialInfoGroupBox.Size = new System.Drawing.Size(317, 141);
            this.financialInfoGroupBox.TabIndex = 15;
            this.financialInfoGroupBox.TabStop = false;
            this.financialInfoGroupBox.Text = "Financial Information";
            // 
            // hoursTextField
            // 
            this.hoursTextField.Location = new System.Drawing.Point(48, 43);
            this.hoursTextField.Name = "hoursTextField";
            this.hoursTextField.Size = new System.Drawing.Size(117, 20);
            this.hoursTextField.TabIndex = 6;
            // 
            // hoursLabel
            // 
            this.hoursLabel.Location = new System.Drawing.Point(7, 46);
            this.hoursLabel.Name = "hoursLabel";
            this.hoursLabel.Size = new System.Drawing.Size(48, 23);
            this.hoursLabel.TabIndex = 5;
            this.hoursLabel.Text = "Hours:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.fsaCheckBox);
            this.groupBox4.Controls.Add(this.fourCheckBox);
            this.groupBox4.Controls.Add(this.lifeInsuranceCheckBox);
            this.groupBox4.Controls.Add(this.medicalCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(189, 19);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(116, 116);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Deductions";
            // 
            // fsaCheckBox
            // 
            this.fsaCheckBox.Location = new System.Drawing.Point(6, 86);
            this.fsaCheckBox.Name = "fsaCheckBox";
            this.fsaCheckBox.Size = new System.Drawing.Size(104, 24);
            this.fsaCheckBox.TabIndex = 5;
            this.fsaCheckBox.Text = "FSA";
            this.fsaCheckBox.UseVisualStyleBackColor = true;
            // 
            // fourCheckBox
            // 
            this.fourCheckBox.Location = new System.Drawing.Point(6, 60);
            this.fourCheckBox.Name = "fourCheckBox";
            this.fourCheckBox.Size = new System.Drawing.Size(96, 29);
            this.fourCheckBox.TabIndex = 4;
            this.fourCheckBox.Text = "401K";
            this.fourCheckBox.UseVisualStyleBackColor = true;
            // 
            // lifeInsuranceCheckBox
            // 
            this.lifeInsuranceCheckBox.Location = new System.Drawing.Point(6, 40);
            this.lifeInsuranceCheckBox.Name = "lifeInsuranceCheckBox";
            this.lifeInsuranceCheckBox.Size = new System.Drawing.Size(104, 24);
            this.lifeInsuranceCheckBox.TabIndex = 2;
            this.lifeInsuranceCheckBox.Text = "Life Insurance";
            this.lifeInsuranceCheckBox.UseVisualStyleBackColor = true;
            // 
            // medicalCheckBox
            // 
            this.medicalCheckBox.Location = new System.Drawing.Point(6, 19);
            this.medicalCheckBox.Name = "medicalCheckBox";
            this.medicalCheckBox.Size = new System.Drawing.Size(104, 24);
            this.medicalCheckBox.TabIndex = 1;
            this.medicalCheckBox.Text = "Medical/Dental";
            this.medicalCheckBox.UseVisualStyleBackColor = true;
            // 
            // rateTextField
            // 
            this.rateTextField.Location = new System.Drawing.Point(48, 66);
            this.rateTextField.Name = "rateTextField";
            this.rateTextField.Size = new System.Drawing.Size(117, 20);
            this.rateTextField.TabIndex = 3;
            // 
            // rateLabel
            // 
            this.rateLabel.Location = new System.Drawing.Point(7, 69);
            this.rateLabel.Name = "rateLabel";
            this.rateLabel.Size = new System.Drawing.Size(35, 23);
            this.rateLabel.TabIndex = 2;
            this.rateLabel.Text = "Rate:";
            // 
            // hourlyRadioButton
            // 
            this.hourlyRadioButton.Location = new System.Drawing.Point(79, 19);
            this.hourlyRadioButton.Name = "hourlyRadioButton";
            this.hourlyRadioButton.Size = new System.Drawing.Size(104, 24);
            this.hourlyRadioButton.TabIndex = 1;
            this.hourlyRadioButton.TabStop = true;
            this.hourlyRadioButton.Text = "Hourly";
            this.hourlyRadioButton.UseVisualStyleBackColor = true;
            this.hourlyRadioButton.CheckedChanged += new System.EventHandler(this.HourlyRadioButtonCheckedChanged);
            // 
            // salaryRadioButton
            // 
            this.salaryRadioButton.Location = new System.Drawing.Point(7, 19);
            this.salaryRadioButton.Name = "salaryRadioButton";
            this.salaryRadioButton.Size = new System.Drawing.Size(104, 24);
            this.salaryRadioButton.TabIndex = 0;
            this.salaryRadioButton.TabStop = true;
            this.salaryRadioButton.Text = "Salary";
            this.salaryRadioButton.UseVisualStyleBackColor = true;
            this.salaryRadioButton.CheckedChanged += new System.EventHandler(this.SalaryRadioButtonCheckedChanged);
            // 
            // monthGroupBox
            // 
            this.monthGroupBox.Controls.Add(this.monthComboBox);
            this.monthGroupBox.Controls.Add(this.monthLabel);
            this.monthGroupBox.Location = new System.Drawing.Point(12, 28);
            this.monthGroupBox.Name = "monthGroupBox";
            this.monthGroupBox.Size = new System.Drawing.Size(317, 51);
            this.monthGroupBox.TabIndex = 16;
            this.monthGroupBox.TabStop = false;
            // 
            // monthComboBox
            // 
            this.monthComboBox.FormattingEnabled = true;
            this.monthComboBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthComboBox.Location = new System.Drawing.Point(79, 13);
            this.monthComboBox.Name = "monthComboBox";
            this.monthComboBox.Size = new System.Drawing.Size(137, 21);
            this.monthComboBox.TabIndex = 1;
            this.monthComboBox.SelectedIndexChanged += new System.EventHandler(this.monthComboBox_SelectedIndexChanged);
            // 
            // monthLabel
            // 
            this.monthLabel.Location = new System.Drawing.Point(7, 16);
            this.monthLabel.Name = "monthLabel";
            this.monthLabel.Size = new System.Drawing.Size(100, 23);
            this.monthLabel.TabIndex = 0;
            this.monthLabel.Text = "Month:";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(19, 501);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(137, 30);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "&Update Employee";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(19, 537);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(137, 30);
            this.removeButton.TabIndex = 20;
            this.removeButton.Text = "&Remove Employee";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // printButton
            // 
            this.printButton.Location = new System.Drawing.Point(180, 525);
            this.printButton.Name = "printButton";
            this.printButton.Size = new System.Drawing.Size(137, 30);
            this.printButton.TabIndex = 21;
            this.printButton.Text = "Print Current Information";
            this.printButton.UseVisualStyleBackColor = true;
            this.printButton.Click += new System.EventHandler(this.printButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(180, 561);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(137, 30);
            this.exitButton.TabIndex = 22;
            this.exitButton.Text = "E&xit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(180, 489);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(137, 30);
            this.clearButton.TabIndex = 23;
            this.clearButton.Text = "&Clear Fields";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // employeeMonthlyDocument
            // 
            this.employeeMonthlyDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.employeeMonthlyDocument_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // PayrollMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 600);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.printButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.monthGroupBox);
            this.Controls.Add(this.financialInfoGroupBox);
            this.Controls.Add(this.addInfoGroupBox);
            this.Controls.Add(this.basicInfoGroupBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PayrollMainForm";
            this.Text = "Payroll Application";
            this.Load += new System.EventHandler(this.PayrollMainFormLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.basicInfoGroupBox.ResumeLayout(false);
            this.addInfoGroupBox.ResumeLayout(false);
            this.financialInfoGroupBox.ResumeLayout(false);
            this.financialInfoGroupBox.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.monthGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		private System.Windows.Forms.ComboBox employeeIDComboBox;
		private System.Windows.Forms.ComboBox employeeFirstNameComboBox;
		private System.Windows.Forms.ComboBox employeeLastNameComboBox;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button exitButton;
		private System.Windows.Forms.Button printButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Button updateButton;
		private System.Windows.Forms.Label monthLabel;
		private System.Windows.Forms.ComboBox monthComboBox;
		private System.Windows.Forms.GroupBox monthGroupBox;
		private System.Windows.Forms.RadioButton salaryRadioButton;
		private System.Windows.Forms.RadioButton hourlyRadioButton;
		private System.Windows.Forms.Label rateLabel;
		private System.Windows.Forms.TextBox rateTextField;
		private System.Windows.Forms.CheckBox medicalCheckBox;
		private System.Windows.Forms.CheckBox lifeInsuranceCheckBox;
		private System.Windows.Forms.CheckBox fourCheckBox;
		private System.Windows.Forms.CheckBox fsaCheckBox;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label hoursLabel;
		private System.Windows.Forms.TextBox hoursTextField;
		private System.Windows.Forms.GroupBox financialInfoGroupBox;
		private System.Windows.Forms.GroupBox addInfoGroupBox;
		private System.Windows.Forms.GroupBox basicInfoGroupBox;
		private System.Windows.Forms.ComboBox positionComboBox;
		private System.Windows.Forms.ComboBox departmentComboBox;
		private System.Windows.Forms.Label positionLabel;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem completeSummaryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem monthlySummaryToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editEmployeeToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem removeEmployeeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem updateEmployeeToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Label lastNameLabel;
		private System.Windows.Forms.Label firstNameLabel;
		private System.Windows.Forms.Label departmentLabel;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label employeeIDLabel;
        private System.Drawing.Printing.PrintDocument employeeMonthlyDocument;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
	}
}
