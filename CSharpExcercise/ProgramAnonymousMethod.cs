using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramAnonymousMethod
    {
        delegate int DelegateAddFn(int num1, int num2);

        public static void MainAnonymous(string [] args)
        {
             //developed by vijith
            //normal way to invoke delegate.
            DelegateAddFn DelegateAddFnObj = AdditionOfNumber;
             Console.WriteLine( "Method 1 sum of two number {0}", Convert.ToString(DelegateAddFnObj.Invoke(10, 20)));

            DelegateAddFn DelegateAddFn2 = delegate (int a, int b)
            {
                return a + b;
            };

            Console.WriteLine("Method 2 sum of two number {0}", Convert.ToString(DelegateAddFn2.Invoke(100, 200)));

            Console.ReadKey();
        }

        public static int AdditionOfNumber(int num1,int num2)
        {
            return (num1 + num2);
        }


    }
}
