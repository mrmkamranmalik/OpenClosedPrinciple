using OCPLibrary;
using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    /// <summary>
    /// Open Closed Principle:
    /// Class should be closed for modification and open for extension.
    /// </summary>

    //This application is about converting job applicants to employees.
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>()
            {
                new PersonModel { FirstName = "Malik", LastName = "Kamran"},
                new ManagerModel { FirstName = "Tom", LastName = "Corey" },
                new ExecutiveModel { FirstName = "Nancy", LastName = "Roman" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var applicant in applicants)
            {
                employees.Add(applicant.AccountProcessor.Create(applicant));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"First Name : {emp.FirstName}");
                Console.WriteLine($"Last Name : {emp.LastName}");
                Console.WriteLine($"Email : {emp.EmailAddress}");
                Console.WriteLine($"Is Manager : {emp.IsManager}");
                Console.WriteLine($"Is Executive : {emp.IsExecutive}");
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
