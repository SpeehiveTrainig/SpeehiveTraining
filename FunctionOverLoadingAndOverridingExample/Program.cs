using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionOverLoadingAndOverridingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sample sample=new Sample();
            
            sample.Add(12,12);
           
            sample.Add(12, 12,12);
        }

       
    }

    class Sample
    {
        public void Add(int x, int y) // function overloading
        {
            Console.WriteLine(x+y);
        }

        public void Add(int x, int y,int z)
        {
            Console.WriteLine(x + y+z);
        }


    }


    // function overriding

    class Father
    {
        public void Education()
        {
            Console.WriteLine("10 th");
        }
       

        public  void houseName()
        {
            Console.WriteLine(" Father House name");
        }




    }

    class Son : Father
    {


        void Education()
        {
            Console.WriteLine("Btech");
        }

        void Education(string x)
        {
            Console.WriteLine("c++");
        }



    }



}
