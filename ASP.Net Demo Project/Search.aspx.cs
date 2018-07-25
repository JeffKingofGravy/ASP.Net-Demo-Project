using System;
using BusinessObjects;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AireSpringProject
{
    public partial class Search : System.Web.UI.Page
    {
        protected void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchTxt.Text;
            int searchBy = radioBtn.SelectedIndex;
            List<Employee> fullEmployeeList = Employee.GetEmployeeList();

            DisplayEmployees(SearchForEmployee(fullEmployeeList, searchTerm, searchBy));
        }

        // This method is tested by the unit test example.
        public static List<Employee> SearchForEmployee(List<Employee> listToSearch, string searchTerm, int searchBy)
        {
            
            List<Employee> searchedList;
            if (searchBy == 0) // Search by Last Name
            {
                searchedList = listToSearch
                    .Where(n => n.LastName == searchTerm)
                    .ToList();
            }
            else // Search by Phone Number
            {
                searchedList = listToSearch
                    .Where(n => (n.PhoneNumber == searchTerm || n.UnformattedPhone == searchTerm)) // Also allow searching by 10 digit format of phone number
                    .ToList();
            }

            return searchedList;
        }

        // Used to bring up the gridview
        protected void DisplayEmployees(List<Employee> listToDisplay)
        {
            EmployeesGV.DataSource = listToDisplay.OrderBy(date => date.HireDate);
            EmployeesGV.DataBind();
        }
    }
}