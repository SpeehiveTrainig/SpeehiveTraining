using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class SingleInhertanceExample
    {
        static void Main(string[] args)
        {
              
            Son son = new Son();
            son.sirName();
        }
    }

    class Father
    {
        public void sirName()
        {
            Console.WriteLine("SirName");
        }

    }

    class Son:Father
    {

    }
}
