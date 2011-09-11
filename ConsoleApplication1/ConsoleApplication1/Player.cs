using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Player
    {
        private string sprite = "@";
        int[] coordinates;

        enum Grid { Row, Col };

        public Player(ref GameMap map)
        {
            coordinates = map.StartCoordinates;

            map.SetPoint(coordinates[(int) Grid.Row], coordinates[(int) Grid.Col], sprite);
        }

        public void ParseDirection(ref GameMap map, string direction)
        {
            string udirection = direction.ToUpper();
            if (udirection.Length != 0)
            {
                switch (udirection[0])
                {
                    case 'N':
                        MoveNorth(ref map);
                        break;
                    case 'E':
                        MoveEast(ref map);
                        break;
                    case 'S':
                        MoveSouth(ref map);
                        break;
                    case 'W':
                        MoveWest(ref map);
                        break;
                    default:
                        FailedDirection();
                        break;
                }
            }
        }

        public void MoveSouth(ref GameMap map)
        {
            if (map.GetPoint(coordinates[(int)Grid.Row] + 1, coordinates[(int)Grid.Col]) == "#")
            {
                Console.WriteLine("you dumb!");
            }
            else
            {
                map.SetPoint(coordinates[(int)Grid.Row], coordinates[(int)Grid.Col], ".");
                map.SetPoint(coordinates[(int)Grid.Row] + 1, coordinates[(int)Grid.Col], sprite);
                coordinates[(int)Grid.Row]+= 1;
            }
        }

        public void MoveEast(ref GameMap map)
        {
            if (map.GetPoint(coordinates[(int)Grid.Row], coordinates[(int)Grid.Col] + 1) == "#")
            {
                Console.WriteLine("you dumb!");
            }
            else
            {
                map.SetPoint(coordinates[(int)Grid.Row], coordinates[(int)Grid.Col], ".");
                map.SetPoint(coordinates[(int)Grid.Row], coordinates[(int)Grid.Col] + 1, sprite);
                coordinates[(int)Grid.Col]+= 1;
            }
        }


        public void MoveNorth(ref GameMap map)
        {
            if (map.GetPoint(coordinates[(int)Grid.Row] - 1, coordinates[(int)Grid.Col]) == "#")
            {
                Console.WriteLine("you dumb!");
            }
            else
            {
                map.SetPoint(coordinates[(int)Grid.Row], coordinates[(int)Grid.Col], ".");
                map.SetPoint(coordinates[(int)Grid.Row] - 1, coordinates[(int)Grid.Col], sprite);
                coordinates[(int)Grid.Row]-=1;
            }
        }


        public void MoveWest(ref GameMap map)
        {
            if (map.GetPoint(coordinates[(int)Grid.Row], coordinates[(int)Grid.Col] - 1) == "#")
            {
                Console.WriteLine("you dumb!");
            }
            else
            {
                map.SetPoint(coordinates[(int)Grid.Row], coordinates[(int)Grid.Col], ".");
                map.SetPoint(coordinates[(int)Grid.Row], coordinates[(int)Grid.Col] - 1, sprite);
                coordinates[(int)Grid.Col] -= 1;
            }
        }

        public void FailedDirection()
        {
            Console.WriteLine("Wow, you're stupid.");
        }
    }
}
