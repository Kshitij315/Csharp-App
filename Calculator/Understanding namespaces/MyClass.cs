using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ProjectA.TeamA;  //using directive         
namespace Calculator.Understanding_namespaces
{
    class Program
    {
        public static void Main()
        {
            // ProjectA.TeamA.classA.Print();
            classA.Print();
        }
    }
    


}
namespace ProjectA
{
    namespace TeamA
    {
        class classA
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print method");
            }
        }
    }
}
namespace ProjectA
{
    namespace TeamB
    {
        class classB
        {
            public static void Print()
            {
                Console.WriteLine("Team A Print method");
            }
        }
    }
