using System;

namespace Sample_12
{
    public struct Employee
    {
        public int EmployeeId;
        public string EmployeeNme;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee;
            employee.EmployeeId = 101;
            employee.EmployeeNme = "shreys";
            Console.Write(employee.EmployeeId + "\t" + employee.EmployeeNme);
            Console.ReadLine();
        }
    }
}
