using Microsoft.SmallBasic.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpiderNet
{
    // Рисование паутины
    class Program
    {
        //Объявить статическую переменную length типа float и задать значение 10
        static float length = 10;
        //Объявить статическую переменную zoom типа float и установить 1        
        static float zoom = 1;
        static void Main(string[] args)
        {
            DrawSpiderWeb();
        }

        static void DrawSpiderWeb()
        {
            //Установить скорость черепашки равную 10            
            Turtle.Speed = 10;
            //Установить толщину линии 1 пиксель
            GraphicsWindow.PenWidth = 1;
            //Установить цвет линии silver             
            GraphicsWindow.BrushColor = "Silver";

            //Повторять 10 раз
            for (int i = 0; i < 10; i++)
            {
                //  Выполнить функцию WeaveOneLayer
                WeaveOneLayer();
                // изменить значение zoom = zoom * 1.3F
                zoom *= 1.3F;
            }           
        }

        private static void WeaveOneLayer()
        {
            // Повторять 6 раз            
            for (int i = 0; i < 6; i++)
            {
                // Нарисовать треугольник вызвав функцию DrawTriangle()
                DrawTriangle();
                // Повернуть черепашку на 1/6 от 360 градусов на право                
                Turtle.Turn(360 / 6);
                // Увеличить значение текущей длины линии на текущее значение zoom
                length += zoom;
            }
        }

        private static void DrawTriangle()
        {
            // Повторять 3 раза            
            for (int i = 0; i < 3; i++)
            {
                //  Переместить черепашку на текущую длину length
                Turtle.Move(length);
                //  Повернуть черепашку на 1/3 от 360 град
                Turtle.Turn(360 / 3);
            }
        }
    }
}
