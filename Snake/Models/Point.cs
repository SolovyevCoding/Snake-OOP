using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class Point: ICloneable
    {
        public char Symbol { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y, char symbol)
        {
            this.X = x;
            this.Y = y;
            this.Symbol = symbol;

        }

        public void Move(MoveDirection moveDirection, int count) 
        {
            switch (moveDirection) 
            {
                case MoveDirection.Up:
                    Y -= count;
                    break;
                case MoveDirection.Down:
                    Y += count;
                    break;
                case MoveDirection.Left:
                    X -= count;
                    break;
                case MoveDirection.Right:
                    X += count;
                    break;
            }
             
        }

        public void Draw()
        {
            Console.SetCursorPosition(X, Y);
            Console.Write(Symbol);
        }

        public void Delete() 
        {
            Symbol = ' ';
            Draw();
        }

        public bool IsHit(Point point) 
        {
            return this.X == point.X && this.Y == point.Y;
        }

        public object Clone()
        {
            return new Point(X,Y,Symbol);
        }
    }
}
