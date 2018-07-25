using System;
using ASP.Net_Demo_Project;
using BusinessObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ASP.Net_Testing_Example
{
    [TestClass]
    public class UnitTest1
    {
        // Displaying basic testing capabilities

        [TestMethod]
        public void SearchEmployee_FoundByLastName()
        {
            List<Employee> listToCheck = new List<Employee>
            {
                new Employee(1, "Bruce", "Wayne", "(555)123-1234", "12345", DateTime.Parse("2017-01-16T00:00:00")),
                new Employee(2, "Richard", "Grayson", "(555)234-2345", "12345", DateTime.Parse("2017-02-17T00:00:00")),
                new Employee(3, "Jason", "Todd", "(555)345-3456", "12345", DateTime.Parse("2017-03-18T00:00:00"))
            };

            List<Employee> expectedResult = new List<Employee>
            {
                new Employee(2, "Richard", "Grayson", "(555)234-2345", "12345", DateTime.Parse("2017-02-17T00:00:00"))
            };

            List<Employee> searchedList = Search.SearchForEmployee(listToCheck, "Grayson", 0);

            Assert.IsTrue(expectedResult[0].EmployeeID == searchedList[0].EmployeeID, "Error");
        }

        [TestMethod]
        public void SearchEmployee_FoundByPhoneNumber()
        {
            List<Employee> listToCheck = new List<Employee>
            {
                new Employee(1, "Bruce", "Wayne", "(555)123-1234", "12345", DateTime.Parse("2017-01-16T00:00:00")),
                new Employee(2, "Richard", "Grayson", "(555)234-2345", "12345", DateTime.Parse("2017-02-17T00:00:00")),
                new Employee(3, "Jason", "Todd", "(555)345-3456", "12345", DateTime.Parse("2017-03-18T00:00:00"))
            };

            List<Employee> expectedResult = new List<Employee>
            {
                new Employee(2, "Richard", "Grayson", "(555)234-2345", "12345", DateTime.Parse("2017-02-17T00:00:00"))
            };

            List<Employee> searchedList = Search.SearchForEmployee(listToCheck, "(555)234-2345", 1);

            Assert.IsTrue(expectedResult[0].EmployeeID == searchedList[0].EmployeeID, "Error");
        }
    }
}
