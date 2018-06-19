using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Interfaces
{
    /// <summary>
    /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
    /// 13.Interfaces
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyClass obj = new MyClass();

            obj.i = 1;
            obj.j = 2;

            Console.WriteLine("Sum from class " + obj.Sum(obj));
            Console.WriteLine("Multiplication from class " + obj.Multiplication(obj));


            MyStruct str;
            str.i = 10;
            str.j = 20;
            

            Console.WriteLine("Sum from structure " + str.Sum(str));
            Console.WriteLine("Multiplication from structure " + str.Multiplication(str));

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }


    interface IMaths<T>
    {
         int Sum(T obj);

        int Multiplication(T obj);
    }

    //static class MyStaticClass: IMaths<MyStaticClass>
    //{
    //}
    class MyClass : IMaths<MyClass>
    {
        public int i { get; set; }
        public int j { get; set; }

        public int Multiplication(MyClass obj)
        {
            return obj.i * obj.j;

        }

        public int Sum(MyClass obj)
        {
            return obj.i + obj.j;
        }
    }

    struct MyStruct : IMaths<MyStruct>
    {
        public int i;
        public int j;

        public int Multiplication(MyStruct obj)
        {
            return obj.i * obj.j;

        }

        public int Sum(MyStruct obj)
        {
            return obj.i + obj.j;
        }
    }
}
