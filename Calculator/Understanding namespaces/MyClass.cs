using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

///<summary>
///namespaces are used to organize your code into different chunks
///these chunks can be accessed using the name of that namespace
///They also help us to avoid name clashes
///microsoft also uses namepsaces like System to organize c# code
///Or we can add preprocessing directive to include that namespace
/// </summary>
/// <summary>
/// using alias
/// </summary>
using Pata=ProjectA.TeamA;  //using alias
using Patb=ProjectA.TeamB;  //using alias
namespace Calculator.Understanding_namespaces
{
    class Program
    {
        //public static void Main()
        //{
        //    // ProjectA.TeamA.classA.Print();
        //    //ProjectA.TeamB.classB.Print();
        //    Pata.classA.Print();//aliases are used to resolve ambiguity bw names
        //    Patb.classB.Print();//same as above
        //}
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
}
