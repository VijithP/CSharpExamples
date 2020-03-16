using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{

    public delegate void Shape();
    class ProgramEvent
    {
        public static event Shape shapeName;

        public static void MainEve(string[] args)
        {

            shapeName += new Shape(Circle);
            shapeName += new Shape(Square);
            shapeName += new Shape(Pendagon);
            shapeName.Invoke();
            Console.ReadKey();

        }

        public static void Circle()
        {
            Console.WriteLine("This is Circle");
        }

        public static void Square()
        {
            Console.WriteLine("This is Square");
        }

        public static void Pendagon()
        {
            Console.WriteLine("This is Pendagon");
        }

    }


}
