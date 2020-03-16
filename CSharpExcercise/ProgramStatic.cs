using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramStatic
    {
        public static void MainSt(string [] args)
        {
            Console.WriteLine("hai");

           // Girl girl = new Girl();
            Girl.GirlName();
            Girl.Name = "Hira";

            Console.ReadKey();
        }

    }
    class Girl
    {
       public static string Name = "";

        private Girl()
        {
            Console.WriteLine("Hi Girl");
        }

        public static void GirlName()
        {
            Console.Write("Hi ammu");
        }

    }

    class GirlTeam
    {
        
    }


}
