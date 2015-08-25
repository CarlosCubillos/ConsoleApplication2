using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class DelegateSubscriber
    {
        public long ListeningMethod1(string value1, int value2)
        {
            Console.Write("Method1 - " + value1 + value2);
            return 0;
        }

        public long ListeningMethod2(string value1, int value2)
        {
            Console.Write("Method2 - " + value1 + value2);
            return 0;
        }

        public string ListeningMethod3(string value1, string value2)
        {
            Console.Write("Method3 - " + value1 + value2);
            return "Method3 - " + value1 + value2;
        }
    }
}
