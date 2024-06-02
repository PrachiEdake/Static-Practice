using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class delegate_class
    {
        public delegate void MyDelegate(int a, int b);

        public class XX
        {
            public event MyDelegate MyEvent;

            public void RaiseEvent(int a, int b)
            {
                MyEvent(a, b);
                Console.WriteLine("Event Raised");
            }

            public void Add(int x, int y)
            {
                Console.WriteLine("Add Method {0}", x + y);
            }

            public void Subtract(int x, int y)
            {
                Console.WriteLine("Subtract Method {0}", x - y);
            }
        }

    }
}