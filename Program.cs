using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Salarycalc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter employee email");
            string email = Console.ReadLine();
            Console.WriteLine("Choose employee type:");
            Console.WriteLine("1. HR");
            Console.WriteLine("2. Admin");
            Console.WriteLine("3. Software Developer");
            int employeeType = int.Parse(Console.ReadLine());
            double monthlySalary = CalcMonthlySalary(employeeType);
            Console.WriteLine("Employee Email:"+email);
            Console.WriteLine("Monthly Salary:$"+monthlySalary);
            Console.ReadKey();
        }
        static double 
            CalcMonthlySalary(int employeeType, int wHour = 0, int wDays =0, int projectHandles = 0, int extras = 0)
        {
            double baseSalary = 0;
            switch(employeeType)
            {
                case 1: //HR
                    baseSalary = 100;
                    break;
                case 2: //Admin
                    baseSalary = 100;
                    break;
                case 3: //Software Developer
                    baseSalary = 100;
                    break;
                default:
                    Console.WriteLine("Invalid employee type");
                    return 0;
            }
             double salary = baseSalary + (wHour * wDays) + (projectHandles * 3000)+(extras*2000);
            return salary;
        }

    }
}
