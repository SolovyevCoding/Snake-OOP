using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public abstract class GameObject
    {
        public List<Point> Points { get; set; } = new List<Point>();

        public void Draw()
        {
            foreach (Point point in Points)
            {
                point.Draw();
            }
        }

        public bool IsHit(Point point)
        {
            foreach (Point point1 in Points)
            {
                if (point1.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsHit(GameObject gameObject)
        {
            foreach (Point point in Points)
            {
                if (gameObject.IsHit(point))
                {
                    return true;
                }
            }
            return false;
        }

    }
}
