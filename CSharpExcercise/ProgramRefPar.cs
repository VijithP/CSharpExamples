using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramRefPar
    {

        public static void MainRef(string[] args)
        {

            ProgramRefPar pRF = new ProgramRefPar();
            int val =200;
            pRF.RefOutput(ref val);

           // pRF.RefOutput(val); --ref must mension in the method and calling function.
           
            Console.WriteLine("Value={0}", val);
            Console.ReadKey();
            
        }
        // public void RefOutput( int par) --ref must mension the method function

        public void RefOutput(ref int par)
        {
            par = 300;
        }


    }
}
