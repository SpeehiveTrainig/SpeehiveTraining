using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceExample
{
    public class MultiLevelInhertanceExample
    {
        static void Main(string[] args)
        {
                
            
        }
    }

    class GrandParent
    {
        public void FamilyName()
        {
            GrandChild grandChild = new GrandChild();
                grandChild.FamilyName();
            grandChild.Car();

                
        }
    }
    class Parent:GrandParent
    {
        public void Car()
        {

        }

    }
    class GrandChild:Parent
    {

    }
}
