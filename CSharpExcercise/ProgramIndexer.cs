using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramIndexer
    {
        public static void MainPI(string[] args)
        {
            SEEmployee seEmployee = new SEEmployee();

            Console.WriteLine("Employee Details");
            Console.WriteLine("EmployeeId={0} , Name={1}", seEmployee[1].EmployeeId, seEmployee[1].Name);
            Console.WriteLine("EmployeeId={0} , Name={1}", seEmployee[2].EmployeeId, seEmployee[2].Name);
            Console.WriteLine("EmployeeId={0} , Name={1}", seEmployee[3].EmployeeId, seEmployee[3].Name);
            Console.WriteLine("EmployeeId={0} , Name={1}", seEmployee[4].EmployeeId, seEmployee[4].Name);
            Console.WriteLine("EmployeeId={0} , Name={1}", seEmployee[5].EmployeeId, seEmployee[5].Name);
            Console.WriteLine("EmployeeId={0} , Name={1}", seEmployee[6].EmployeeId, seEmployee[6].Name);

            Console.ReadKey();

        }

    }

    class Emp1
    {
        public int EmployeeId { set; get; }
        public string Name { set; get; }

    }

    class SEEmployee
    {
        

        List<Emp1> seEmployee = new List<Emp1>();
        public SEEmployee()
        {
            seEmployee.Add(new Emp1() {EmployeeId=1,Name="Arun" });
            seEmployee.Add(new Emp1() { EmployeeId = 2, Name = "Babin" });
            seEmployee.Add(new Emp1() { EmployeeId = 3, Name = "Cena" });
            seEmployee.Add(new Emp1() { EmployeeId = 4, Name = "Manoj" });
            seEmployee.Add(new Emp1() { EmployeeId = 5, Name = "Karthik" });
            seEmployee.Add(new Emp1() { EmployeeId = 6, Name = "sini" });

        }

        public Emp1 this[int employeeId]
        {
            get
            {
                return seEmployee.FirstOrDefault(emp => emp.EmployeeId == employeeId);
            }
        }






    }




}
