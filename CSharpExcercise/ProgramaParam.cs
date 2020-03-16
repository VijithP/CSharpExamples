using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{

    //Part 67 Optional parameters in c# 
    class ProgramaParam
    {

        public static void MainPr(string[] args)
        {


            ProgramaParam obj = new ProgramaParam();
            //params key word using for parameter optional
            obj.Sum(10, 20);
            obj.Sum(10,20,30,40);            
            obj.Sum(10, 10, new int[3] { 10, 20, 10 });

            //Using null assign to parameter is optional
            obj.SumOptionalParameter(10, 20);

            obj.SumOfThreeNumber(10, c: 30);


            //Using Optional Keyword for para

            obj.SumPara(10, 50);
          

            Console.ReadKey();





        }

        public void Sum(int a,int b,params int[] para)
        {
            int result = a + b;
            if(para!=null)
            {
                foreach(int item in para)
                {
                    result += item;
                }
            }
            Console.WriteLine("Result={0}", result);


        }

        //Part 69 Making method parameters optional by specifying parameter defaults
        public void SumOptionalParameter(int a, int b,  int[] para=null)
        {
            int result = a + b;
            if (para != null)
            {
                foreach (int item in para)
                {
                    result += item;
                }
            }
            Console.WriteLine("Optional Parameter Result={0}", result);
            
        }

        //Part 69 Making method parameters optional by specifying parameter defaults
        public void SumOfThreeNumber(int a,int b=0,int c=0)
        {
            int result = a + b + c;
            Console.WriteLine("Sum of three Number" + result);
        }

        //Part 70  Making method parameters optional by using OptionalAttribute 
        public void SumPara(int a, int b,[Optional] int[] para)
        {
            int result = a + b;
            if (para != null)
            {
                foreach (int item in para)
                {
                    result += item;
                }
            }
            Console.WriteLine("Result={0}", result);


        }


    }
}
