using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Constructors
{
    /// <summary>
    /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
    /// 4. Constructors
    /// Default constructors
    /// Static constructors
    /// Instance Constructors
    /// Private Constructors
    /// Copy Constructors
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            #region Default constructors & Instance constructors

            //BaseClass dc = new BaseClass();
            //Console.WriteLine("Defualt Constructors initialized = {0}", dc.isInitialized);
            //Console.WriteLine("The value of sum dc= {0}", dc.sum);
            //BaseClass dc2 = new BaseClass(10, 20);
            //Console.WriteLine("The value of sum dc2= {0}", dc2.sum);

            //ChildClass childObj = new ChildClass();
            //Console.WriteLine("Defualt Constructors initialized = {0}", childObj.isInitialized);

            //ChildClass childObj2 = new ChildClass(10, 20);
            //Console.WriteLine("The value of sum childObj2= {0}", childObj2.sum);


            //ChildClass childObj3 = new ChildClass(10, 20);
            //Console.WriteLine("Defualt Constructor from base class initialized = {0}", childObj3.isInitialized);

            //// Keep the console window open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            #endregion

            #region Private Constructors

            ////PrivateConstructorExampleClass Obj = new PrivateConstructorExampleClass(); //Error
            //PrivateConstructorExampleClass.age = 10;

            //Console.WriteLine("Age static variable value assigned is  = {0}", PrivateConstructorExampleClass.age);

            //// Keep the console window open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();

            #endregion

            #region Static Constructors
            //// StaticConstructorExampleClass Obj = new StaticConstructorExampleClass(); //Error

            //StaticConstructorExampleClass Obj1 = new StaticConstructorExampleClass(10, 20);

            //StaticConstructorExampleClass Obj2 = new StaticConstructorExampleClass(10, 20, 30);

            //// Keep the console window open in debug mode.
            //Console.WriteLine("Press any key to exit.");
            //Console.ReadKey();
            #endregion

            #region Copy Constructors
            // Create a Person object by using the instance constructor.
            CopyConstructorExampleClass Obj = new CopyConstructorExampleClass("Divakar");

            // Create another Person object, copying person1.
            CopyConstructorExampleClass Obj2 = new CopyConstructorExampleClass(Obj);

            Obj.Name = "Alex";

            Console.WriteLine("Name from instance constructor is {0}" ,Obj.Name);

            Console.WriteLine("Name from copy constructor is {0}", Obj2.Name);

         
            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
            #endregion
        }
    }


    #region Default constructors  & Instance constructors

    public class BaseClass
    {
        public bool isInitialized = false;
        public BaseClass()
        {
            isInitialized = true;
            Console.WriteLine("Default Constructor from the base class");
        }

        public int sum;
        public int i, j;
        public BaseClass(int i, int j)
        {
            sum = i + j;
            this.i = i;
            this.j = j;
        }
    }

    public class ChildClass : BaseClass
    {

        //public ChildClass()  
        //{

        //}

        public ChildClass() : base()
        {
            Console.WriteLine("Default Constructor from the child class");
        }

        //public ChildClass(int i, int j) : base(i, j)
        //{

        //}

        public ChildClass(int multiplication)
        {
            Console.WriteLine("'this' keyword example constructor");
        }

        public ChildClass(int i, int j) : this(i * j)
        {

        }

    }

    #endregion

    #region Private Constructors
    public class PrivateConstructorExampleClass
    {
        private PrivateConstructorExampleClass()
        {

        }

        public static int age;


    }
    #endregion

    #region Static Constructors

    public class StaticConstructorExampleClass
    {

        protected static readonly DateTime startTime;
        static StaticConstructorExampleClass()
        {
            startTime = DateTime.Now;
            Console.WriteLine("Static constructor is initialized at " + startTime.ToLongTimeString());
        }



        protected int sum { get; set; }
        // Instance constructor.
        public StaticConstructorExampleClass(int x, int y)
        {
            sum = x + y;
            Console.WriteLine("Sum of x and y is = {0}", sum);
        }



        protected int multiplication { get; set; }
        // Instance constructor.
        public StaticConstructorExampleClass(int x, int y, int z)
        {
            multiplication = x * y * z;
            Console.WriteLine("multiplication of x,y and z is = {0}", multiplication);
        }


    }


    #endregion

    #region Copy Constructors

    public class CopyConstructorExampleClass
    {
        public string Name { get; set; }

        // Instance constructor.
        public CopyConstructorExampleClass(string name)
        {
            Name = name;
        }

        // Copy constructor.
        public CopyConstructorExampleClass(CopyConstructorExampleClass previousCtor)
        {
            Name = previousCtor.Name;
        }


    }

    #endregion
}
