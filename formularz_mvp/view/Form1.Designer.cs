namespace formularz_mvp.view
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
        /// <param name="disposing">true if mansalaryd resources should be disposed; otherwise, false.</param>
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
            this.components = new System.ComponentModel.Container();
            this.panel_listboxWIthEmployee = new System.Windows.Forms.Panel();
            this.listBox_list_employee = new System.Windows.Forms.ListBox();
            this.groupBox_employeesDetail = new System.Windows.Forms.GroupBox();
            this.button_openFile = new System.Windows.Forms.Button();
            this.button_save = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.panel_TypesOfContract = new System.Windows.Forms.Panel();
            this.radioButton_MandateContract = new System.Windows.Forms.RadioButton();
            this.radioButton_TimeContract = new System.Windows.Forms.RadioButton();
            this.radioButton_FullContract = new System.Windows.Forms.RadioButton();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.numericUpDown_salary = new System.Windows.Forms.NumericUpDown();
            this.label_contract = new System.Windows.Forms.Label();
            this.label_position = new System.Windows.Forms.Label();
            this.label_salary = new System.Windows.Forms.Label();
            this.dateTimePicker_dateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.label_dateOfBirth = new System.Windows.Forms.Label();
            this.label_surname = new System.Windows.Forms.Label();
            this.label_name = new System.Windows.Forms.Label();
            this.textBox_surname = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_listboxWIthEmployee.SuspendLayout();
            this.groupBox_employeesDetail.SuspendLayout();
            this.panel_TypesOfContract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_listboxWIthEmployee
            // 
            this.panel_listboxWIthEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_listboxWIthEmployee.Controls.Add(this.listBox_list_employee);
            this.panel_listboxWIthEmployee.Location = new System.Drawing.Point(411, 23);
            this.panel_listboxWIthEmployee.Name = "panel_listboxWIthEmployee";
            this.panel_listboxWIthEmployee.Size = new System.Drawing.Size(576, 525);
            this.panel_listboxWIthEmployee.TabIndex = 0;
            // 
            // listBox_list_employee
            // 
            this.listBox_list_employee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox_list_employee.FormattingEnabled = true;
            this.listBox_list_employee.HorizontalScrollbar = true;
            this.listBox_list_employee.ItemHeight = 20;
            this.listBox_list_employee.Location = new System.Drawing.Point(0, 0);
            this.listBox_list_employee.Name = "listBox_list_employee";
            this.listBox_list_employee.ScrollAlwaysVisible = true;
            this.listBox_list_employee.Size = new System.Drawing.Size(576, 525);
            this.listBox_list_employee.TabIndex = 0;
            this.listBox_list_employee.SelectedIndexChanged += new System.EventHandler(this.Get_Employee_From_ListBox);
            // 
            // groupBox_employeesDetail
            // 
            this.groupBox_employeesDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox_employeesDetail.Controls.Add(this.button_openFile);
            this.groupBox_employeesDetail.Controls.Add(this.button_save);
            this.groupBox_employeesDetail.Controls.Add(this.button_add);
            this.groupBox_employeesDetail.Controls.Add(this.panel_TypesOfContract);
            this.groupBox_employeesDetail.Controls.Add(this.comboBox_position);
            this.groupBox_employeesDetail.Controls.Add(this.numericUpDown_salary);
            this.groupBox_employeesDetail.Controls.Add(this.label_contract);
            this.groupBox_employeesDetail.Controls.Add(this.label_position);
            this.groupBox_employeesDetail.Controls.Add(this.label_salary);
            this.groupBox_employeesDetail.Controls.Add(this.dateTimePicker_dateOfBirth);
            this.groupBox_employeesDetail.Controls.Add(this.label_dateOfBirth);
            this.groupBox_employeesDetail.Controls.Add(this.label_surname);
            this.groupBox_employeesDetail.Controls.Add(this.label_name);
            this.groupBox_employeesDetail.Controls.Add(this.textBox_surname);
            this.groupBox_employeesDetail.Controls.Add(this.textBox_name);
            this.groupBox_employeesDetail.Location = new System.Drawing.Point(23, 23);
            this.groupBox_employeesDetail.Name = "groupBox_employeesDetail";
            this.groupBox_employeesDetail.Size = new System.Drawing.Size(372, 525);
            this.groupBox_employeesDetail.TabIndex = 1;
            this.groupBox_employeesDetail.TabStop = false;
            this.groupBox_employeesDetail.Text = "Employee details";
            // 
            // button_openFile
            // 
            this.button_openFile.Location = new System.Drawing.Point(243, 462);
            this.button_openFile.Name = "button_openFile";
            this.button_openFile.Size = new System.Drawing.Size(108, 33);
            this.button_openFile.TabIndex = 14;
            this.button_openFile.Text = "Open file";
            this.button_openFile.UseVisualStyleBackColor = true;
            this.button_openFile.Click += new System.EventHandler(this.button_openFile_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(10, 462);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(104, 33);
            this.button_save.TabIndex = 13;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(10, 407);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(341, 35);
            this.button_add.TabIndex = 12;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.Add_Employee);
            // 
            // panel_TypesOfContract
            // 
            this.panel_TypesOfContract.Controls.Add(this.radioButton_MandateContract);
            this.panel_TypesOfContract.Controls.Add(this.radioButton_TimeContract);
            this.panel_TypesOfContract.Controls.Add(this.radioButton_FullContract);
            this.panel_TypesOfContract.Location = new System.Drawing.Point(146, 262);
            this.panel_TypesOfContract.Name = "panel_TypesOfContract";
            this.panel_TypesOfContract.Size = new System.Drawing.Size(205, 105);
            this.panel_TypesOfContract.TabIndex = 11;
            this.panel_TypesOfContract.Validating += new System.ComponentModel.CancelEventHandler(this.panel_TypesOfContract_Validating);
            // 
            // radioButton_MandateContract
            // 
            this.radioButton_MandateContract.AutoSize = true;
            this.radioButton_MandateContract.Location = new System.Drawing.Point(3, 73);
            this.radioButton_MandateContract.Name = "radioButton_MandateContract";
            this.radioButton_MandateContract.Size = new System.Drawing.Size(162, 24);
            this.radioButton_MandateContract.TabIndex = 2;
            this.radioButton_MandateContract.Text = "Mandate Contract";
            this.radioButton_MandateContract.UseVisualStyleBackColor = true;
            // 
            // radioButton_TimeContract
            // 
            this.radioButton_TimeContract.AutoSize = true;
            this.radioButton_TimeContract.Location = new System.Drawing.Point(3, 43);
            this.radioButton_TimeContract.Name = "radioButton_TimeContract";
            this.radioButton_TimeContract.Size = new System.Drawing.Size(101, 24);
            this.radioButton_TimeContract.TabIndex = 1;
            this.radioButton_TimeContract.Text = "Part Time";
            this.radioButton_TimeContract.UseVisualStyleBackColor = true;
            // 
            // radioButton_FullContract
            // 
            this.radioButton_FullContract.AutoSize = true;
            this.radioButton_FullContract.Location = new System.Drawing.Point(3, 15);
            this.radioButton_FullContract.Name = "radioButton_FullContract";
            this.radioButton_FullContract.Size = new System.Drawing.Size(124, 24);
            this.radioButton_FullContract.TabIndex = 0;
            this.radioButton_FullContract.Text = "Full Contract";
            this.radioButton_FullContract.UseVisualStyleBackColor = true;
            // 
            // comboBox_position
            // 
            this.comboBox_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Location = new System.Drawing.Point(106, 215);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(245, 28);
            this.comboBox_position.TabIndex = 10;
            this.comboBox_position.Validating += new System.ComponentModel.CancelEventHandler(this.comboBox_position_Validating);
            // 
            // numericUpDown_salary
            // 
            this.numericUpDown_salary.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDown_salary.Location = new System.Drawing.Point(106, 169);
            this.numericUpDown_salary.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.numericUpDown_salary.Name = "numericUpDown_salary";
            this.numericUpDown_salary.Size = new System.Drawing.Size(245, 26);
            this.numericUpDown_salary.TabIndex = 9;
            this.numericUpDown_salary.Validating += new System.ComponentModel.CancelEventHandler(this.numericUpDown_salary_Validating);
            // 
            // label_contract
            // 
            this.label_contract.AutoSize = true;
            this.label_contract.Location = new System.Drawing.Point(6, 281);
            this.label_contract.Name = "label_contract";
            this.label_contract.Size = new System.Drawing.Size(123, 20);
            this.label_contract.TabIndex = 8;
            this.label_contract.Text = "Type of contract";
            // 
            // label_position
            // 
            this.label_position.AutoSize = true;
            this.label_position.Location = new System.Drawing.Point(6, 218);
            this.label_position.Name = "label_position";
            this.label_position.Size = new System.Drawing.Size(64, 20);
            this.label_position.TabIndex = 7;
            this.label_position.Text = "position";
            // 
            // label_salary
            // 
            this.label_salary.AutoSize = true;
            this.label_salary.Location = new System.Drawing.Point(6, 171);
            this.label_salary.Name = "label_salary";
            this.label_salary.Size = new System.Drawing.Size(50, 20);
            this.label_salary.TabIndex = 6;
            this.label_salary.Text = "salary";
            // 
            // dateTimePicker_dateOfBirth
            // 
            this.dateTimePicker_dateOfBirth.Location = new System.Drawing.Point(106, 124);
            this.dateTimePicker_dateOfBirth.Name = "dateTimePicker_dateOfBirth";
            this.dateTimePicker_dateOfBirth.Size = new System.Drawing.Size(245, 26);
            this.dateTimePicker_dateOfBirth.TabIndex = 5;
            this.dateTimePicker_dateOfBirth.Validating += new System.ComponentModel.CancelEventHandler(this.dateTimePicker_dateOfBirth_Validating);
            // 
            // label_dateOfBirth
            // 
            this.label_dateOfBirth.AutoSize = true;
            this.label_dateOfBirth.Location = new System.Drawing.Point(6, 124);
            this.label_dateOfBirth.Name = "label_dateOfBirth";
            this.label_dateOfBirth.Size = new System.Drawing.Size(94, 20);
            this.label_dateOfBirth.TabIndex = 4;
            this.label_dateOfBirth.Text = "date of birth";
            // 
            // label_surname
            // 
            this.label_surname.AutoSize = true;
            this.label_surname.Location = new System.Drawing.Point(6, 78);
            this.label_surname.Name = "label_surname";
            this.label_surname.Size = new System.Drawing.Size(71, 20);
            this.label_surname.TabIndex = 3;
            this.label_surname.Text = "surname";
            // 
            // label_name
            // 
            this.label_name.AutoSize = true;
            this.label_name.Location = new System.Drawing.Point(6, 37);
            this.label_name.Name = "label_name";
            this.label_name.Size = new System.Drawing.Size(49, 20);
            this.label_name.TabIndex = 2;
            this.label_name.Text = "name";
            // 
            // textBox_surname
            // 
            this.textBox_surname.Location = new System.Drawing.Point(106, 72);
            this.textBox_surname.Name = "textBox_surname";
            this.textBox_surname.Size = new System.Drawing.Size(245, 26);
            this.textBox_surname.TabIndex = 1;
            this.textBox_surname.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_surname_Validating);
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(106, 34);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(245, 26);
            this.textBox_name.TabIndex = 0;
            this.textBox_name.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_name_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 580);
            this.Controls.Add(this.groupBox_employeesDetail);
            this.Controls.Add(this.panel_listboxWIthEmployee);
            this.Name = "Form1";
            this.Text = "Form";
            this.panel_listboxWIthEmployee.ResumeLayout(false);
            this.groupBox_employeesDetail.ResumeLayout(false);
            this.groupBox_employeesDetail.PerformLayout();
            this.panel_TypesOfContract.ResumeLayout(false);
            this.panel_TypesOfContract.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_salary)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_listboxWIthEmployee;
        private System.Windows.Forms.ListBox listBox_list_employee;
        private System.Windows.Forms.GroupBox groupBox_employeesDetail;
        private System.Windows.Forms.Button button_openFile;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Panel panel_TypesOfContract;
        private System.Windows.Forms.RadioButton radioButton_MandateContract;
        private System.Windows.Forms.RadioButton radioButton_TimeContract;
        private System.Windows.Forms.RadioButton radioButton_FullContract;
        private System.Windows.Forms.ComboBox comboBox_position;
        private System.Windows.Forms.NumericUpDown numericUpDown_salary;
        private System.Windows.Forms.Label label_contract;
        private System.Windows.Forms.Label label_position;
        private System.Windows.Forms.Label label_salary;
        private System.Windows.Forms.DateTimePicker dateTimePicker_dateOfBirth;
        private System.Windows.Forms.Label label_dateOfBirth;
        private System.Windows.Forms.Label label_surname;
        private System.Windows.Forms.Label label_name;
        private System.Windows.Forms.TextBox textBox_surname;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

