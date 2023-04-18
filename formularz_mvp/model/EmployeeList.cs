using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace formularz_mvp.model
{
    public class EmployeeList
    {
        private List<Employee> _employees;

        public EmployeeList()
        {
            _employees = new List<Employee>();
        }

        public void Add(Employee employee)
        {
            _employees.Add(employee);
        }

        public List<Employee> GetAll()
        {
            return _employees;
        }


        public void SaveEmployeesToXmlFile()
        {

            List<Employee> list = GetAll();

            string projectDirectoryPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            string filePath = Path.Combine(projectDirectoryPath, "files", "employees.xml");


            if (!Directory.Exists(projectDirectoryPath))
            {
                Directory.CreateDirectory(projectDirectoryPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }

            Stream stream = File.OpenWrite(filePath);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            serializer.Serialize(stream, list);
            stream.Close();


            // Gdybyśy chcieli dopisywać zamiast nadpisywać:

            //List<Employee> list = _view.GetAllEmployees();
            //string projectDirectoryPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
            //string filePath = Path.Combine(projectDirectoryPath, "files", "employees.xml");

            //if (!Directory.Exists(projectDirectoryPath))
            //{
            //    Directory.CreateDirectory(projectDirectoryPath);
            //}

            //using (StreamWriter writer = new StreamWriter(filePath, true))
            //{
            //    XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
            //    serializer.Serialize(writer, list);
            //}

        }

        public void Read()
        {
            try
            {
                string projectDirectoryPath = new DirectoryInfo(AppDomain.CurrentDomain.BaseDirectory).Parent.Parent.FullName;
                string filePath = Path.Combine(projectDirectoryPath, "files", "employees.xml");
                XmlSerializer serializer = new XmlSerializer(typeof(List<Employee>));
                using (StreamReader sr = new StreamReader(filePath))
                {
                    _employees = (List<Employee>)serializer.Deserialize(sr);
                }
                MessageBox.Show("Wczytano pomyślnie!");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
