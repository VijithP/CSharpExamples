using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{

    public delegate void HelloMsgDel();
    public delegate int AddDel(int x,int y);

    public class ProgramDelegate
    {
        public ProgramDelegate()
        {
            
            HelloMsgDel objHelloeMsg = new HelloMsgDel(HelloMsg);
            objHelloeMsg();

           

            AddDel objAddDel = new AddDel(Add);
            int result= objAddDel(10, 20);
            Console.WriteLine("Result= " + result);
        }


        public void HelloMsg()
        {
            Console.WriteLine("Hellow Message....");
        }

        public int Add(int a, int b)
        {
            return (a + b);
        }

    }
}
