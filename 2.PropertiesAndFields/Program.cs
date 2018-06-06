using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.PropertiesAndFields
{
    /// <summary>
    /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
    /// 2. Properties & Fields
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Class:  
            MyFirstClass Obj = new MyFirstClass();

            // Assign Value to Property:  
            Obj.Id = 1;
            // Obj.Name = "Alex";

            Console.WriteLine("Value of Id is " + Obj.Id);
            Console.WriteLine("And his Name is " + Obj.Name);
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }




    class MyFirstClass
    {
        // Example Integer Property 
        public int Id;

        private string _name = "Alex";

        public string Name
        {
            get { return _name; }
            // set { _name = value; }

        }

        public int FirstName { get; set; }

        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

    }


}
