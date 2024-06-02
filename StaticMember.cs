using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class CircleMember
    {
        private static float _PI ;
        private int _radius;

        static CircleMember()
        {
            Console.WriteLine("Static Const");
            CircleMember._PI = 3.14F;
        }
        public CircleMember(int Radius)
        {
            Console.WriteLine("Instance Const");
            _radius = Radius;
        }

        public float CalculateArea()
        {
            float area = CircleMember._PI * _radius * _radius;
            return area;
        }

    }
   

}
