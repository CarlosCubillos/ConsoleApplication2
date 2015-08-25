using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    public class Fire
    {
        public DelegateContainer.MyDelegate myDelegate;
        //public void FireDelegate()
        //{
        //    DelegateSubscriber delegateSubscriber = new DelegateSubscriber();
        //    myDelegate += delegateSubscriber.ListeningMethod1;
        //    myDelegate += delegateSubscriber.ListeningMethod2;
        //    myDelegate += delegateSubscriber.ListeningMethod3;
        //    string x = myDelegate("valor1", "valor2");

        //}

        public bool DevolverTrue(DateTime fecha)
        {
            if(fecha > DateTime.Now)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public void FireDelegateFunc()
        {
            Dictionary<string, Func<DateTime, bool>> test = new Dictionary<string, Func<DateTime, bool>>();
            Func<DateTime, bool> delegado1 = DevolverTrue;
            DateTime fechax = new DateTime(1985, 1, 1);
            test.Add("val", delegado1);
            Dictionary<string, string> test2 = new Dictionary<string, string>();
            test["val"].Invoke(fechax);
            DelegateSubscriber delegateSubscriber = new DelegateSubscriber();
            Func<string, int, long> myDel = delegateSubscriber.ListeningMethod1;
            //myDel += delegateSubscriber.ListeningMethod2;
            
            long j = myDel("juan", 1);
            long x = myDel("valor1", 1);

        }
    }
}
