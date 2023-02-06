using Snake.Enums;
using Snake.Models;
using System.Collections.Generic;

namespace Snake
{

    public class MapGenerator
    {
        public Map Generate(MapType mapType, int height, int weight)
        {
            Map map = null;

            switch (mapType)
            {
                case MapType.Box:
                    map = GenerateBox(height, weight);
                    break;
            }

            return map;
        }

        private Map GenerateBox(int height, int width)
        {
            Line topLine = new Line(0, 0, width, '#', LineType.Horizontal);
            Line botLine = new Line(0, height, width, '#', LineType.Horizontal);

            Line leftLine = new Line(0, 0, height, '#', LineType.Vertical);
            Line rightLine = new Line(width, 0, height, '#', LineType.Vertical);

            List<GameObject> walls = new List<GameObject>()
            {
                topLine,
                botLine,
                leftLine,
                rightLine,
            };

            return new Map(height, width, "Box", walls);
        }
    }
}
