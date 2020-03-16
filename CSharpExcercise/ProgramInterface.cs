using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{




    interface IPartialEmployee
    {
         void Salary();
    }
    interface IFullTimeEmployee
    {
        void FullSalary();

    }


    class ProgramInterface : IPartialEmployee,IFullTimeEmployee
    {
        public void Salary()
        {
            Console.WriteLine("Partial Employee Salary =3000");
        }

        public void FullSalary()
        {
            Console.WriteLine("Full Time Employee Salary =3000");
        }


    }
}
