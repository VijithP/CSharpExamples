using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramFactoryPattern
    {

        public static void MainFact(string[] args)
        {
            var obj=  Factory.EmpSalary(1);
            obj.Salary();

            obj=Factory.EmpSalary(2);
            obj.Salary();

            obj =Factory.EmpSalary(3);
            obj.Salary();

            Console.ReadKey();
        }

    }
    
    abstract class Employees
    {
        public abstract void Salary();
    }

    class PermenantEmployee:Employees
    {
        public override void Salary()
        {
            Console.WriteLine("Permenat Employee =25000");
        }

    }

    class ContractEmployee : Employees
    {
        public override void Salary()
        {
            Console.WriteLine("Contract Employee =15000");
        }
    }

    class PartTimeEmployee : Employees
    {
        public override void Salary()
        {
            Console.WriteLine("PartTime Employee = 10000");

        }
    }

    static class Factory
    {
        public static  Employees EmpSalary(int id)
        {
            
            switch(id)
            {
                
                case 1:return new PermenantEmployee();
                case 2:return new ContractEmployee();
                case 3:return new PartTimeEmployee();
                default: return new PartTimeEmployee();
            }
        }
    }



}
