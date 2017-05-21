using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWidth, int mapHeigh)
        {
            wallList = new List<Figure>();

            HorizontalLine lineUP = new HorizontalLine(0, mapWidth-2, 0, '+');
            HorizontalLine lineDOWN = new HorizontalLine(0, mapWidth-2, mapHeigh-1, '+');
            VerticalLine lineLEFT = new VerticalLine(0, 0, mapHeigh-1, '+');
            VerticalLine lineRIGHT = new VerticalLine(mapWidth-2, 0, mapHeigh-1, '+');

            wallList.Add(lineUP);
            wallList.Add(lineDOWN);
            wallList.Add(lineLEFT);
            wallList.Add(lineRIGHT);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Draw()
        {
            foreach (var wall in wallList)
            {
                wall.DrawLine();
            }
        }
    }
}
