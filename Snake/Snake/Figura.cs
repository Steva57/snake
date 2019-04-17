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
        internal bool IsHit(Figura figura)
        {
            foreach(var p in pList)
            {
                if (figura.IsHit(p))
                    return true;
                }
                return false;
             }
        private bool IsHit(Point point)
            {
            foreach (var p in pList)
            {
                if (p.IsHit(point))
                    return true;
            }
            return false;
         }
    }
}
