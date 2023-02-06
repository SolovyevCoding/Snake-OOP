using Snake.Models;
using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            MapGenerator mapGenerator = new MapGenerator();
            Map map = mapGenerator.Generate(Enums.MapType.Box, 30, 80);
            map.Draw();
            Point tale = new Point(10, 12, '*');
            SnakeObject snake = new SnakeObject(tale, 3, Enums.MoveDirection.Down);
            snake.Draw();

            map.GenerateFood();
            while (true)
            {
                if (map.IsHit(snake) || snake.IsHitTale())
                {
                    break;
                }

                if (snake.EatFood(map.Food))
                {
                    map.GenerateFood();
                }

                snake.Move();
                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    snake.HandleKey(Console.ReadKey().Key);
                }
            }

            

        }
    }
}
