using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramDeleFunAct
    {
        ProgramDeleFunAct prgm = new ProgramDeleFunAct();           

        public delegate double AddFun(double c,double d);

        public delegate double SubFun(double c, double d);
        static AddFun ad = Addition;

        public static void MainDel(string[] args)
        {

            //Delegate calling using function.

            //Console.WriteLine("Sum of two number={0}", prgm.Addition(10,30);            

           // Console.WriteLine("Sum of two number={0}", ad.Invoke(20, 30));
            SubFun sb = new SubFun(
                delegate(double e, double f)
                {
                    return (e - f);
                }
            );

            //Console.WriteLine("substraction={0}", sb(20, 10));

            //lamda Expresion

            //SubFun sb1 = new SubFun((e, f) => (e - f));
            //Console.WriteLine("substraction={0}", sb1(20, 10));


            //calling advanced delegate function.
            ProgramDeleFunAct.DelegateAdv();


           
            Console.ReadLine();
        }


        public static double Addition(double a,double b)
        {
            return (a + b);
        }

        public  double Substraction(double a, double b)
        {
            return (a - b);
        }


        public void DelegateSample()
        {
            SubFun sub = new SubFun(prgm.Substraction);
            Console.WriteLine("Subtraction ={0}", sub(50, 30));

            Console.ReadLine();


        }

        public static void DelegateAdv()
        {
            try
            {

                //Function delegate have input and out put declaration.
                Func<int, int> sub = ((a) => (2*a + a));

                //action delegate have only input declare no out declaration.
                Action<int> display = (x => Console.WriteLine("Hello my dear friends"));

                //Predicate delgare only return true or false method.
                Predicate<string> lengthValue = (x => x.Length > 5);


                Console.WriteLine(" Calculation Value={0}",sub(10));
                display(10);
                Console.WriteLine("Length value of string={0}",lengthValue("Vijithpookkarathara"));




            }
            catch (Exception Exe)
            {
                
                throw Exe;
            }
        }
        




    }
}
