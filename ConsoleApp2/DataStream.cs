using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reactive;
using System.Reactive.Subjects;
using System.Threading;

namespace ConsoleApp2
{
    public static class DataStream
    {

        public static BehaviorSubject<string> message = new BehaviorSubject<string>("Hello");
        static public void UpdateSubject()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(10000);
                message.OnNext(i.ToString());
            }
        }

        public static IObservable<string> GetMesasge()
        {
            return message;
        }
    }
}
