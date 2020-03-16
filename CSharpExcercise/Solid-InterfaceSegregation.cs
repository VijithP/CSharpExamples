using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class Solid_InterfaceSegregation
    {

        public static void MainIS(string [] args)
        {

            HPPrinter hPPrinter = new HPPrinter();
            //PrinterFunc printerFun = (hPPrinter) PrinterFunc;
            //printerFun.Print();


        }

    }



    interface PrinterFunc
    {
        void Print();
        void Scan();
        void DuplexPrint();
        void FaxPrint();

    }

    class HPPrinter : PrinterFunc
    {

        public void Print() { Console.WriteLine("Print Method"); }
        public void Scan() { Console.WriteLine("Scan Method"); }
        public void DuplexPrint() { Console.WriteLine("Duplex Print Method"); }
        public void FaxPrint() { Console.WriteLine("Fax Method"); }

    }

    class CanonPrinter : PrinterFunc
    {
        //cannon printer not have the duplex print and fax print func

        public void Print() { Console.WriteLine("Print Method"); }
        public void Scan() { Console.WriteLine("Scan Method"); }
        public void DuplexPrint() { throw new Exception(); }
        public void FaxPrint() { throw new Exception(); }
    }


    //interface segregation principle


    interface PrinterFuncISP
    {
        void Print();
        void Scan();
     
    }


    interface PrinterFuncAdvancedISP
    {
        void DuplexPrint();
        void FaxPrint();

    }

    class HPPrinterISP : PrinterFuncISP, PrinterFuncAdvancedISP
    {

        public void Print() { Console.WriteLine("Print Method"); }
        public void Scan() { Console.WriteLine("Scan Method"); }
        public void DuplexPrint() { Console.WriteLine("Duplex Print Method"); }
        public void FaxPrint() { Console.WriteLine("Fax Method"); }

    }

    class CanonPrinterISP : PrinterFuncISP
    {

        public void Print() { Console.WriteLine("Print Method"); }
        public void Scan() { Console.WriteLine("Scan Method"); }
        
    }

}
