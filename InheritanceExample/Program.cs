using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A o=new A();
            o.functionFromA();


            Random random = new Random();
            Console.WriteLine();
            
            B b=new B();
            b.functionFromA(); //inhertance

            b.functionFromB(); // normal
        }
       
    }


   class A //parent class
    {
        public void functionFromA()
        {
            Console.WriteLine("function from A class");
        }

       
    }

    class B:A // child class
    {
       public void functionFromB()
        {

            //A o= new A();
            //o.functionFromA();

            functionFromA();
           
            Console.WriteLine("Function form B");
        }
    }

    class Redmi9i //parent class
    {
        private void redmi9iCam()
        {
            //
        }

        public void BrandName()
        {
            ///
        }

        protected void themeMusic()
        {
            //

        }
    }


    class Redmi10:Redmi9i
    {
        public void newFeatuesOfRedmi10()
        {
           


            BrandName();
            themeMusic();

        }
    }

}
