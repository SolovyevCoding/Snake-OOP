using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class FoodGenerator
    {
        public int MapHeight { get; set; }
        public int MapWidth { get; set; }
        public char Symbol { get; set; }
        private Random random = new Random();

        public FoodGenerator(int mapHeight, int mapWidth, char symbol)
        {
            MapHeight = mapHeight;
            MapWidth = mapWidth;
            Symbol = symbol;
        }

        public Point Generate()
        {
            int x = random.Next(2,MapWidth - 2);
            int y = random.Next(2, MapHeight - 2);
            return new Point(x,y, Symbol);
        }
    }
}
