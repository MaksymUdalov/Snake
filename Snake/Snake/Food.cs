using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Food
    {
        const char sym = '$';
        int displayWidth;
        int displayHeight;

        public Food(int displayWidth, int displayHeight)
        {
            this.displayWidth = displayWidth;
            this.displayHeight = displayHeight;
        }

        public Point CreateFood(Snake snake)
        {
            Point food = new Point();
            bool valid = true;
            while (valid)
            {
                Random random = new Random();
                food = new Point(random.Next(2, displayWidth - 2), random.Next(2, displayHeight - 2), sym);
                valid = false;
                foreach(Point point in snake.GetSnakeAsFigure())
                {
                    if (point.Equals(food))
                        valid = false;
                }
            }
            return food;
        }
    }
}
