using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramQueue
    {
        //part 81
        public static void MainQU(string[] args)
        {

            CustQu cust1 = new CustQu() { Id = 100, Name = "Anil", Salary = 4000 };
            CustQu cust2 = new CustQu() { Id = 101, Name = "Beena", Salary = 6000 };
            CustQu cust3 = new CustQu() { Id = 102, Name = "Cene", Salary = 5000 };
            CustQu cust4 = new CustQu() { Id = 103, Name = "Dena", Salary = 2000 };

            //Insert into Queue
            Queue<CustQu> listQue = new Queue<CustQu>();
            listQue.Enqueue(cust1);
            listQue.Enqueue(cust2);
            listQue.Enqueue(cust2);
            listQue.Enqueue(cust2);

            //list all element in Queue
            foreach(var item in listQue)
            {

                Console.WriteLine("id={0} ,Name={1},Salary={2}", item.Id, item.Name, item.Salary); 
            }

            Console.WriteLine("_________________________________________________________");

            //read first element of the queue
            CustQu c11 = listQue.Peek();
            Console.WriteLine("id={0} ,Name={1},Salary={2}", c11.Id, c11.Name, c11.Salary);


            Console.WriteLine("_________________________________________________________");

            //remove the element from Queue
            CustQu c1 = listQue.Dequeue();
            Console.WriteLine("id={0} ,Name={1},Salary={2}",c1.Id,c1.Name,c1.Salary);

            c1 = listQue.Dequeue();
            Console.WriteLine("id={0} ,Name={1},Salary={2}", c1.Id, c1.Name, c1.Salary);

            c1 = listQue.Dequeue();
            Console.WriteLine("id={0} ,Name={1},Salary={2}", c1.Id, c1.Name, c1.Salary);

            c1 = listQue.Dequeue();
            Console.WriteLine("id={0} ,Name={1},Salary={2}", c1.Id, c1.Name, c1.Salary);


            Console.WriteLine("Total Count of Queue={0}", listQue.Count);




            Console.ReadKey();

        }

    }

    class CustQu
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
