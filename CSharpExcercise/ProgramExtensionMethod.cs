using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethod;
namespace CSharpExcercise
{
    class ProgramExtensionMethod
    {
        public static void MainEx(string[] args)
        {

            int value1 = 10;
            int value2 = 200;
            bool result = value1.IsGreater(value2);
            
        }
    }
}


namespace ExtensionMethod
{
    public static class ExtClass
    {
        public static bool IsGreater(this int value1,int value2)
        {
            return value1 > value2;
        }

    }
}
