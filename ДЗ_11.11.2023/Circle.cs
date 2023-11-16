using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_11._11._2023
{
    internal class Circle : Point
    {
        private string square;

        public double radius { get; set; } 
        public Circle(int x, int y, string color, bool condition = true) : base(x,y,color, condition)
        {
            radius = radius;
        }
        public double Square()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
        public void PrintSquare()
        {
            Console.WriteLine("Площадь:" + square);
        }
    }
}
