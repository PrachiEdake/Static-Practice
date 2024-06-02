using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal static class CircleClass
    {
        public static float _PI;
        static int _radius;

        static CircleClass()
        {
            _radius = 2;
            _PI = 3.14F;
        }

        public static float CalculateArea()
        {
            float area = _PI * _radius * _radius;
            return area;
        }

        public static float piValue(int dia)
        {
            float pival = _PI * dia;
            return pival;
        }

    }
}
