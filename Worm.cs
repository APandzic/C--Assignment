using System;
using System.Collections.Generic;

namespace snakeGame
{
    public class Worm
    { 
        
        Frame F;
        
        public List<Position> worm = new List<Position>();
        
        public int wormlength = 5;
        
        public int worm_x = 25;
        
        public int worm_y = 9;
        
        public int lengthtimer = 0;
        
        public int lengthtime = 8;

        public Worm(Frame f)
        {
            F = f;
        }
        
        public void InitWorm()
        {
            worm.Add(new Position() {X = 21, Y = 9});
            worm.Add(new Position() {X = 22, Y = 9});
            worm.Add(new Position() {X = 23, Y = 9});
            worm.Add(new Position() {X = 24, Y = 9});
            worm.Add(new Position() {X = 25, Y = 9});

            foreach (Position pos in worm)
            {
                F.grid[pos.Y][pos.X] = 'o';
            }
        }
        
        public void DrawWorm()
        {
            int count = 0;

            Console.ForegroundColor = ConsoleColor.Blue;

            foreach (Position wormpart in worm)
            {
                Console.SetCursorPosition(wormpart.X, wormpart.Y);
                count++;
                if (count < 5)
                {
                    Console.Write('O');
                }
                else
                {
                    Console.Write('Ö');
                }
            }
        }
        
        public void IncreaseWormLenght()
        {
            lengthtimer++;

            if (lengthtimer == lengthtime)
            {
                lengthtimer = 0;
                wormlength++;
            }
        }
        
        public void DrawWormBodyOnHeadPosition()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(worm_x, worm_y);
            Console.Write('O');
        }

        public void DrawWormHead()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.SetCursorPosition(worm_x, worm_y);
            Console.Write('Ö');
        }
        
        public void DeleteWormTail()
        {
            Console.SetCursorPosition(worm[0].X, worm[0].Y);
            Console.Write(' ');
            if (worm.Count != wormlength)
            {
                F.grid[worm[0].Y][worm[0].X] = ' ';
                worm.RemoveAt(0);
            }
        }
        
    }
}