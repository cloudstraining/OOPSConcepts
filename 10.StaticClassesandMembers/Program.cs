using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.StaticClassesandMembers
{    /// <summary>
     /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
     /// 10.Static Classes and Members
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Id = {0}", SampleStaticClass.Id);

            SampleStaticClass.Id = 1;


            SampleMethod();
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }

        public static void SampleMethod() {
            Console.WriteLine("Id from SampleMethod is = {0}", SampleStaticClass.Id);
        }
    }

    //Static classes in C# have static members only and cannot be instantiated
    public static class SampleStaticClass {
        public static int Id { get; set; }

    }
}
