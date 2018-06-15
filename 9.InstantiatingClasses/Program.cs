using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.InstantiatingClasses
{
    /// <summary>
    /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
    /// 9.Instantiating Classes
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {

            // Initialize Class:  
            MyFirstClass Obj1 = new MyFirstClass();

            // Assign Value to Property:  
            Obj1.Id = 1;
            Obj1.Name = "Divakar";
            Console.WriteLine("Value of Id is {0}, Name is {1}", Obj1.Id, Obj1.Name);
            Console.ReadLine();

            // Initialize Class with values assigned:  
            MyFirstClass Obj2 = new MyFirstClass { Id= 2, Name= "Alex" };
            Console.WriteLine("Value of Id is {0}, Name is {1}", Obj2.Id, Obj2.Name);
            Console.ReadLine();

            // Initialize Structure:
            MyFirstStructure mystruct1 = new MyFirstStructure();
           
         
            Console.Write("MyFirstStructure 1: ");
            Console.WriteLine("x = {0}, y = {1}", mystruct1.x, mystruct1.y);


            MyFirstStructure mystruct2 = new MyFirstStructure(10, 10);
            Console.Write("MyFirstStructure 2: ");
            Console.WriteLine("x = {0}, y = {1}", mystruct2.x, mystruct2.y);

            MyFirstStructure mystruct3;

          
            mystruct3.x = 1;
            mystruct3.y = 2;
          
            Console.Write("MyFirstStructure 3: ");
            Console.WriteLine("x = {0}, y = {1}", mystruct3.x, mystruct3.y);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }


  
    
    class MyFirstClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

  
    public struct MyFirstStructure
    {
        public int x, y;

        public MyFirstStructure(int p1, int p2)
        {
            x = p1;
            y = p2;
        }
    }
}
