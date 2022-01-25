using StudentManagement.Models;
using StudentManagement.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Program
    {
        static void Main(string[] args)
        {

            Student s1 = new Student();

            s1.Name = "Vishnu";
            s1.ReadAllData();
            s1.calc();

            s1.Display();

            Helper helper = new Helper();
            
            
            helper.WirteFile(s1);

            Console.ReadKey();
        }
    }
}
