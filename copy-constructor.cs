using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp
{ 
    public class add
    {

        int a, b, sum;
        public add(int x,int y)
        {
            a = x;
            b = y;
            sum = x + y;
            Console.WriteLine(sum);

        }

        public add(add obj)
        {
            a = obj.a;
            b = obj.b;
            int min = a - b;

            Console.WriteLine(min);
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            add aa = new add(50,5);


            add bb = new add(aa);

            Console.ReadKey();
        }
    }
}