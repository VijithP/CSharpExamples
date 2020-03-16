using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramMethodOverriding
    {
        public ProgramMethodOverriding()
        {
            Employee E = new PartialEmployee();
            E.PrintEmployeeType();

            E=new FullTimeEmployee();
            E.PrintEmployeeType();


        }


    }

    public class Employee
    {
        public virtual void PrintEmployeeType()
        {
            Console.WriteLine("Employee");
        }
    }


    public class PartialEmployee:Employee
    {
        public override void PrintEmployeeType()
        {
            Console.WriteLine("Partial Employee");
        }
    }


    public class FullTimeEmployee : Employee
    {
        public override void PrintEmployeeType()
        {
            Console.WriteLine("FullTime Employee");
        }
    }
}
