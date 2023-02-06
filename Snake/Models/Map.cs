using System.Collections.Generic;

namespace Snake.Models
{
    public class Map
    {
        public FoodGenerator foodGenerator { get; set; }
        public Point Food { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Name { get; set; }

        public List<GameObject> GameObjects { get; set; }

        public Map(int height, int width, string name, List<GameObject> gameObjects)
        {
            this.Height = height;
            this.Width = width;
            this.Name = name;
            this.GameObjects = gameObjects;
            foodGenerator = new FoodGenerator(Height, Width, '*');
        }

        public void Draw()
        {
            foreach (GameObject gameObject in GameObjects)
            {
                gameObject.Draw();
            }
        }

        public bool IsHit(GameObject gameObject)
        {
            foreach (GameObject go in GameObjects)
            {
                if(go.IsHit(gameObject))
                {
                    return true;
                }
            }
            return false;
        }

        public void GenerateFood()
        {
            Food = foodGenerator.Generate();
            Food.Draw();
        }


    }
}
