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

        public List<Point> GetSnakeAsFigure()
        {
            return pList;
        }

        public void Move()
        {
            Point tail = new Point(pList.First());
            pList.Remove(tail);
            Point head = new Point(GoNextPoint());
            pList.Add(head);

            tail.Clear();
            head.Draw();
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.LeftArrow:
                    direction = direction = direction == Direaction.RIGHT ? direction : Direaction.LEFT;
                    break;
                case ConsoleKey.RightArrow:
                    direction = direction = direction == Direaction.LEFT ? direction : Direaction.RIGHT;
                    break;
                case ConsoleKey.UpArrow:
                    direction = direction = direction == Direaction.DOWN ? direction : Direaction.UP;
                    break;
                case ConsoleKey.DownArrow:
                    direction = direction = direction == Direaction.UP ? direction : Direaction.DOWN;
                    break;
            }
        }


        private Point GoNextPoint()
        {
            Point nextPoint = new Point(pList.Last());
            nextPoint.Move(1, direction);
            return nextPoint;
        }
    }
}
