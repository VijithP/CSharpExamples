using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramOperatorOverloading
    {

        
        public static void MainOperator(string[] args)
        {
            ImmiEmployee emp1 = new ImmiEmployee();

            emp1.EmployeeId = 1001;
            emp1.Name = "Vijith";
            emp1.BasicSalry = 10000;
            emp1.Pf = 1100;
            emp1.VariablePay = 1500;

            //int totalSalary = emp1.TotalSalary();

            //Console.WriteLine("Total Salary = {0}", totalSalary);

            //Unary operations

            ImmiEmployee empUn = new ImmiEmployee();
            empUn = +emp1 ;
            Console.WriteLine("Unary operations");
            Console.WriteLine("Basic Salary = {0} \n Pf ={1} \n Variable Pay= {2} \n "
                , empUn.BasicSalry, empUn.Pf, empUn.VariablePay
                );



            //Postfix Operations
            ImmiEmployee empPo = new ImmiEmployee();
            empPo = emp1++;
            Console.WriteLine("Postfix Expression");
            Console.WriteLine("Basic Salary ={0} \n  Pf={1}  \n Variable Pay= {2} \n"
                , empPo.BasicSalry
                , empPo.Pf
                , empPo.VariablePay

                );


            //Prefix Operations
            ImmiEmployee empPre = new ImmiEmployee();
            empPre = ++emp1;
            Console.WriteLine("Prefix Expression");
            Console.WriteLine("Basic Salary ={0} \n  Pf={1}  \n Variable Pay= {2} \n"
                , empPre.BasicSalry
                , empPre.Pf
                , empPre.VariablePay

                );

         

            






            //Binary Operations

            ImmiEmployee emp2 = new ImmiEmployee();

            emp2.EmployeeId = 1005;
            emp2.Name = "Anoop";
            emp2.BasicSalry = 15000;
            emp2.Pf = 1500;
            emp2.VariablePay = 3500;


            ImmiEmployee emp3 = new ImmiEmployee();
            emp3 = emp1 + emp2;

            Console.WriteLine("Employee Details");
            Console.WriteLine("Employee Id ={0} \n " +
                "Name ={1} \n " +
                "Basic Salary ={2} \n " +
                "Pf={3} \n " +
                "Variable Pay ={4}",
                 emp3.EmployeeId,
                 emp3.Name,
                 emp3.BasicSalry,
                 emp3.Pf,
                 emp3.VariablePay                 
                );


            //comparison operator

            if(emp1>emp2)
            {
                Console.WriteLine("Employee 1 > Employee 2");

            }

            else if (emp1<emp2)
            {

                Console.WriteLine("Employee 1 < Employee 2");
            }

           


            Console.ReadKey();

        }




    }

   public class ImmiEmployee
    {

        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public int BasicSalry { get; set; }
        public int VariablePay { get; set; }
        public int Pf { get; set; }


        public int TotalSalary()
        {
            return (this.BasicSalry + this.VariablePay + this.Pf);

        }

        //prefix operator
        public static ImmiEmployee operator + (ImmiEmployee iEmp)
        {

            ImmiEmployee emp = new ImmiEmployee();
            emp.BasicSalry = -(iEmp.BasicSalry);
            emp.Pf = -(iEmp.Pf);
            emp.VariablePay = -(iEmp.VariablePay);
            return emp;


        }


        
        //Prefix Expression - postfix expression

        public static ImmiEmployee  operator ++ (ImmiEmployee iEmp)
        {

            ImmiEmployee emp = new ImmiEmployee();
            emp.BasicSalry = (iEmp.BasicSalry)++;
            emp.Pf = (iEmp.Pf)++;
            emp.VariablePay = (iEmp.VariablePay)++;
            return emp;
            
        }


        //binary operation
        public static ImmiEmployee operator + (ImmiEmployee im1,ImmiEmployee im2)
        {

            ImmiEmployee imt = new ImmiEmployee();

            imt.BasicSalry = im1.BasicSalry + im2.BasicSalry;
            imt.VariablePay = im1.VariablePay + im2.VariablePay;
            imt.Pf = im1.Pf + im2.Pf;

            return imt;

        }

        //Compare Operation

        public static bool operator > (ImmiEmployee iEmp1,ImmiEmployee iEmp2)
        {
            bool result = false;           
            if (iEmp1.BasicSalry > iEmp2.BasicSalry ) { result = true; }
            return result;

        }


        public static bool operator <(ImmiEmployee iEmp1, ImmiEmployee iEmp2)
        {
            bool result = false;
            if (iEmp1.BasicSalry < iEmp2.BasicSalry ) { result = true; }
            return result;

        }


        public static bool operator >= (ImmiEmployee iEmp1, ImmiEmployee iEmp2)
        {
            bool result = false;
            if (iEmp1.BasicSalry >= iEmp2.BasicSalry) { result = true; }
            return result;

        }



        public static bool operator <=(ImmiEmployee iEmp1, ImmiEmployee iEmp2)
        {
            bool result = false;
            if (iEmp1.BasicSalry >= iEmp2.BasicSalry) { result = true; }
            return result;

        }




    }


}
