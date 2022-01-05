using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
   public class Observer1
    {
        public void updates()
        {
            IObservable<string> data = DataStream.GetMesasge();            
            data.Subscribe(updates=> {
                Console.WriteLine(updates);
            });
        }
    }
}
