using System;
using System.Threading;

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

            //Создаём змеючку
            Snake snake = new Snake(new Point(2, 2, '+'), 5, Direaction.RIGHT);
            snake.Draw();


            //Создаём кушанье
            Food foodWork = new Food(80, 25);
            Point food = foodWork.CreateFood(snake);
            food.Draw();

            //Старт
            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                if (snake.Eat(food))
                {
                    food = foodWork.CreateFood(snake);
                    food.Draw();
                }
                Thread.Sleep(100);
                snake.Move();
            }

            Console.ReadLine();

        }
    }
}
