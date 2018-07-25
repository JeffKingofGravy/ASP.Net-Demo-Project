using BusinessObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AireSpringProject
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

        // Creates Employee from form and passes it along to be added to the list by the Employee class
        protected void SubmitEmployee()
        {
            Employee emp = new Employee(
                IDGenChk.Checked ? fullList.Count + 1 : Int32.Parse(IDTxt.Text),
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
            EmployeesGV.DataSource = listToDisplay.OrderBy(date => date.HireDate);
            EmployeesGV.DataBind();
        }
    }
}