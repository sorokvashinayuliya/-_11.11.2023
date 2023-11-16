using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ДЗ_11._11._2023
{
    internal class Figure
    {
        public string color;
        public bool condition;
        public Figure(string color,bool condition)
        {
            this.color = color;
            this.condition = condition;
        }
        public void MoveHorizontal(int distance)
        {
            Console.WriteLine("Фигуру переместили по вертикали на расстояние" + distance);
        }
        public void MoveVertical(int distance)
        {
            Console.WriteLine("Фигуру переместили по вертикали на расстояние" + distance);
        }
        public void changeColor(string newColor)
        {
            color=newColor;
        }
        public string changeCondition()
        {
            return condition ? "видимый" : "невидимый";
        }
        public void Conclution()
        {
            Console.WriteLine("Цвет фигуры:" + color);
            Console.WriteLine($"Состояние: {changeCondition()}");
        }

    }
}
