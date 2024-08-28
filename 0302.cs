/*
Create a C# console application. Consider a scenario where you are designing a system to manage employee information.
 Design a class named "Employee" with the following properties and methods.

a)	Create an instance of the "Employee" class, representing an employee with an ID of 101, full name "John Doe," 
and a salary of 50000.
b)	Access and display the employee ID using the read-only property.
c)	Update the full name of the employee using the read-write property.
d)	Attempt to modify the salary directly from external code (outside the class). Observe and comment on the result.
*/

using System;


namespace Employee
{
    class Employee
    {
        public string FullName { get; set; } = "John Doe";
        private int EmployeeId = 101;
        public double Salary { get; set; } = 50000;

        public int EID
        {
            get { return EmployeeId; }
        }




    }

    class program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.FullName = "Mr John Doe Don";
            employee.Salary = 87000;
            Console.WriteLine("Id: " + employee.EID + "\n" + "Name: " + employee.FullName + "\n" + "Salary: " + employee.Salary);

            Console.ReadKey();
        }
    }
}

