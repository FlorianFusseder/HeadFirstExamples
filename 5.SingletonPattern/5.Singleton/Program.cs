using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Singleton
{
    class Program
    {
        

        static void Main(string[] args)
        {
            var a = MySingleton.Instance;
            var b = MySingleton.Instance;

            Console.WriteLine(a == b ? "gleich" : "nicht gleich");
            
            Console.ReadLine();
        }
    }
}
