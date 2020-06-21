using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace CSharpExcercise
{
    class ProgramAutomapper
    {

        public static void MainMap(string [] args)
        {
            //Console.WriteLine("Hi C#");
            //Console.ReadKey();
            //developed by vijith
            StudentSSM ssm = new StudentSSM();
            ssm.StudentId = 101;
            ssm.FirstName = "Vijith";
            ssm.LastName = "Pookkarathara";

            Mapper.Initialize(cfg => { cfg.CreateMap<StudentSSM, StudentDH>()
                .ForMember(dest=>dest.FName,opt=>opt.MapFrom(src=>src.FirstName))
                .ForMember(dest=>dest.LName,opt=>opt.MapFrom(src=>src.LastName))                
                ; });

            StudentDH dh= Mapper.Map<StudentDH>(ssm);

            Console.WriteLine("StudentDH Details");

            Console.WriteLine("Student Id={0} \n FirstName={1} \n Last Name={2}", dh.StudentId, dh.FName, dh.LName);


            Console.ReadKey();
        }

        //private static void CreateMap<T1, T2>()
        //{
        //    throw new NotImplementedException();
        //}
    }

    class StudentSSM
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class StudentDH
    {
        public int StudentId { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

    }





}
