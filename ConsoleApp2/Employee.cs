using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Employee
    {
        public int temp;
        public string Name { get ; set; }

        public string Dept { get; set; }


        public int EmpId { get;  set; }


        private int no;
        public int No {

            get { return no; }



            set { no = value; }
        
        
        }
    }
}
