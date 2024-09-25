using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Find Emp Salary based on 10% pf
            string ename;
            double esalary, pf, netsalary;

            Console.WriteLine("Enter the Emp Name:");
            ename = Console.ReadLine();

            Console.WriteLine("Enter the Salary:");
            esalary = double.Parse(Console.ReadLine());

            pf = esalary * 0.1;

            netsalary = esalary - pf;
            Console.WriteLine($"Emp Name is {ename}");
            Console.WriteLine($"Emp Basic salary is {esalary}");
            Console.WriteLine($"Emp pf amount is {pf}");
            Console.WriteLine($"Emp netsalary is {netsalary}");

            int x=5;
            long y=x;// Implicit type casting
            Console.WriteLine($"Value of x is {x} and value of y is{y}");
            
            double d=23.5;
            int f=(int)d;//explicit type casting
             Console.WriteLine($"Value of d is {d} and value of f is{f}");
            Console.ReadKey();


            
           
        }
    }
}
