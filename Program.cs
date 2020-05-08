using System;
using System.Collections.Generic;
using System.Data;

namespace snakeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            var frame = new Frame(50, 20);
            var worm = new Worm(frame);
            var speed = new Speed(100);
            var move = new Move(frame, worm);
            var score = new Score(frame, worm);

            frame.InitFrame();
            frame.DrawFrame();
            frame.SetTarget(); 
            worm.InitWorm();
            worm.DrawWorm();

            score.InitScore();

            while (!score.gameover)
            {
                worm.DrawWormHead();
                
                if (score.TargetTaken())
                {
                    frame.SetTarget();
                    score.UpdateScore();
                }

                speed.movmentSpeed();
                move.ReadKeys();
                worm.DrawWormBodyOnHeadPosition();
                move.MoveWormHead();
                
                if (score.isGameover())
                {
                    score.gameover = true; 
                }
                
                worm.IncreaseWormLenght();
                worm.DeleteWormTail(); 
            }
            
            Console.SetCursorPosition(0, 20);
            Console.WriteLine("Game over");
            
        }
    }
}