using System;

namespace PayrollSystem
{
    class Employee
    {
        //variables with public get and set
        public string name
        {
            get;
            set;
        }

        public float salary
        {
            get;
            set;
        }

        public float tax
        {
            get;
            set;
        }

        /// <summary>
        /// class constructor which displays emplyee record created.
        /// </summary>
        public Employee()
        {
            Console.WriteLine("Employee record created");
        }

        /// <summary>
        /// Function to calculate Net Salary of employee
        /// </summary>
        /// <returns>Salary in float</returns>
        public float CalcNet()
        {
            //variable to store salary
            float net;

            //calculating by reducing tax from salary.
            net = salary - (salary * (tax / 100));

            return net;
        }
    }
}
