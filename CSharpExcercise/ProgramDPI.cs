using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramDPI
    {
        public static void MainDI(string[] args)
        {
            Food fd = new Food(new VegFood());
            fd.PrintFood();


            fd = new Food(new NonVegFood());
            fd.PrintFood();


            Console.ReadKey();
        }
    }

    interface IFood
    {
        void PrintFood();
    }
    class VegFood:IFood
    {
        public void PrintFood()
        {
            Console.WriteLine("This is a Veg Food.."); 
        }
    }

    class NonVegFood:IFood
    {
        public void PrintFood()
        {
            Console.WriteLine("None Veg Food");

        }
    }

    class Food
    {
        private IFood ifood;
        public Food(IFood ifoodVal)
        {
            ifood = ifoodVal;
        }

        public void PrintFood()
        {
            ifood.PrintFood();
        }
        
    }



}
