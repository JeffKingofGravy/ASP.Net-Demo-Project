using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP.Net_Demo_Project
{
    public partial class AddEmployee : System.Web.UI.Page
    {
        List<Employee> fullList;

        // Display the current list of employees
        protected void Page_Load(object sender, EventArgs e)
        {
            fullList = Employee.GetEmployeeList();
            DisplayEmployees(fullList);
        }
        
        protected void SubmitBtn_Click(object sender, EventArgs e)
        {
            SubmitEmployee();
        }

        // Take the list of employees and create a new ID that is one greater than the highest in the list.
        protected int GenerateID(List<Employee> employees)
        {
            List<int> ids = employees.Select(id => id.EmployeeID).ToList();
            int newID = ids.Max() + 1;

            return newID;
        }

        // Creates Employee from form and passes it along to be added to the list by the Employee class
        protected void SubmitEmployee()
        {
            // If the auto-gen check is selected it gets an ID from the GenerateID method or just uses the text field.
            int newID = IDGenChk.Checked ? GenerateID(fullList) : Int32.Parse(IDTxt.Text);

            Employee emp = new Employee(
                newID, 
                FirstTxt.Text,
                LastTxt.Text,
                PhoneTxt.Text,
                ZipTxt.Text,
                DateTime.Parse(HireTxt.Text));

            Employee.SubmitEmployeeJSON(emp);

            // After being added, bring back the new full list and show it
            fullList = Employee.GetEmployeeList();
            DisplayEmployees(fullList);
        }

        // Used to bring up the gridview
        protected void DisplayEmployees(List<Employee> listToDisplay)
        {
            EmployeesGV.DataSource = listToDisplay.OrderBy(date => date.HireDate); // List is sorted by hire date
            EmployeesGV.DataBind();
        }
    }
}