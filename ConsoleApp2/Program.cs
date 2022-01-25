using ConsoleApp2.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Student student = new Student();
            student.setRollNo(1);
            student.getRollNo();
           
            Console.WriteLine();

            student.Mark1 = 10;

            Employee employee = new Employee();
            employee.Name = "vishnu";

            Helper o = new Helper();
            o.WriteToFile

           
        }
    }
}
