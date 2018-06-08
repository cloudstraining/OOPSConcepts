using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Finalizers
{
    /// <summary>
    /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
    /// 5.Finalizers
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Third t = new Third();
        }
    }


    class First
    {
        ~First()
        {
            System.Diagnostics.Trace.WriteLine("First's destructor is called.");
           
        }
    }

    class Second : First
    {
        ~Second()
        {
            System.Diagnostics.Trace.WriteLine("Second's destructor is called.");
        }
    }

    class Third : Second
    {
        ~Third()
        {
            System.Diagnostics.Trace.WriteLine("Third's destructor is called.");
        }
    }
}
