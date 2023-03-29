using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Robot
    {
        public int x, y;
        public char orientation;
        public int maxX, maxY;

        public Robot(int x, int y, char orientation, int maxX, int maxY)
        {
            this.x = x;
            this.y = y;
            this.orientation = orientation;
            this.maxX = maxX;
            this.maxY = maxY;
        }

        public void Move(string instructions)
        {
            foreach (char instruction in instructions)
            {
                switch (instruction)
                {
                    case 'L':
                        TurnLeft();
                        break;
                    case 'R':
                        TurnRight();
                        break;
                    case 'M':
                        MoveForward();
                        break;
                }
            }
        }

        private void TurnLeft()
        {
            switch (orientation)
            {
                case 'N':
                    orientation = 'W';
                    break;
                case 'E':
                    orientation = 'N';
                    break;
                case 'S':
                    orientation = 'E';
                    break;
                case 'W':
                    orientation = 'S';
                    break;
            }
        }

        private void TurnRight()
        {
            switch (orientation)
            {
                case 'N':
                    orientation = 'E';
                    break;
                case 'E':
                    orientation = 'S';
                    break;
                case 'S':
                    orientation = 'W';
                    break;
                case 'W':
                    orientation = 'N';
                    break;
            }
        }

        private void MoveForward()
        {
            switch (orientation)
            {
                case 'N':
                    if (y < maxY) y++;
                    break;
                case 'E':
                    if (x < maxX) x++;
                    break;
                case 'S':
                    if (y > 1) y--;
                    break;
                case 'W':
                    if (x > 1) x--;
                    break;
            }
        }

        public override string ToString()
        {
            return $"{x} {y} {orientation}";
        }
    }
}
