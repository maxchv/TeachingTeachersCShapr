using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pentagon
{
    class Program
    {
        static List<string> ColorPallete = new List<string>() { "steelblue", "DarkOrchid", "DarkSlateBlue", "Teal", "Indigo" };
        static int currColor = 0;

        static void Main(string[] args)
        {
            DrawPentagon();
        }

        private static void DrawPentagon()
        {
            // Показать черепашку            
            Turtle.Show();

            // Задать максимальную скорость черепашки 10
            Turtle.Speed = 10;

            // Выполнить функцию Draw
            Draw();
        }

        private static void Draw()
        {
            
            // Повторять 200 раз
            for (int i = 0; i < 200; i++)
            {
                // Поменять цвет кисти
                ColorWeel();
                // Переместить черепашку на 1 пиксель
                Turtle.Move(1);
                // Повернуть черепашку на угол 1/5 от 360 градусов
                Turtle.Turn(360 / 5);
                // Повернуть черепашку на угол 1 град                               
                Turtle.Turn(1);
            }
        }
        private static string ColorWeel()
        {
            if (currColor < ColorPallete.Count)
            {
                currColor++;
            }
            else
            {
                currColor = 1;
            }
            return ColorPallete[currColor - 1];
        }

    }
}
