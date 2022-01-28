using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.Gender = GenderEnum.FeMale;
            s1.ModifiedTime = DateTime.Now;

            Test o=new Test();
            //o.hello();

            //int number= o.getMeaRandomNum();
            // Console.WriteLine(number);


            // o.Add(12,12);

            int avg=o.Avg(12, 12);


            Student studentObj=new Student();
            studentObj.M3 = 112;
            studentObj.M4 = 12;
            
            o.CalculateGrade(studentObj);
            
            o.Add(studentObj.M3, studentObj.M3);


            Console.WriteLine(avg);

            Console.ReadKey();
        }
    }
}
