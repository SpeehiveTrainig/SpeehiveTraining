using StudentManagement.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Utills
{
    public class Helper
    {


       public  void WirteFile(Student student)
        {
            //
            // write to File student.RollNo;

            StreamWriter file = new StreamWriter(@"C:\Users\user\Desktop\A\Vishnu.txt");


            file.WriteLineAsync("Name:        " + student);
            

        }
    }
}
