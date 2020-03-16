using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramConsoleWrRd
    {
        public static void MainWrRd(string[] args)
        {
            Console.WriteLine(Console.ReadKey());// result: enterkey+keyinfo

            Console.WriteLine(Console.ReadLine()); //result : word , word display.

            //Console.ReadLine(Console.WriteLine()); --> compile time error.

            Console.ReadKey();
        }
    }
}
