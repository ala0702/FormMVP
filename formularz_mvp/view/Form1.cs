using formularz_mvp.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace formularz_mvp.view
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Set the data source for the position combo box
            comboBox_position.DataSource = Enum.GetValues(typeof(Position));
        }

        #region Public interface of view

        public event Action<string, string, DateTime, decimal, Position, TypeOfContract> AddEmployee;
        public event Action<int> GetSelectedEmployee;
        public event Action SaveEmployeesToXmlFile;
        public event Action LoadEmployeesFromFile;

        public void ShowMessage(string message) => MessageBox.Show(message);

        public void Clear_List_Employees()
        {
            listBox_list_employee.Items.Clear();
        }
        public void AddItemToListBox(object item)
        {
            listBox_list_employee.Items.Add(item);
        }

        public List<Employee> GetAllEmployees()
        {
            var employees = new List<Employee>();
            foreach (var item in listBox_list_employee.Items)
            {
                employees.Add((Employee)item);
            }
            return employees;
        }

        public string ListBoxText
        {
            set
            {
                listBox_list_employee.Text = value;
            }
            get
            {
                return listBox_list_employee.Text;
            }
        }

        public string GroupBoxText
        {
            set
            {
                groupBox_employeesDetail.Text = value;
            }
            get
            {
                return groupBox_employeesDetail.Text;
            }
        }

        public bool RadioButtonMandateSelected
        {
            set
            {
                radioButton_MandateContract.Checked = value;
            }
            get
            {
                return radioButton_MandateContract.Checked;
            }
        }

        public bool RadioButtonTimeSelected
        {
            set
            {
                radioButton_TimeContract.Checked = value;
            }
            get
            {
                return radioButton_TimeContract.Checked;
            }
        }

        public bool RadioButtonFullSelected
        {
            set
            {
                radioButton_FullContract.Checked = value;
            }
            get
            {
                return radioButton_FullContract.Checked;
            }
        }

        public Position ComboBoxPosition
        {
            set
            {
                foreach (Position item in comboBox_position.Items)
                {
                    if (item == value)
                    {
                        comboBox_position.SelectedItem = item;
                        break;
                    }
                }
            }

            get
            {
                return (Position)comboBox_position.SelectedItem;
            }
        }

        public decimal NumericUpDownSalary
        {
            set
            {
                numericUpDown_salary.Value = value;
            }
            get
            {
                return numericUpDown_salary.Value;
            }
        }

        public DateTime DateOfBirthPicker
        {
            set
            {
                dateTimePicker_dateOfBirth.Value = value;
            }
            get
            {
                return dateTimePicker_dateOfBirth.Value;
            }
        }

        public string TextBoxSurname
        {
            set
            {
                textBox_surname.Text = value;
            }
            get
            {
                return textBox_surname.Text;
            }
        }

        public string TextBoxName
        {
            set
            {
                textBox_name.Text = value;
            }
            get
            {
                return textBox_name.Text;
            }
        }

        #endregion

        public void ClearForm()
        {
            // Clear textboxes
            textBox_name.Clear();
            textBox_surname.Clear();

            // Reset numeric up-down
            numericUpDown_salary.Value = 0;

            // Reset radio buttons
            radioButton_FullContract.Checked = false;
            radioButton_TimeContract.Checked = false;
            radioButton_MandateContract.Checked = false;

            // Reset combo box
            comboBox_position.SelectedIndex = -1;

            // Reset date time picker
            dateTimePicker_dateOfBirth.Value = DateTime.Today;
        }

        public void ClearListBoxIndex()
        {
            listBox_list_employee.ClearSelected();
        }


        public void AddEmployeeToListBox(object employee)
        {
            //listBox_list_employee.Items.Add(employee);
            listBox_list_employee.Items.Add(employee.ToString());
        }


        void Get_Employee_From_ListBox(object sender, EventArgs e)
        {
                int selectedIndex = listBox_list_employee.SelectedIndex;
                //string my = selectedIndex.ToString();
                //ShowMessage(my);
                GetSelectedEmployee?.Invoke(selectedIndex);

        }


        void Add_Employee(object sender, EventArgs e)
        {

            if (ValidateChildren())
            {

                string name = textBox_name.Text.Trim();
                string surname = textBox_surname.Text.Trim();
                DateTime dateOfBirth = dateTimePicker_dateOfBirth.Value;
                int salary = (int)numericUpDown_salary.Value;

                // Set default values for position and contract type
                Position position = Position.Tester;

                if (comboBox_position.SelectedItem != null)
                {
                    position = (Position)comboBox_position.SelectedItem;
                }

               // panel_TypesOfContract_Validating(panel_TypesOfContract, new CancelEventArgs());

                TypeOfContract contractType = TypeOfContract.UnknownContract; ;


                if (radioButton_FullContract.Checked)
                {
                    contractType = TypeOfContract.FullContract;
                }
                else if (radioButton_TimeContract.Checked)
                {
                    contractType = TypeOfContract.TimeContract;
                }
                else if (radioButton_MandateContract.Checked)
                {
                    contractType = TypeOfContract.MandateContract;
                }
                else
                {
                    errorProvider1.SetError(panel_TypesOfContract, "you have to choose one of three options");
                    return;
                }

                // All fields are valid, invoke the AddEmployee event
                AddEmployee?.Invoke(name, surname, dateOfBirth, salary, position, contractType);
                ClearForm();
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            SaveEmployeesToXmlFile?.Invoke();
            ClearListBoxIndex();

        }

        private void button_openFile_Click(object sender, EventArgs e)
        {
            LoadEmployeesFromFile?.Invoke();
        }



        // validating functions
        private void textBox_name_Validating(object sender, CancelEventArgs e)
        {
            string name = textBox_name.Text.Trim();
            if (string.IsNullOrEmpty(name))
            {
                errorProvider1.SetError(textBox_name, "Please enter a name");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox_name, "");
            }
        }

        private void textBox_surname_Validating(object sender, CancelEventArgs e)
        {
            string surname = textBox_surname.Text.Trim();
            if (string.IsNullOrEmpty(surname))
            {
                errorProvider1.SetError(textBox_surname, "Please enter a surname");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(textBox_surname, "");
            }

        }

        private void dateTimePicker_dateOfBirth_Validating(object sender, CancelEventArgs e)
        {
            DateTime dateOfBirth = dateTimePicker_dateOfBirth.Value;
            if (dateOfBirth == null)
            {
                errorProvider1.SetError(dateTimePicker_dateOfBirth, "Please select a date of birth");
                e.Cancel = true;
            }
            else if (dateOfBirth > DateTime.Now)
            {
                errorProvider1.SetError(dateTimePicker_dateOfBirth, "Please select date, which is not in the future");
                e.Cancel = true;

            }
            else
            {
                errorProvider1.SetError(dateTimePicker_dateOfBirth, "");
            }
            
        }

        private void numericUpDown_salary_Validating(object sender, CancelEventArgs e)
        {
            int salary = (int)numericUpDown_salary.Value;
            if (salary <= 0)
            {
                errorProvider1.SetError(numericUpDown_salary, "Please enter a valid salary");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(numericUpDown_salary, "");
            }

        }

        private void comboBox_position_Validating(object sender, CancelEventArgs e)
        {
            string position = comboBox_position.Text.Trim();
            if (string.IsNullOrEmpty(position))
            {
                errorProvider1.SetError(comboBox_position, "Please select a position");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(comboBox_position, "");
            }

        }

        private void panel_TypesOfContract_Validating(object sender, CancelEventArgs e)
        {
            if (!this.radioButton_FullContract.Checked && !this.radioButton_TimeContract.Checked && !this.radioButton_MandateContract.Checked)
            {
                errorProvider1.SetError(panel_TypesOfContract, "Please select a contract type");
                e.Cancel = true;
            }
            else
            {
                errorProvider1.SetError(panel_TypesOfContract, "");
                e.Cancel = false;
            }
        }
    }
}
