using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_11._11._2023
{
    internal class Rectangle: Point
    {
        public int side1;
        public int side2;
        private string square;

        public Rectangle(int side1, int side2,int x, int y, string color, bool condition = true) : base(x, y, color, condition)
        {
            side1 = side1;
            side2 = side2;
        }
        public int Square()
        {
            return side1 * side2;
        }
        public void PrintSquare()
        {
            Console.WriteLine("Площадь прямоугольника:" + square);
        }
    }
}
