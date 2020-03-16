using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace CSharpExcercise
{
    class Program
    {
       public  static void MainSt(string[] args)
        {

            //  Program.Part36Exe();
            //ConsDesc consDesc = new ConsDesc(50,30);

            // Part17 part17= new Part17();
            //part16.Part16Exe();
            //Program.Part27();
            Program.Part26();
            Console.ReadLine();


        }

        public static void Part27()
        {
            Sample s = new Sample();
            s.num = 100;
            s.assign(0, 10);
            s.assign(0, 9);
            Console.WriteLine(s.arr[0]);
        }

        public static void Part26()
        {
            int i, j = 1, k;

            Console.WriteLine("j++ {0} , ++j={1}", j++, ++j);


            k = j++ + ++j;

            
            Console.WriteLine(k + " ");

            k = j++ + ++j;
            Console.WriteLine(k + " ");

            //result j++ 1 , ++j = 3
            //result  k=  8 
            //result k=  12
        }
        
        public static void Part23()
        {

            int n = 5;
            int x = 4;
            int z, c, k;
            z = (3 * x * x )+ (2 * x )+ (4 / x) + 8;
            Console.Write(Convert.ToChar(z));



        }

        public static void Part22()
        {

            A objA = new C();

            objA.Print();

            objA = new B();
            objA.Print();

            objA = new D();
            objA.Print();


        }

        public static void Part21()
        {
            bool a = true;
            bool b = false;
            a |= b;
            Console.WriteLine(a);
            Console.ReadLine();
            
        }

        public static void Calculation2()
        {
            int a = 4, b = 5;
            int cal =( a + ++b);
            Console.WriteLine("calculation={0}, b={1}",cal,b);

        }

        public static void Calculation()
        {
            float first = 10.553f;
            long second = 20L;


            int sum = Convert.ToInt32(first + second);
            Console.WriteLine("Sum =" + sum);

        }

        public static void Part30Exe()
        {

            ProgramInterface Part30 = new ProgramInterface();
            IPartialEmployee IPE = new ProgramInterface(); ;
            IPE.Salary();

            IFullTimeEmployee IFT = new ProgramInterface();
            IFT.FullSalary();

            IPartialEmployee pp = (IPartialEmployee)Part30;
            pp.Salary();

            
        }
        
        public static void Part22Exe()
        {
            ProgramMethodOverriding P22 = new ProgramMethodOverriding();
        }

        public static void Part36Exe()
        {
            ProgramDelegate part36 = new ProgramDelegate();
        }
    
             
    }


    class Sample
    {
        public int num;
        public int[] arr = new int[10];

        public void assign(int i, int val)
        {
            arr[i] = val;
        }
    }



    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("This is from class A");
        }
    }

    class B:A
    {
        public override void Print()
        { Console.WriteLine("This is from class B"); }
    }
    class C :A
    {
        public new void Print()
        { Console.WriteLine("This is from class C"); }
    }

    class D : B {
        public new void Print()
        {
            Console.WriteLine("This is from Class Da");
        }
    }




    class Part18
    {
        public Part18()
        {
        //    Nullable number=null;
        //    int num = 1;
        //    Console.WriteLine(number.GetType() == num.GetType());
        }
    }

    class Part17
    {
        public Part17()
        {
            var arr = new List<int> { 120, 240, 220 };
            var collection = new Collection<int>(arr);
            collection.Add(10);

            arr.Sort();

            Console.WriteLine("arr value=");
            foreach (int num in arr) Console.WriteLine(num) ;

            Console.WriteLine("collection value=");
            foreach (int numval in collection) Console.WriteLine(numval);



            
            
        
        }
    }



    class Part16
    {
        public delegate void delegatePart(int num);

        public delegate void delegateCal(int num1, int num2);
        
        public  void Part16Exe()
        {

            Part16 part16 = new Part16();

            delegatePart dp = new delegatePart(part16.NumberType);
            dp += new delegatePart(part16.NumberSquare);
            dp(10);

            delegateCal dpCal = new delegateCal(part16.Add);
            dpCal(10, 20);

        }

        
        public void NumberType(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine(" The Number {0} is even", num);
            }
            else if (num % 2 == 1)
            {
                Console.WriteLine(" The Number {0} is odd", num);
            }
            
        }

        public void NumberSquare(int num)
        {
            int square = num * num;
            Console.WriteLine("The square of Number {0}={1}",num,square);
        }

        public void Add(int num1, int num2)
        {
            Console.WriteLine("{0}+{1}={2}", num1, num2, num1 + num2);
        }


    }






    class Part12
    {
        public void Part123()
        {
            Part12 part12 = null;
            part12.Print();
        }

        public void Print()
        {
            Console.WriteLine("Hai IIIIIIIIIIIIIII @@@@@@@@@@@@");
        }
    }



    class Part11
    {
        public Part11()
        {
            char[] num = { '1', '2', '3' };
            Console.WriteLine(" char array: " + num);
        }
    }

    class Part9
    {

        public Part9()
        {
            char x = 'A';
            int i = 0;
            Console.WriteLine(true ? x : 0);
            Console.WriteLine(false ? i : x); 
        }
    }
    


    class ConsDesc
    {

        int first, second;

        public ConsDesc(int a, int b)
        {
            first = a;
            second = b;

            Console.WriteLine("first +second=" + (first + second));
        }
        ~ConsDesc()
        {
            Console.WriteLine("First - Second =" + (first - second));

        }
    
    
    }

    
    class Part6
    {
        public Part6()
        {
            string first="immidart";
            string second="IMMIDART";
            int com=first.CompareTo(second);
            Console.WriteLine("Comparisone first To Second="+com);


            int com2 = second.CompareTo(first);
            Console.WriteLine("Comparisone second To First=" + com2);
           
            
        }
    }
    
    
    class Part4
    {
        public Part4()
        {
            
            
            #if(!pi)
                Console.WriteLine("i");
            #else
                Console.WriteLine("Pi undefined");
            #endif
                
                
        }
    }
    
    
    class Part3
    {
        public Part3()
        {
            byte first=100;
            dynamic mainVal=first;
            Console.WriteLine("First Type="+first.GetType());
            Console.WriteLine("mainVal Type="+mainVal.GetType());
            
            mainVal+=100;
            Console.WriteLine("MainVal Type="+mainVal.GetType());
            
           // double flVal=10.5f;
          //  mainVal+=flVal;
           // Console.WriteLine("Main Val="+flVal);.
            
            
            
        }
    }
    
    
    class Part2
    {
        public Part2()
        {
            int[] i=new int[0];
            
           // i[0]=10;
            Console.WriteLine("i value index[0]="+i[0]);
        }
    }
    
    
    class ConDes
    {
       public  ConDes()
        {
            Console.WriteLine("Hai");
        }
        
        ~ConDes()
        {
            Console.WriteLine("Exit");
        }
        
        
    }
    
    class CalCulations
    {
        public CalCulations()
        {
            
            Console.WriteLine("Round 6.5="+Math.Round(6.5));
            Console.WriteLine("Round 6.51="+Math.Round(6.51));
            Console.WriteLine("Round 6.500001="+Math.Round(6.50001));
            Console.WriteLine("Round 7.6="+Math.Round(7.6));
            
            Console.WriteLine("Round 11.5="+Math.Round(7.5));
        }
    }
    
    

}
