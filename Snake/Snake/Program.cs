using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Установка фиксированного окна
            Console.SetBufferSize(80, 25);

            //Создаём рамку
            Walls walls = new Walls(80, 25, '+');
            walls.Draw();



            Console.ReadLine();

        }
    }
}
