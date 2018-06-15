using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.AnonymousTypes
{
    /// <summary>
    /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
    /// 11.Anonymous Types
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //anonymous type
            var sampleObject = new { Id = 1, Name = "Divakar" };


            Console.WriteLine("Id = {0}, Name = {1}", sampleObject.Id, sampleObject.Name);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }


}
