using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Methods
{
    /// <summary>
    /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
    /// 3. Methods
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize Class:  
            MyFirstClass Obj = new MyFirstClass();

            Obj.MyFirstMethod();

            int sum = Obj.MyFirstMethod(5 , 6);

            Console.WriteLine("Sum {0}", sum);


            string s = "My First Extension Method";
            int stringlength = s.StringLength();
            Console.WriteLine("Length from Extension Method {0}", stringlength);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    #region "Class Definition"
    class MyFirstClass
    {
        public void MyFirstMethod()
        {
            // Insert code here 
            Console.WriteLine("I am from MyFirstMethod()");
        }

        public int MyFirstMethod(int i, int j)
        {
            return i + j;
        }

    }

    #endregion

    public static class MyFirstExtensionMethod
    {
        public static int StringLength(this String str)
        {
            return str.Trim().Length;
        }
    }
}
