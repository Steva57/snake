using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize( 800, 240);
            // Отрисовка рамочки
            HorizontalLlne upline = new HorizontalLlne(0, 78, 0, '+');
            HorizontalLlne downline = new HorizontalLlne(0, 78, 24, '+');
            VerticalLine leftline = new VerticalLine(0, 24, 0, '+');
            VerticalLine rightLine = new VerticalLine(0, 24, 78, '+');
            upline.Drow();
            downline.Drow();
            leftline.Drow();
            rightLine.Drow();

            //*/


            Console.ReadLine();
        }
     }
}
