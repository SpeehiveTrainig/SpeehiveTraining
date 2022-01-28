using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] a = new int[10];
           
            Student student = new Student(12,12);
            
            //Student student2 = new Student();

            student.test();




            Student student1 = new Student();
            student1.Name = "Vishnu";
            student1.M1 = 10;


            Student student2 = new Student(student1);
            Console.WriteLine(student2.Name);

           
                    
            Console.ReadKey();



        }
    }

    class Student
    {

       
        public string Name { get; set; }
        public int RollNo { get; set; }

        public int M1{ get; set; }
        public int M2 { get; set; }

        public int Total { get; set; }


        public void test()
        {
            Console.WriteLine("test");
        }

        public Student() // default constructor
        {
            Console.WriteLine("msg from Default constructor");
        }

        public Student(int m1, int m2) // parameterized Constructors
        {
            M1 = m1;
            M2 = m2;

            Console.WriteLine("Hi from Parameterized constructor");
            //Console.WriteLine(x+y);

        }


        public Student(Student student) // copy Constructor
        {
          Name= student.Name;
          RollNo= student.RollNo;
          Total= student.Total;
        }


       
    }

  

  

}
