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
           
            // Задать максимальную скорость черепашки 10
           
            // Выполнить функцию Draw
          
        }

        private static void Draw()
        {
            
            // Повторять 200 раз
           
                // Поменять цвет кисти 
                GraphicsWindow.BrushColor = ColorWeel();
                // Переместить черепашку на 1 пиксель
                
                // Повернуть черепашку на угол 1/5 от 360 градусов
                
                // Повернуть черепашку на угол 1 град                               
          
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
