using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task09
{
    internal class Child : Parent
    {
        public sealed override int Salary
        {
            get { return base.Salary; }
            set { base.Salary = value; }
        }

        public void DisplaySalary()
        {
            Console.WriteLine($"Salary: {Salary}");
        }
    }
}
