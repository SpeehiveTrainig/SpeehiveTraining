using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrarsAndCollections
{
    public class Test2
    {
        static void Main(string[] args)
        {
            //array

            int[] a = new int[3];
            string[] b = new string[3];
            float[] f = new float[3];

            int[,]TwoDArray=new int[3,3];
            int[,,] TwoDArray1 = new int[3, 3,4];

            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Enter"+(i+1)+" number");
               a[i] = Convert.ToInt32(Console.ReadLine());

            }
            Console.WriteLine("out");

            foreach(int i in a)
            {
                Console.WriteLine(i);
            }
            var x=a.Select(x => x == 1);
            var x1=a.First();
           var xw= a.GetValue(x1);


            Console.ReadLine();
        }
    }
}
