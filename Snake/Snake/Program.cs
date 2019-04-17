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
            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');
            Draw(v1);

            // Отрисова точки

            Point p = new Point(4, 5, '*');
            Figura fSnake = new Snake(p, 4, Direction.RIGHT);
            Draw(fSnake);
            Snake snake = (Snake)fSnake;

            HorizontalLlne h1 = new HorizontalLlne(0, 5, 6, '&');
            List<Figura> figures = new List<Figura>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach (var f in figures)
            {
                f.Draw();

            }
                               
        } 
        static void Draw(Figura figura)
        {
            figura.Draw();
        //   Console.ReadLine();
        }
       
     }
}
