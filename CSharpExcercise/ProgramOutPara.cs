using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramOutPara
    {
        public static void MainStr(string[] args)
        {
            ProgramOutPara p1 = new ProgramOutPara();
            int val1 ;

           // p1.OutPara1(val1);     -->> compile time error out defined in method parameter.
            p1.OutPara1(out val1);
            
            Console.WriteLine("Value ={0}",val1);

            Console.ReadKey();

        }

        //1. public void OutPara1(int i)  --->  compile time error

        public void OutPara1(out int  i)
        {
            i = 100;
        }

    }
}
