using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Fire fire = new Fire();
            //fire.FireDelegate();
            fire.FireDelegateFunc();
            Console.ReadLine();
        }
    }
}
