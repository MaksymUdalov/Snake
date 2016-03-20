using System;


namespace Snake
{
    class Point
    {
        int x;
        int y;
        char sym;

        public Point()
        {

        }
        public Point(int x, int y, char sym)
        {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }

        public Point(Point point)
        {
            x = point.x;
            y = point.y;
            sym = point.sym;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
        public void Clear()
        {
            sym = ' ';
            Draw();
        }

        public void FoodToSnake(Point food)
        {
            food.sym = '+';
        }

        public void Move(int offset, Direaction direction)
        {
            switch (direction)
            {
                case Direaction.LEFT:
                    x -= offset;
                    break;
                case Direaction.RIGHT:
                    x += offset;
                    break;
                case Direaction.UP:
                    y -= offset;
                    break;
                case Direaction.DOWN:
                    y += offset;
                        break; 
            }
        }

        public override bool Equals(object obj)
        {
            Point point = obj as Point;
            return x == point.x && y == point.y;
        }

        public override int GetHashCode()
        {
            return int.Parse(string.Format("{0}{1}", x, y));
        }

        public override string ToString()
        {
            return string.Format("x = {0}, y = {1}, symbol = {2}",
                x, y, sym);
        }
    }
}
