using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EmployeeProcessing
{
    public partial class Form1 : Form
    {
        private delegate void EmployeeProcessor(Employee employee);  //define delegate
        private List<Employee> Employees = new List<Employee>();

        private void ListEmployee(Employee employee)                 //method with delegate signature
        {
            employeeListBox.Items.Add(
                employee.Name + ", " +
                employee.Title + ", " +
                employee.Salary.ToString("C"));
        }

        private void ProcessEmployees(EmployeeProcessor process)     //method that takes a delegate as a param
        {
            foreach (var employee in Employees)
            {
                process(employee);                                  //process a single employee based on delegate
            }
        }

        private void ShowEmployees()
        {
            employeeListBox.Items.Clear();
            ProcessEmployees(ListEmployee);                         //pass delegate 
        }
        private void MakeEmployees()
        {
            Employees.Add(new Employee
            {
                Name = "Anthony Hollis",
                Title = "Engineer",
                Salary = 175000m
            });

            Employees.Add(new Employee
            {
                Name = "Chris Jansen",
                Title = "CFO",
                Salary = 220000m
            });

            Employees.Add(new Employee()
            {
                Name = "Jessica Lyndon",
                Title = "Prod Manager",
                Salary = 145000m
            });

            Employees.Add(new Employee()
            {
                Name = "Veronica Blake",
                Title = "QA Specialist",
                Salary = 86497m
            });
        }

        private void GiveRaise(Employee employee)
        {
            employee.Salary *= 1.1m;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MakeEmployees();
            ShowEmployees();
        }

        private void GiveRaiseBtn_Click(object sender, EventArgs e)
        {
            ProcessEmployees(GiveRaise);
            ShowEmployees();
        }
    }
}
