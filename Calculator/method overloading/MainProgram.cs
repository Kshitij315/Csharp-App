using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.method_overloading
{
    
    internal class MainProgram
    {
        public static void Main()
        {
            BaseClass bc=new DerivedClass();

            bc.Print();
        }
    }
    
    
    internal class BaseClass
    {
        public virtual void Print()
        {
            Console.WriteLine("Im printing from BASE CLASS ");
        }
    }

    class DerivedClass : BaseClass
    {
        public override void Print()
        {
            Console.WriteLine("Im printing from DERIVED CLASS");
        } 

    }

    
}
