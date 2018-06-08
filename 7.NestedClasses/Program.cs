using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.NestedClasses
{   /// <summary>
    /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
    /// 7.Nested Classes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Container.Nested nestedInstance = new Container.Nested();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }


    class Container
    {
        public class Nested
        {
            // Add code here.  
            public Nested()
            {
                Console.WriteLine("Am from nested class");
            }
            
        }
    }

}
