using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramBase
    {

        public static void MainBS(string[] args)
        {

            Boys bb2 = new Boys();
            bb2.Print2();
            bb2.Print3();
            //Output:- We are boys
            Boys bb = new Boys();
            bb.Print();

            //Output:- We are boys
            bb = new SeniorBoys();
            bb.Print();


            //Output:-Error
            // SeniorBoys sb = new Boys();
            // sb.Print();

            //Output:-We are senior boys print 2
            bb = new SeniorBoys();
            bb.Print2();
            bb.Print3();

            //Output:-We are senior boys print 2
            bb = new Boys();
            bb.Print2();

            Console.ReadKey();


        }
    }

    class Boys
    {
        public virtual void Print()
        {
            Console.WriteLine("We are boys");
            
        }
        public virtual void Print2()
        {
            Console.WriteLine("We are boys print ");
        }

        public void Print3()
        {
            Console.WriteLine("We are boys print3");
        }
    }

    class SeniorBoys:Boys
    {
        public new void Print()
        {
            Console.WriteLine("We are super boys");
        }

        public override void Print2()
        {
            Console.WriteLine("We are senior boys print 2");
        }

        public void Print3()
        {
            Console.WriteLine("We are senior boys print3");
        }

    }

   // class 



}
