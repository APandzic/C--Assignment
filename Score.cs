using System;
using System.Collections.Generic;

namespace snakeGame
{
    public class Score
    {
        private Frame F;

        private Worm W;
        
        public int score = 0;
        
        public bool gameover = false;
        
        public Score(Frame f, Worm w)
        {
            F = f;
            W = w;
        }
        
        public void InitScore()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(51,0);
            Console.Write("Score : 0");
        }
        
        public bool TargetTaken()
        {
            return W.worm_x == F.target_x && W.worm_y == F.target_y;
        }

        public void UpdateScore()
        {
            score++;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(59, 0);
            Console.Write(score);
        }
        
        public bool isGameover()
        {
            bool value = false;
            if (F.grid[W.worm_y][W.worm_x] != ' ')
            {
                value = true; 
            }

            return value; 
        }
        

    }
}