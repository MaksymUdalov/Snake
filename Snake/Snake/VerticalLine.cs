﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class VerticalLine
    {
        List<Point> pList;

        public VerticalLine()
        {
            pList = new List<Point>();
        }

        public VerticalLine(int yTop, int yDown, int x, char sym) : this()
        {
            for (int y = yTop; y <= yDown; y++)
                pList.Add(new Point(x, y, sym));
        }

        public void Draw()
        {
            foreach (Point point in pList)
                point.Draw();
        }
    }
}
