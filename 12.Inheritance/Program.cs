using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Inheritance
{

    /// <summary>
    /// OOPS concepts - Object oriented programming concepts training program from Clouds.training
    /// 12.Inheritance
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {


            //AdminUser obj = new AdminUser();
            SuperAdminUser obj = new SuperAdminUser();

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }

    public class Users
    {
        public virtual void AddUser(int i)
        {
            // abstract example
        }


        public virtual void UpdateUser(int i)
        {
            // sealed example
        }
    }

    public abstract class AdminUser : Users
    {
        public abstract override void AddUser(int i);

        public sealed override void UpdateUser(int i) {
            //implementation
        }
    }

    public class SuperAdminUser : AdminUser
    {
        public override void AddUser(int i)
        {
            // New implementation.
        }

        //public abstract override void AddUser1(int i);

        //public override void UpdateUser(int i)
        //{
        //    // New implementation.
        //}

    }


    //Basic example 1
    //public sealed class SealedClass{};

    //public abstract class BaseClass1 { }

    //public abstract class BaseClass { }

    //public class DerivedClass : BaseClass { }




}
