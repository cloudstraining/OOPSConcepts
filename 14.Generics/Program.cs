using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Generics
{
    /// <summary>
    /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
    /// 14.Generics
    /// </summary>
    class Program
    {
        static void Main()
        {
            Generic<string> g = new Generic<string>();
            g.Field = "Welcome to Genereics";

            Console.WriteLine("Generic.Field  = \"{0}\"", g.Field);
            Console.WriteLine("Generic.Field.GetType() = {0}", g.Field.GetType().FullName);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    public class Generic<T>
    {
        public T Field;
    }
}
