using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{
    public class test
    {
        public void data()
        {
            Console.WriteLine("this is test class");
        }

    }

    public interface inter
    {
        void face();

    }




    public abstract class Example :test, inter
    {
     public abstract void fun();

        public void fun2()
        {
            Console.WriteLine("simple");

        }
        public void face()
        {
            Console.WriteLine("this is interface");

        }
       
    }

    public class  Chetu : Example
    {
        public override void fun()
        {
            Console.WriteLine("this abstract class");

        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Chetu cc = new Chetu();
            cc.fun();
            cc.fun2();
            cc.face();
            cc.data();
            Console.ReadLine();
        }
    }
}