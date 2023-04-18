using formularz_mvp.model;
using formularz_mvp.view;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace formularz_mvp.presenter
{
    class MainPresenter
    {
        private view.Form1 _view;
        private model.EmployeeList _modelList;
        private model.Employee _modelEmployee;

        public MainPresenter(view.Form1 view, model.EmployeeList modelEmployeeList, model.Employee modelEmployee)
        {
            _view = view;
            _modelList = modelEmployeeList;
            _modelEmployee = modelEmployee;


            _view.AddEmployee += _view_AddEmployee;
            _view.GetSelectedEmployee += _view_GetSelectedEmployee;
            _view.SaveEmployeesToXmlFile += _view_SaveEmployeesToXmlFile;
            _view.LoadEmployeesFromFile += _view_LoadEmployeesFromFile;
        }

        public void SetFormValues(Form1 view)
        { 

            view.TextBoxName = _modelEmployee.Name;
            view.TextBoxSurname = _modelEmployee.Surname;
            view.DateOfBirthPicker = _modelEmployee.Birthdate;
            view.NumericUpDownSalary = _modelEmployee.Salary;
            view.ComboBoxPosition = _modelEmployee.Position;
            view.RadioButtonFullSelected = (_modelEmployee.TypeOfContract == TypeOfContract.FullContract);
            view.RadioButtonTimeSelected = (_modelEmployee.TypeOfContract == TypeOfContract.TimeContract);
            view.RadioButtonMandateSelected = (_modelEmployee.TypeOfContract == TypeOfContract.MandateContract);
        }

        private void _view_LoadEmployeesFromFile()
        {
            try
            {
                _modelList.Read();
                _view.Clear_List_Employees();
                foreach (Employee employee in _modelList.GetAll())
                {
                    _view.AddItemToListBox(employee.ToString());
                }
            }
            catch (Exception ex)
            {
                _view.ShowMessage("Błąd podczas wczytywania danych: " + ex.Message);
            }

        }

        private void _view_SaveEmployeesToXmlFile()
        {
            _modelList.SaveEmployeesToXmlFile();
        }

        public int GetListCount()
        {
            return _modelList.GetAll().Count;
        }


        private void _view_GetSelectedEmployee(int index)
        {
            if (index >= 0)
            {
                Employee selectedEmployee = _modelList.GetAll()[index];
                if (selectedEmployee != null)
                {
                    _modelEmployee = selectedEmployee;
                    SetFormValues(_view);
                }
            }
            _view.ClearListBoxIndex();

        }

        private void _view_AddEmployee(string name, string surname, DateTime dateOfBirth, decimal salary, Position position, TypeOfContract contractType)
        {
            // Create a new Employee object with the provided data
            Employee newEmployee = new Employee(name, surname, dateOfBirth, salary, position, contractType);

            _modelList.Add(newEmployee);

            _view.AddEmployeeToListBox(newEmployee.ToString());
        }


    }
}