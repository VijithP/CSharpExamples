using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CSharpExcercise
{
    class ProgramLq
    {


        static List<Student> ListStudent = new List<Student>();

        public static void Main(string[] args)
        {
            ProgramLq objPl = new ProgramLq();
            objPl.FirstElement();
            
            Console.ReadLine();
        }

        static ProgramLq()
        {
            ListStudent.Add(new Student() { StudentId = 001, Name = "Arjun", Dept = "Computer" });
            ListStudent.Add(new Student() { StudentId = 002, Name = "Babin", Dept = "Civil" });
            ListStudent.Add(new Student() { StudentId = 003, Name = "Cena", Dept = "Mechanical" });
        }

        public void FilterValueFromList()
        {
            List<string> Books = new List<string>()
            {
                "C# Programming","C++ Programming","Data Structure","Sql Programming"
            };

            var bookNames = from s in Books where s.Contains("programming") select s;

            string name = bookNames.FirstOrDefault();
            Console.WriteLine("First Book");

            foreach (var item in bookNames) Console.WriteLine(item);
            
        }

        public void FilterFromClassArr()
        {
            Student[] st = new Student[4];
            st[0].StudentId=101;st[0].Name="Kiran";st[0].Dept="Comp";
            st[1].StudentId = 102; st[1].Name = "Mathew"; st[1].Dept = "Civil";
            st[2].StudentId = 103; st[2].Name = "Rini"; st[2].Dept = "Hindi";
            st[3].StudentId = 104; st[3].Name = "Mini"; st[3].Dept = "Mal";

            var ss = from stud in st where stud.Name.Contains("Kir") select stud;

            foreach (var item in ss) Console.WriteLine("{0} -- {1} -- {2}", item.StudentId, item.Name, item.Dept);
            
                        
        }


        public void FilterFromList()
        {
            List<string> Student = new List<string>() { "Arun", "Amal", "Anoop" };

            var studentName = Student.Where(st => st.Contains("Arun") || st.Contains("Anoop") );

            Console.WriteLine("Student Name ");
            foreach (string name in studentName) Console.WriteLine(name);

        }

        #region oftype

        void DisplayWithType()
        {

            ArrayList array = new ArrayList();

            array.Add("English");
            array.Add("Malayalam");
            array.Add(100);
            array.Add(50.00);
            array.Add(200);
            array.Add("Maths");
            array.Add(true);
            
            var StringVal=from str in array.OfType<string>() select str;
            var integerVal = from ind in array.OfType<int>() select ind;
            var boolval = from bol in array.OfType<bool>() select bol;

            Console.WriteLine("String Values");
            foreach (var item in StringVal) Console.WriteLine("value={0}", item);

            Console.WriteLine("int Values");
            foreach (var item in integerVal) Console.WriteLine("value={0}", item);


            Console.WriteLine("Bool Values");
            foreach (var item in boolval) Console.WriteLine("value={0}", item);



        }

        #endregion oftype

        
        #region OrderBy

        void OrderList()
        {
            Student objStudent = new Student();

            List<Student> student = new List<Student>();
            objStudent.StudentId = 101; objStudent.Name = "Anoop"; objStudent.Dept = "Cs";
            student.Add(objStudent);

            objStudent = new Student();
            objStudent.StudentId = 102; objStudent.Name = "NIkil"; objStudent.Dept = "Me";
            student.Add(objStudent);

            objStudent = new Student();
            objStudent.StudentId = 100; objStudent.Name = "Babin"; objStudent.Dept = "Au";
            student.Add(objStudent);


            var StudentOrderId = from st in student orderby st.StudentId ascending select st;

            Console.WriteLine("Student list by order by Id");
            foreach (var item in StudentOrderId) Console.WriteLine("Id= {0} , Name= {1}", item.StudentId, item.Name);


            var StudentName = student.OrderBy(st => st.Name);

            Console.WriteLine("Student list by order by Name");
            foreach (var item in StudentName) Console.WriteLine("Id= {0} , Name ={1}", item.StudentId, item.Name);


        }


        #endregion OrderBy

        #region Thenby

        void ThenbyList()
        {
            Student objStudent = new Student();

            List<Student> student = new List<Student>();
            objStudent.StudentId = 101; objStudent.Name = "Anoop"; objStudent.Dept = "Cs";
            student.Add(objStudent);

            objStudent = new Student();
            objStudent.StudentId = 102; objStudent.Name = "NIkil"; objStudent.Dept = "Me";
            student.Add(objStudent);

            objStudent = new Student();
            objStudent.StudentId = 100; objStudent.Name = "Babin"; objStudent.Dept = "Au";
            student.Add(objStudent);


            

            var StudentName = student.OrderBy(st => st.StudentId).ThenByDescending(st=>st.Name).ThenByDescending(st=>st.Dept);

            Console.WriteLine("Student list by order by Name");
            foreach (var item in StudentName) Console.WriteLine("Id= {0} , Name ={1}", item.StudentId, item.Name);


        }

        #endregion ThenBy

        #region GroupBy
       
        void GroupByElement()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){StudentId=1,Name="Anoop",Dept="CS"},
                new Student(){StudentId=2,Name="Karthik",Dept="ME"},
                new Student(){StudentId=3,Name="Reena",Dept="CS"},
                new Student(){StudentId=4,Name="Midhun",Dept="AU"}

            };


            var groupItem = from s in studentList
                            group s by s.Dept;

            foreach (var item in groupItem)
            {
                Console.WriteLine("Item key={0}", item.Key);
                foreach (var itemValue in item) Console.WriteLine("{0},{1}", itemValue.Name, itemValue.Dept);
            }



        }

        #endregion GroupBy
        
        #region Lookup

        void LookupElement()
        {
            List<Student> studentList = new List<Student>()
            {
                new Student(){StudentId=1,Name="Anoop",Dept="CS"},
                new Student(){StudentId=2,Name="Karthik",Dept="ME"},
                new Student(){StudentId=3,Name="Reena",Dept="CS"},
                new Student(){StudentId=4,Name="Midhun",Dept="AU"}

            };


            var groupItem = studentList.ToLookup(s => s.Dept);



            foreach (var item in groupItem)
            {
                Console.WriteLine("Item key={0}", item.Key);
                foreach (var itemValue in item) Console.WriteLine("{0},{1}", itemValue.Name, itemValue.Dept);
            }



        }

        #endregion Lookup

        #region First
        
        void FirstElement()
        {
           // Student studentData = new Student();
           var studentData= ListStudent.Select(st=>st.StudentId==001);
        
            foreach(var item in studentData)
            {
                Console.WriteLine("Employee Id={0}", item);
            }


        }

        #endregion First









    }
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
    }


}
