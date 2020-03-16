using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramConnectedClass
    {
        public static void MainCN(string[] args)
        {
            try
            {

                //access base class property to derived class derived class object.
                StudentDet dt = new StudentDet();
                dt.StudentId = 121;
                dt.Name = "Abishek";
                dt.PrintName();

                //we cannot call method of inside class through out side object
                Student9 st9 = new Student9();
                //  st9.StudentMark();
                st9.PrintStudentMark();


                Student9.StudentMark obj = new Student9.StudentMark();
                obj.TotalMark = 200;
                obj.PrintTotalMark();

                Console.ReadKey();

            }
            catch (Exception Exe)
            {

                throw Exe;
            }
        }
    }

    class Student9
    {
        public int StudentId { set; get; }
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine("Hai how are u?");
        }
        public void PrintStudentMark()
        {
            StudentMark sm = new StudentMark();
            sm.TotalMark = 200;
            sm.PrintTotalMark();
        }



        //Connected Class
       public  class StudentMark
        {
            

            public int StudentId { set; get; }

            public int TotalMark { set; get; }

            private String Msg1 { set; get; }

            protected string Msg2 { set; get; }

            public void PrintTotalMark()
            {
                Console.WriteLine("Total Mark={0}", Convert.ToString(this.TotalMark));
            }
            
        }




    }

    class Student10
    {
        public int StudentId { set; get; }
        public string Name { get; set; }

        public void PrintName()
        {
            Console.WriteLine("Hai how are u?");
        }
    }
    
    //StudentDet:Student9:Student10 :- Multiple base class not allowed.

    class StudentDet :Student9
    {
        
        public void Print()
        {
            Console.WriteLine("Student Name");
        }
    }


}
