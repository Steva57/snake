using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figura
    {
        protected List<Point> pList;

        public virtual void Draw()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
