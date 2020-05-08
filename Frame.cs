using System;
using System.Collections.Generic;

namespace snakeGame
{
    public class Frame
    {
        public char [][] grid = new char[20][];
        
        public int target_x;
        
        public int target_y;
        
        public int Width { get; set; }
        public int Height { get; set; }
        
        public Frame(int width, int height)
        {
            Width = width;
            Height = height; 
        }
        
        public void InitFrame()
        {
            Console.CursorVisible = false;

            for (int i = 0; i < Height; i++)
            {
                grid[i] = new char[Width];
            }
                
            for (int i = 0; i < Height - 1; i++)
            {
                grid[i][0] = '#';
                grid[i][Width -  1] = '#';
            }
            for (int i = 1; i < Width - 1; i++)
            {
                grid[0][i] = '#';
                grid[Height - 1][i] = '#';
            }
            for (int y = 1; y < Height - 1; y++)
            {
                for (int x = 1; x < Width - 1; x++)
                {
                    grid[y][x] = ' '; 
                }
            }
        }

        public void DrawFrame()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();

            for (int y = 0; y < Height; y++)
            {
                for (int x = 0; x < Width; x++)
                {
                    Console.SetCursorPosition(x,y);
                    Console.Write(grid[y][x].ToString());
                }
            }
        }
        
        public void SetTarget()
        {
            Random rnd = new Random();
            int x = 0;
            int y = 0;
                

            while (grid[y][x] != ' ')
            {
                x = rnd.Next(1, Width - 1);
                y = rnd.Next(1, Height - 1);
            }

            target_x = x;
            target_y = y;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.Write("X");
        }
    }
}