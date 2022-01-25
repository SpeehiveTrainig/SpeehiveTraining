using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Models
{
    public class Student
    {

        public int RollNo { get; set; }
        public string Name { get; set; }
        public int M1 { get; set; }
        public int M2 { get; set; }

        public int Total { get; set; }



        public void ReadAllData()
        {
            Console.WriteLine("Enter Name");
            Name=Console.ReadLine();
            ///
        }

        public  void calc()
        {
            Total = M1 + M2;

        }


        public void Display()
        {

            Console.WriteLine("");

        }




    }
}
