using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramaInt
    {

        public static void MainInt(string[] args)
        {
            try
            {
                int value2 = int.Parse("ABC");
                int value1 = Convert.ToInt32("Abc");
                
                Console.ReadKey();
            }
            catch (Exception)
            {

                throw;
            }
        }


    }
}
