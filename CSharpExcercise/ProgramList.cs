using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    class ProgramList
    {

        public static void MainList(string[] args)
        {
            //List Exist,Contains,Find,FindLast,FindAll,FindIndex,ToList,ToArray,ToDictionary
            //List Add,AddRange,
            //AddRange,GetRange,RemoveRange
            //Sort,Reverse
            //TrueAll,


            Custmr cust1 = new Custmr()
            {Id=101,Name="Anu",Salary=5000 };


            Custmr cust2 = new Custmr()
            { Id = 102, Name = "Manu", Salary = 4000 };


            Custmr cust3 = new Custmr()
            { Id = 103, Name = "Vinu", Salary = 6000 };


            List<Custmr> CtList = new List<Custmr>();
            CtList.Add(cust1);
            CtList.Add(cust2);
            CtList.Add(cust3);


            bool exist= CtList.Exists(c => c.Id == 101);
            Console.WriteLine("Id =101 is Exist" + exist);

            bool existItem=  CtList.Contains(cust2);
            Console.WriteLine("Item =102 is Exist" + existItem);

            Custmr ctt= CtList.Find(ct => ct.Name == "Vinu");
            Console.WriteLine("Vinu Details {0}  ,{1}", ctt.Id, ctt.Salary);


            int listIndex= CtList.FindIndex(ct => ct.Id == 103);
            Console.WriteLine("Index of 103 is {0}", listIndex);


            Console.WriteLine("________________________________________");
            Console.WriteLine("List of Customer Details");

            List<Custmr> cm = new List<Custmr>();
            cm.AddRange(CtList);

            foreach(Custmr item in cm)
            {
                Console.WriteLine("Id ={0} , Name={1} , Salary {2}", item.Id, item.Name, item.Salary);
            }



            Console.WriteLine("________________________________________");
            Console.WriteLine("List of Customer Details  index 1 to Count 2"); 
            List<Custmr> cm2= cm.GetRange(1, 2);

            foreach(Custmr item in cm2)
            {
                Console.WriteLine("Id ={0} , Name={1} , Salary {2}", item.Id, item.Name, item.Salary);
            }


           bool checkSalary=  CtList.TrueForAll(ct => ct.Salary > 3000);
           Console.WriteLine("Salary > 3000 ={0}", checkSalary);


           ReadOnlyCollection<Custmr> list=  CtList.AsReadOnly();
           
            
            
            Console.ReadKey();






        }

    }

    class Custmr
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Salary { set; get; }
    }

}
