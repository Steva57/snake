using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorizontalLlne: Figura
    {
  
        public HorizontalLlne(int xLeft, int xReight, int y, char sym)
        {
            pList = new List<Point>();
            for (int x = xLeft; x <= xReight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);

            }
        
        }
      }
}
