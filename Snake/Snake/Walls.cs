using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Walls
    {
        List<Figure> walls;


        public Walls()
        {
            walls = new List<Figure>();
        }

        public Walls(int displayWidth, int displayHeight, char sym) : this()
        {
            walls.Add(new HorizontalLine(0, displayWidth - 2, 0, sym));
            walls.Add(new HorizontalLine(0, displayWidth - 2, displayHeight - 1, sym));
            walls.Add(new VerticalLine(0, displayHeight - 1, 0, sym));
            walls.Add(new VerticalLine(0, displayHeight - 1, displayWidth - 2, sym));
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            foreach(Figure figure in walls)
                figure.Draw();
            Console.ForegroundColor = ConsoleColor.White;
        }

    }
}
