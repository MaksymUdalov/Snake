using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Snake : Figure
    {
        Direaction direction;
        
        public Snake(Point startPosition, int length, Direaction direction)
        {
            this.direction = direction;
            pList = new List<Point>();

            for(int x = 0; x < length; x++)
            {
                Point tail = new Point(startPosition);
                tail.Move(x, direction);
                pList.Add(tail);
            }
        }
    }
}
