﻿using Microsoft.SmallBasic.Library;
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
        //Объявить статическую переменную length вещественного типа и задать значение 10
        
        //Объявить статическую переменную zoom вещественного типа и установить 1        
       
        static void Main(string[] args)
        {
            DrawSpiderWeb();
        }

        static void DrawSpiderWeb()
        {
            //Установить скорость черепашки равную 10            
            
            //Установить толщину линии 1 пиксель
            GraphicsWindow.PenWidth = 1;
            //Установить цвет линии silver             
            GraphicsWindow.BrushColor = "Silver";

            //Повторять 10 раз
            
                // Выполнить функцию WeaveOneLayer
               
                // изменить значение zoom = zoom * 1.3
                
            
        }

        private static void WeaveOneLayer()
        {
            // Повторять 6 раз            
            for (int i = 0; i < 6; i++)
            {
                // Нарисовать треугольник вызвав функцию DrawTriangle()
                
                // Повернуть черепашку на 1/6 от 360 градусов на право                
                
                // Увеличить значение текущей длины линии на текущее значение zoom
               
            }
        }

        private static void DrawTriangle()
        {
            // Повторять 3 раза            
            
                //  Переместить черепашку на текущую длину length
                
                //  Повернуть черепашку на 1/3 от 360 град
                
           
        }
    }
}
