
/*
 Name=Priyanka Dhakal
 Student ID=30001935
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace pra
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**********************************");
            Console.WriteLine(" Welcome to employee system");
            Console.WriteLine("++++++++++++++++++++++++++++++++++");
            //Create an employee object and populating it with the variables where we saved the employees info.
            Employee p1 = new Employee("n/a", 0, 0);





            // detail of employee 
            Console.Write(" Enter the employee name: ");
            p1.Name = Console.ReadLine();


            Console.Write($"Please enter {p1.Name} Gross annual income: ");
            p1.Gross = double.Parse(Console.ReadLine());

            Console.Write($"Please enter {p1.Name} tax rate: ");
            p1.Tax = double.Parse(Console.ReadLine());





            //information display 
            Console.WriteLine($"Name: {p1.Name} \nTax: {p1.Tax}%\nGross Salary: {p1.Gross}\nNet Salary: {p1.Net()}");
            Console.WriteLine("**************************");
            Console.WriteLine("THE END");
            Console.WriteLine("++++++++++++++++++++++++");

            Console.WriteLine("press enter to continue");

            Console.ReadLine();
        }
    }

    class Employee
    {
        //3 auto implemented properties
        public string Name { get; set; }
        public double Gross { get; set; }
        public double Tax { get; set; }



        //Constructor
        public Employee(string _name, double _gross, double _tax)
        {
            Name = _name;
            Tax = _tax;
            Gross = _gross;
            Console.WriteLine("++++++++++++++++++++++++");
            Console.WriteLine("Employee class created");
            Console.WriteLine("++++++++++++++++++++++++");
        }

        // Calculate the employee net salary after tax 
        public double Net()
        {
            return Gross * (1 - Tax / 100);
        }
    }
}

