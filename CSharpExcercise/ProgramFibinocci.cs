using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramFibinocci
    {

        public static void MainFib(string[] args)
        {

            int n = 10;
            int first= 0;
            int second = 1;
            int print = 0;

            Console.WriteLine(first);

            Console.WriteLine(second);

            for(int i=0;i<n;i++)
            {
                print = first + second;

                Console.WriteLine(print);

                first = second;

                second = print;

            }


            Console.ReadKey();

        }


    }
}
