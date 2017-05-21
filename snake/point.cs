using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class point
    {
        public int x;
        public int y;
        public char sym;

        public point(int _x, int _y, char _sym)
        {
            x=_x;
            y=_y;
            sym = _sym;
        }
         
        public void Draw()
        {
            //if (x > 0 && y > 0)
            //{
                Console.SetCursorPosition(x, y);
                Console.Write(sym);
            //}
           // else Console.Write("GAME OVER");
        }


        public void Clear()
        {
            sym = ' ';
            Draw();        
        }

        public point(point p)
        {
            x = p.x;
            y = p.y;
            sym = p.sym;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction==Direction.RIGHT)
            { x = x + offset; }
            else if (direction == Direction.LEFT)
            { x = x - offset; }
            if (direction == Direction.UP)
            { y = y - offset; }
            else if (direction == Direction.DOWN)
            { y = y + offset; }
        }

        public bool IsHit(point food)
        {
            return food.x == this.x && food.y == this.y;
        }
    }
}
