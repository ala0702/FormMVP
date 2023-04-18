

using System;

namespace formularz_mvp.model
{
    public enum Position { Tester, Designer, Engineer, JuniorProgrammer, SeniorProgrammer }
    public enum TypeOfContract { FullContract, TimeContract, MandateContract, UnknownContract }
    public class Employee
    {

        private string _name;
        private string _surname;
        private DateTime _birthdate;
        private decimal _salary;
        private Position _position;
        private TypeOfContract _typeOfContract;

        public Employee(string name, string surname, DateTime birthdate, decimal salary, Position position, TypeOfContract typeOfContract)
        {
            _name = name;
            _surname = surname;
            _birthdate = birthdate;
            _salary = salary;
            _position = position;
            _typeOfContract = typeOfContract;
        }

        public Employee() { }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Surname
        {
            get { return _surname; }
            set { _surname = value; }

        }

        public DateTime Birthdate
        {
            get { return _birthdate; }
            set { _birthdate = value; }
        }

        public decimal Salary
        {
            get { return _salary; }
            set { _salary = value; }
        }

        public TypeOfContract TypeOfContract
        {
            get { return _typeOfContract; }
            set { _typeOfContract = value; }
        }

        public Position Position
        {
            get { return _position; }
            set { _position = value; }
        }


        public override string ToString()
        {
            string employeeInfo = $"Name: {_name}, Surname: {_surname}, Date of birth: {Birthdate:d}, Position: {Position}, Salary:{_salary:c}, Type of Contract: {TypeOfContract}";
            return employeeInfo;
        }

    }
}