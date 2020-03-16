using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExcercise
{
    //Part 72 What is dictionary in c# & 73
    class ProgramDictionary
    {
        public static void MainDict(string[] args)
        {

            Customer cust1 = new Customer() { Id = 100, Name = "Anil", Salary = 4000 };
            Customer cust2 = new Customer() { Id = 101, Name = "Beena", Salary = 6000 };
            Customer cust3 = new Customer() { Id = 102, Name = "Cene", Salary = 5000 };
            Customer cust4 = new Customer() { Id = 103, Name = "Dena", Salary = 2000 };

            Dictionary<int, Customer> custDict = new Dictionary<int, Customer>();
            custDict.Add(cust1.Id, cust1);
            custDict.Add(cust2.Id, cust2);
            custDict.Add(cust3.Id, cust3);
            custDict.Add(cust4.Id, cust4);
             
            


            Console.WriteLine("Dictionary Values");
            foreach(KeyValuePair<int,Customer> kvp in custDict)
            {
                Console.WriteLine("Id={0}, Name={1}, Salary={2}", kvp.Value.Id, kvp.Value.Name, kvp.Value.Salary);
            }

            if(custDict.TryGetValue(101,out Customer cust))
            {
                Console.WriteLine(" Specific value Id={0}, Name={1}, Salary={2}", cust.Id, cust.Name, cust.Salary);

            }


            Console.WriteLine("Count of Dictionary Value {0}", custDict.Count);

            Console.WriteLine("Salary > 5000 Count of Dictionary Value {0}", custDict.Count(kvp=>kvp.Value.Salary>5000));



            //Array to Dictionary
            Customer[] custArr = new Customer[4];
            custArr[0] = cust1;
            custArr[1] = cust2;
            custArr[2] = cust3;
            custArr[3] = cust4;



            Dictionary<int, Customer> custDic = custArr.ToDictionary(custP => custP.Id, custP => custP);

            foreach (KeyValuePair<int, Customer> kvp in custDict)
            {
                Console.WriteLine("Id={0}, Name={1}, Salary={2}", kvp.Value.Id, kvp.Value.Name, kvp.Value.Salary);
            }




            //Remove item from dictionary
            custDict.Remove(101);

            //clear all item from dictionary
            custDict.Clear();




            Console.ReadKey();


        }
    }
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }

}
