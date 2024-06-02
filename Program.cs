using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ConsoleApp2.delegate_class;

namespace ConsoleApp2
{
    internal class Program
    {
        public delegate void Callback(string message);
        static void Main(string[] args)
        {
            //////------Test Staic Member--------'

            ////CircleMember staticMember1 = new CircleMember(5);
            ////CircleMember staticMember2 = new CircleMember(6);
            //////CircleMember C1 = new CircleMember();
            ////staticMember1.CalculateArea();
            ////staticMember2.CalculateArea();

            //////------Test Staic Method--------'

            ////CircleMethod staticMethod1 = new CircleMethod(5);
            ////CircleMethod staticMethod2 = new CircleMethod(6);
            //////CircleMember C1 = new CircleMember();
            ////staticMember1.CalculateArea();
            ////float pi = CircleMethod.PiValue(); 


            //////------Test Staic Class--------'

            ////float area = CircleClass.CalculateArea();
            ////float pival = CircleClass.piValue(8);         ///          

            // Instantiate the delegate.
            //Callback handler = DelegateMethod;

            //// Call the delegate.
            //handler("Hello World");

            //handler = DelegateMethod1;

            //handler("Hello World2");

            XX obj = new XX();
            obj.MyEvent += new MyDelegate(obj.Add);
            obj.MyEvent += new MyDelegate(obj.Subtract);
            obj.RaiseEvent(20, 10);

            Console.WriteLine("......");
            Console.ReadLine();
        }

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            Console.WriteLine(message);
        }

        public static void DelegateMethod1(string message)
        {
            Console.WriteLine(message);
        }
    }

}
