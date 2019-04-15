using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figura
    {
        protected List<Point> pList;

        public void Drow()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
