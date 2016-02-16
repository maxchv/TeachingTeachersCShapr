using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OctagonWithOverlap
{
    class Program
    {
        static List<string> ColorPallete;
        private static int currColor = 0;

        static void Main(string[] args)
        {
            Draw();
        }

        private static void Draw()
        {
            // Задать максимальную скорость черепашки
            
            //Вызвать операцию CreateColorPalette (инструкция внизу) 
            
            // Повторять цикл 30 раз 
            
                //Установить следующий цвет пера вызвав операцию NextColor --#5
                GraphicsWindow.PenColor = NextColor();
                //Вызвать метод DrawOctagonWithOverlap (инструкция внизу) --#8
                
                // Повернуть черепашку на  1/30от 360 градусов 
                
                // Повернуть черепашку еще на 5 градусов  
                
            //Конец цикла 30 раз
        }

        private static void DrawOctagonWithOverlap()
        {
            // Начать цикл 9 раз 
            
                //Переместить черепашку на 110 пикселей 
                
                //Повернуть черепашку на  1/8 от 360 градусов 
            //  Конец цикла 9 раз
           
        }

        private static void CreateColorPalette()
        {
            ColorPallete = new List<string>() { "HotPink", "Red", "Fuchsia", "OrangeRed", 
                                                "DeepPink", "MediumVioletRed", "Crimson", "Tomato" };
        }

        private static string NextColor()
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
