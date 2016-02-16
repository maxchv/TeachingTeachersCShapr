using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalFlower
{
    class Program
    {        
        static List<string> ColorPallete = new List<string>() { "red", "darkorange", "gold", "yellow", 
                                                                "yellow", "gold", "darkorange", "red" };
        static int currColor = 0;

        static void Main(string[] args)
        {
            DrawFlower();
        }

        private static void DrawFlower()
        {
            // Показать черепашку 
            
            // Задать максимальную скорость черепашки 10
                        
            // Задать цвет фона графического окна silver
            GraphicsWindow.BackgroundColor = "silver";
            
            // Установить ширину пера 3 пиксела
            GraphicsWindow.PenWidth = 3;
            
            // Повторять 15 раз
            
                // Выполнить функцию DrawOctogon()
               
                // Повернуть черепашку на угол равный 1/15 от 360 градусов                               
            
        }

        private static void DrawOctogon()
        {          
            //  Повторять 8 раз
           
                // Установить следующий цвет пера
                GraphicsWindow.PenColor = ColorWeel();
                // Переместить черепашку на 50 пикселей
               
                // Повернуть черепашку на угол 1/8 от 360 градусов
                
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
            return ColorPallete[currColor-1];
        }
    }
}
