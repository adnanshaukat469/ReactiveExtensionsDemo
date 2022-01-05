using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Observer1 ob1 = new Observer1();
            Observer1 ob2 = new Observer1();
            Observer1 ob3 = new Observer1();
            ob1.updates();
            ob2.updates();
            ob3.updates();
            DataStream.UpdateSubject();
        }
    }
}
