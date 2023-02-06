using Snake.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake.Models
{
    public class Line: GameObject
    {
        public Line(int x, int y, int lenght, char symbol, LineType lineType)
        {
            InitPoints(x, y, lenght, symbol, lineType);
        }
        private void InitPoints(int x, int y, int lenght, char symbol, LineType lineType)
        {
 
            switch(lineType)
            {
                case (LineType.Vertical):

                    for (int i = 0; i < lenght; i++)
                    {
                        Points.Add(new Point(x, y++, symbol));
                    }
                    break;

                case (LineType.Horizontal):

                    for (int i = 0; i < lenght; i++)
                    {
                        Points.Add(new Point(x++, y, symbol));
                    }
                    break;
            }
        }

    }
}
