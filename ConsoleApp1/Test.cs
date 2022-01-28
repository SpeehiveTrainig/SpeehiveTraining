using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Test
    {
      // with  out return type without pram
      public void hello()
        {
            Console.WriteLine("hello");
        }


        // with return type with out parm
        public int getMeaRandomNum()
        {
            Random o = new Random();
            int OTP=o.Next(1000,2000);
            return OTP;
        }

        // with out return type with param

        public void Add( int x, int y) 
        {
            Console.WriteLine(x+y);
        }

        // with out return type with param

        public int Avg(int x, int y)
        {
            return (x+y)/2;
        }


        public void CalculateGrade(Student studentObj)
        {
            int total =studentObj.M2+studentObj.M1;
        }

        public void Test(Student studentObj,string[] students)
        {
            int total  = studentObj.M2 + studentObj.M1;
        }





    }
}
