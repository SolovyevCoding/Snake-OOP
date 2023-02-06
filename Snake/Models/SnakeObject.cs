using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Snake.Models
{
    public class SnakeObject : GameObject
    {
        private Point tale;
        private Point head;
        private MoveDirection moveDirection;
        

        public SnakeObject(Point tale, int lenght, MoveDirection moveDirection)
        {
            this.tale = tale;
            this.moveDirection = moveDirection;

            Init(lenght);
        }
        //Наполняет список точек.
        private void Init(int lenght) 
        {
            this.Points.Add(tale);
            for (int i = 1; i < lenght; i++)
            {
                Point point = (Point)Points.Last().Clone();
                point.Move(moveDirection, 1);
                this.Points.Add(point);
            }
            head = Points.Last();
        }

        public void Move() 
        {
            DeleteTale();
            AddHead();
        }

        private void DeleteTale()
        {
            Points.Remove(tale);
            tale.Delete();
            tale = Points.First();
        }

        private void AddHead()
        {
            head = (Point)Points.Last().Clone();
            head.Move(moveDirection, 1);
            this.Points.Add(head);
            head.Draw();
        }

        public void HandleKey(ConsoleKey key)
        {
            switch (key)
            {

                case ConsoleKey.LeftArrow:
                    if (moveDirection == MoveDirection.Right)
                    {
                        return;
                    }
                    moveDirection = MoveDirection.Left;

                    break;

                case ConsoleKey.UpArrow:
                    if (moveDirection == MoveDirection.Down)
                    {
                        return;
                    }
                    moveDirection = MoveDirection.Up;

                    break;

                case ConsoleKey.RightArrow:
                    if (moveDirection == MoveDirection.Left)
                    {
                        return;
                    }
                    moveDirection = MoveDirection.Right;

                    break;

                case ConsoleKey.DownArrow:
                    if (moveDirection == MoveDirection.Up)
                    {
                        return;
                    }
                    moveDirection = MoveDirection.Down;

                    break;

                    
            }
        }

        public bool IsHitTale()
        {
            Point nextHead = (Point)Points.Last().Clone();
            nextHead.Move(moveDirection, 1);

            return IsHit(nextHead);
        }

        public bool EatFood(Point food)
        {
            Point nextHead = (Point)Points.Last().Clone();
            nextHead.Move(moveDirection, 1);
            if (nextHead.IsHit(food))
            {
                food.Symbol = nextHead.Symbol;
                Points.Add(food);
                return true;
            }
            return false;
        }
    }
}
