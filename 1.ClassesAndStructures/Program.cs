using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.ClassesAndStructures
{
    /// <summary>
    /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
    /// 1. Classes & Structures
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            #region "Class"
            // Initialize Class:  
            MyFirstClass Obj = new MyFirstClass();

            // Assign Value to Property:  
            Obj.Id = 1;
            Console.WriteLine("Value of Id is " + Obj.Id);
            Console.ReadLine();
            #endregion


            // Initialize Structure:
            MyFirstStructure mystruct1 = new MyFirstStructure();
            MyFirstStructure mystruct2 = new MyFirstStructure(10, 10);
            MyFirstStructure mystruct3;

            //Initialize
            mystruct3.x = 1;
            mystruct3.y = 2;

            // Display results:
            Console.Write("MyFirstStructure 3: ");
            Console.WriteLine("x = {0}, y = {1}", mystruct3.x, mystruct3.y);

            // Display results:
            Console.Write("MyFirstStructure 1: ");
            Console.WriteLine("x = {0}, y = {1}", mystruct1.x, mystruct1.y);

            Console.Write("MyFirstStructure 2: ");
            Console.WriteLine("x = {0}, y = {1}", mystruct2.x, mystruct2.y);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }

    #region "Class Definition"
    // 1. Classes
    class MyFirstClass
    {
        // Fields, properties, methods and events go here...
        // Example Property
        public int Id { get; set; }
    }

    #endregion


    //1. Structures
    //Read more about structure at - https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-structs
    public struct MyFirstStructure
    {
        public int x, y;

        //public MyFirstStructure() { }

        public MyFirstStructure(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
}
