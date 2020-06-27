using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramBinarySearch
    {

        public static void MainBinarySerch(string[] args)

        {
            
            //developed by vijith
            Console.WriteLine("Hai");

            //int[] num = new int[5] { 90, 50, 80, 10, 30 };
            int[] num = new int[10] { 20, 40, 80, 90, 100,120,150,180,185,200 };

            int search = 180;

            int lowerpoint = 1;
            int upperpoint = num.Length;

            while(lowerpoint<=upperpoint)
            {
                int midpoint = (upperpoint + lowerpoint)/2;
                if(num[midpoint]>search)
                {
                    upperpoint = midpoint - 1;
                }
                else if (num[midpoint] < search)
                {
                    lowerpoint = midpoint + 1;
                }
                else
                {
                    Console.WriteLine("Serach text {0}", midpoint);
                    break;
                }


            }



            Console.ReadKey();
        }

    }
}
