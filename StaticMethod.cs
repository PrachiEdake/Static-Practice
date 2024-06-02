using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class CircleMethod
    {
        static float _PI = 3.14F;
        int _radius;


        static CircleMethod()
        {
            //Console.WriteLine("Static Const");
            CircleMethod._PI = 3.14F;
        }
        public CircleMethod(int Radius)
        {
            _radius = Radius;
        }

        //Static function uses only static members
        public static float PiValue()
        {
            float pival = _PI;
            return pival;
        }

        //Static function can't use non-static fields
        //public static float Perimeter()
        //{
        //    float per = 2 * _PI * _radius;
        //    return per;
        //}
        public float CalculateArea()
        {
            float area = _PI * _radius * _radius;
            return area;
        }
    }


    public class StaticCon
    {
        static StaticCon()
        {

        }

        private StaticCon()
        {

        }

        public StaticCon(int i)
        {

        }
    }
}
