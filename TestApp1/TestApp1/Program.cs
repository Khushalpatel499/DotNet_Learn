using System;



     class Program
    {
        static void Main(string[] args)
        {
        // int empid= 10;
        //string empname= "Ram";
        //double empsalary = 1000.8;
        //Console.WriteLine("Emp id is" +empid);
        //Console.WriteLine("Emp Name is" +empname);
        //Console.WriteLine("Emp Salary is" +empsalary);
        //Console.WriteLine("Welcome to C#");

        int id;
        string name;
        double salary;

        Console.WriteLine("Enter the Emp Id:");
        id = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the Emp Name:");
        name = Console.ReadLine();

        Console.WriteLine("Enter the Emp Salary:");
        salary=double.Parse(Console.ReadLine());

        Console.WriteLine("Emp id is" + id);
        Console.WriteLine("Emp Name is" +name);
        Console.WriteLine("Emp Salary is" +salary);

        //string interpolation
        Console.WriteLine($"Emp id is: {id}");
        Console.ReadKey();//to hold output screen
        }
    }

