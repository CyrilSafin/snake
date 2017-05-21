using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    class foodCreator
    {
        int mapWidth;
        int mapHight;
        char sym;

        Random random = new Random();

        public foodCreator(int mapWidth, int mapHight, char sym)
        {
            this.mapWidth = mapWidth;
            this.mapHight = mapHight;
            this.sym = sym;
        }

        public point CreateFood()
        {
            int x = random.Next(2, mapWidth - 2);
            int y = random.Next(2,mapHight-2);
            return new point(x, y, sym);
        }

    }
}
