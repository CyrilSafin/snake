using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ограничение окна
            //Console.SetBufferSize(80, 25);
#region Wall

            Walls walls = new Walls(80, 25);
            walls.Draw();

            
            #endregion

#region SnakeBody

            point p = new point(4, 5, '*');
            Snakee snake = new Snakee(p,4,Direction.RIGHT);
            snake.DrawLine();
#endregion

#region Food 

            foodCreator foodCreator = new foodCreator(80, 25, '$');
            point food = foodCreator.CreateFood();
            food.Draw();

#endregion

            while (true)
            { 
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                    //Console.Write("Game OVER");
                }
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }

#region Handle Key

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
                Thread.Sleep(100);
                snake.Move();
            }
#endregion




            //Console.ReadKey();

        }

        
    }
}
