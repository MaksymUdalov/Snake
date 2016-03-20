﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake 
{
    class Figure
    {
        protected List<Point> pList;

        public void Draw()
        {
            foreach (Point point in pList)
                point.Draw();
        }

        public bool IsHit(Figure figure)
        {
            foreach(Point point in pList)
            {
                if (figure.IsHit(point))
                    return true;
            }
            return false;
        }
        public bool IsHit(Point point)
        {
            foreach(Point p in pList)
            {
                if (point.Equals(p))
                    return true;
            }
            return false;
        }
    }
}
