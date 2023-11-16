using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_11._11._2023
{
    internal class Point:Figure
    {
        private int x;
        private int y;
        public Point(int x, int y,string color,bool condition=true) :base(color,condition)
        {
            x = x;
            y = y;
        }
        public void MoveHorizontal(int distance)
        {
            x += distance;
        }
        public void MoveVertical(int distance)
        {
            y += distance;
        }
        public void PrintCoordinates()
        {
            Console.WriteLine("Координаты:({0},{1})",x,y);
        }
    }
}
