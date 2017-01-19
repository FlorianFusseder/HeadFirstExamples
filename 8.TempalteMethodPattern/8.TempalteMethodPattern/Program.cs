using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.TempalteMethodPattern
{
    class Program
    {

        //weiter seite 312
        static void Main(string[] args)
        {
            new Tea().prepareRecipte();
            Console.WriteLine();
            new Coffee().prepareRecipte();

        }
    }
}
