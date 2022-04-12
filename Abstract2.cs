using System;

namespace DEMO
{

    public class boss
    {
        public void fun()
        {
            Console.WriteLine("this is boss");

        }

    }

    interface ii
    {
        void dad();

    }
 
    public abstract class data : boss,ii
    {
        public abstract void f();

        public void f2()
        {
            Console.WriteLine("abc");
        }
        public void f3()
        {
            fun();
        }

        public void dad()
        {

            Console.WriteLine("this is dad");
        }

    }


    public class manager : data
    {
        public override void f()
        {
            Console.WriteLine("this is manager");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            manager mm = new manager();
            mm.dad();
         
        }
    }
}
