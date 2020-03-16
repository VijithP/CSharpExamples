using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramParameter
    {
        public static void MainParam(string[] args)
        {
            Console.WriteLine("Hai");



            //passing reference of paramter val.
            int val=10;
            ProgramParameter.RefParameter(ref val);
            Console.WriteLine("Reference Paramter val={0}", val);

            //output paramter
            int val1=30;
            ProgramParameter.OutParameter(out  val1);
            Console.WriteLine("Output paramter ={0}", val1);

            Console.ReadKey();




        }

        public static void RefParameter(ref int value1)
        {
            //value1 = 20;
        }

        public static void OutParameter(out int value1)
        {
            value1 = 20;
        }



    }
}
