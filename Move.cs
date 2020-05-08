using System;
using System.Collections.Generic;

namespace snakeGame
{
    public class Move
    {
        static direction current = direction.RIGHT;
        enum direction
        {
            UP = 1,
            DOWN = 2,
            LEFT = 3,
            RIGHT = 4
        };
        
        private Frame F;

        private Worm W;
        
        public Move(Frame f, Worm w)
        {
            F = f;
            W = w;
        }
        public void MoveWormHead()
        {
            F.grid[W.worm_y][W.worm_x] = 'O';

            switch (current)
            {
                case direction.UP :
                    W.worm_y--;
                    break;
                case direction.DOWN :
                    W.worm_y++;
                    break;
                case direction.LEFT :
                    W.worm_x--;
                    break;
                case direction.RIGHT :
                    W.worm_x++;
                    break;
            }
            W.worm.Add(new Position() {X = W.worm_x, Y = W.worm_y});
        }
        
        public void ReadKeys()
        {
            ConsoleKeyInfo s;
            
            if (Console.KeyAvailable)
            {
                s = Console.ReadKey();

                switch (s.Key)
                {
                    case ConsoleKey.UpArrow :
                        if (current != direction.DOWN)
                        {
                            current = direction.UP;

                        }
                        break;
                    
                    case ConsoleKey.DownArrow :
                        if (current != direction.UP)
                        {
                            current = direction.DOWN;

                        }
                        break;
                    
                    case ConsoleKey.LeftArrow :
                        if (current != direction.RIGHT)
                        {
                            current = direction.LEFT;

                        }
                        break;
                    
                    case ConsoleKey.RightArrow :
                        if (current != direction.LEFT)
                        {
                            current = direction.RIGHT;

                        }
                        break;
                    
                    default :
                        break;
                    
                }
            }
        }
    }
}