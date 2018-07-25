using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Web;
using Newtonsoft.Json.Linq;

namespace BusinessObjects
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FullName { get { return $"{FirstName} {LastName}"; } }
        public string PhoneNumber { get; set; }
        public string UnformattedPhone { get { return new string(PhoneNumber.Where(char.IsDigit).ToArray()); } } // To allow working with 10 digits
        public string Zip { get; set; }
        public DateTime HireDate { get; set; }

        public Employee()
        {

        }

        public Employee(
            string firstName,
            string lastName,
            string phoneNumber,
            string zip,
            DateTime hireDate)
        {
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Zip = zip;
            HireDate = hireDate;
        }

        public Employee(
            int employeeID,
            string firstName,
            string lastName,
            string phoneNumber,
            string zip,
            DateTime hireDate)
        {
            EmployeeID = employeeID;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            Zip = zip;
            HireDate = hireDate;
        }

        // Submits the employee through what would be a Data Access Layer. My syntax is based on the last layer that I worked with.
        public static void SubmitEmployee(Employee emp)
        {
            //DataAccessLayer.Execute.InsertEmployees(
            //    emp.FirstName,
            //    emp.LastName,
            //    emp.PhoneNumber,
            //    emp.Zip,
            //    emp.HireDate);
        }

        // Adds an employee to the existing full list
        public static void SubmitEmployeeJSON(Employee emp)
        {
            // Deserialize list of employees
            List<Employee> list = GetEmployeeList();

            // Add new employee to list
            list.Add(emp);

            // Rebuild the JSON file with added employee
            SetEmployeeList(list);
        }

        // Write a given list to JSON Employee storage. Rewrites whole list.
        public static void SetEmployeeList(List<Employee> listToWrite)
        {
            JsonSerializer serializer = new JsonSerializer();
            string path = HttpContext.Current.Server.MapPath("~"); // Relative path to JSON file
            using (StreamWriter sw = new StreamWriter(path + "/Storage/Employees.json"))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                writer.Formatting = Formatting.Indented;
                serializer.Serialize(writer, listToWrite);
            }
        }

        public static List<Employee> GetEmployeeList()
        {
            // If using a proper connection, this would grab the full list of employees from the table
            //DataAccessLayer.Execute.GetEmployees(); 

            List<Employee> empList;
            string path = HttpContext.Current.Server.MapPath("~"); // Relative path to JSON file
            using (StreamReader file = File.OpenText(path + "/Storage/Employees.json"))
            {
                string stuff = file.ReadToEnd();
                JsonSerializer serializer = new JsonSerializer();
                empList = JsonConvert.DeserializeObject<List<Employee>>(stuff);
            }

            return empList;

        }
    }
}
