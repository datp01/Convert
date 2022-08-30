﻿using System;
namespace EmployeeInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("INPUT INFORMATION\n=======================");
                Console.Write("\nEnter ID: ");
                string id = Console.ReadLine();

                Console.WriteLine("\nEnter First Name: ");
                string firstName = Console.ReadLine();

                Console.WriteLine("\nEnter Last Name");
                string lastName = Console.ReadLine();

                Console.WriteLine("\nEnter Email");
                string email = Console.ReadLine();

                Console.WriteLine("\nEnter Phone Number: ");
                string phone = Console.ReadLine();

                Console.Write("\nEnter Date of Birth(mm/dd/yyyy");
                DateTime dateofBirth = Convert.ToDateTime(Console.ReadLine());

                Console.Write("\nJoining DAte(mm/dd/yyyy");
                DateTime JoiningDateTime = Convert.ToDateTime(Console.ReadLine());

                Console.WriteLine("\nDESIGNATIONS:\n=======================" +
                    "\n1.Ceo\n2.President\n3.SoftwareEngineer\n4.TrainingEngineer\n5.ProjectManager" +
                    "\n6.SystemEngineer\n7.WebDeveloper\n8.QualityAnalyst");
                Console.Write("\nInput any one serial number of the desginations given above: ");
                    int deg = Int32.Parse(Console.ReadLine());

                Employee anEmployee = new Employee(id, firstName, lastName, email, phone, dateofBirth, JoiningDateTime, deg);
                Console.Write("\nGive roles of the employee(Seperate by coma[,]): ");

                string[] roles = anEmployee.GetRole(Console.ReadLine());

                Console.WriteLine("\n\nOUTPUTS\n======================");
                Console.WriteLine("\nEmployee ID: " + anEmployee.ID + "\nName: " + anEmployee.GetFullName() + "\nDate of Birth: " + anEmployee.JoiningDateTime.ToShortDateString() + "\nDesignation: " + anEmployee.Designation + "\nAge: " + anEmployee.GetAge() + "\n\nRole plays:\n===============");
                for (int i = 0; i < roles.Length; i++)
                {
                    Console.WriteLine((i + 1).ToString() + "." + roles[i].Trim());

                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            doSalary();
            Console.ReadLine();
        }
        static void doSalary()
        {
            Console.WriteLine("\n\nSALARY CALCULATE: \n=======================================");
            Console.WriteLine("Input Basic Salary");
            var bs = Console.ReadLine();
            Salary s = new Salary();
            var bsReturn = s.CalculateSalary(Convert.ToInt32(bs));
            var overTime = s.CalculateSalary(Convert.ToInt32(bs));

            Console.WriteLine(">> Basic Salary:           {0}/= {1} ", s.basicSalary, s.currency);
            Console.WriteLine(">> House Rent:           {0}/= {1} ", s.houserRent, s.currency);
            Console.WriteLine(">> Medical Allowwance:           {0}/= {1} ", s.medicalAllowance, s.currency);
            Console.WriteLine(">>Convetyance Allowance:           {0}/= {1} ", s.conveyance, s.currency);
            Console.WriteLine(">>Over Time:           {0}/= {1} ", overTime, s.currency);
            Console.WriteLine(".............................................");
            Console.WriteLine(">>Gross Salary:           {0}/= {1} ", bsReturn, s.currency);

        }
    }
}
