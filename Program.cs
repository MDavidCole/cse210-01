// Author: M. David Cole
// Assignment: Tic-Tac-Toe game.

using System;

namespace tictactoe
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize variables
            int turn = 0;
            string[] grid = {"1", "2", "3", "4", "5", "6", "7", "8", "9"};
            
            while (still_playing(grid, turn) == true)
            {
                display_grid(grid);
                get_input(turn, grid);
                if (check_win(grid) == true)
                {
                    Console.WriteLine("Good game. Thanks for playing!");
                    display_grid(grid);
                }
                turn++;
                if (turn >= 9)
                {Console.Write("Its a draw. Thanks for playing!");}
            }
        }
        static bool still_playing(string[] grid, int turn)
        {
            if (turn >= 9 || check_win(grid) == true)
            {return false;}
            return true;
        }
        static bool check_win(string[] grid)
        {
            if (
                (grid[0] == grid[1] && grid[1] == grid[2]) ||
                (grid[3] == grid[4] && grid[4] == grid[5]) ||
                (grid[6] == grid[7] && grid[7] == grid[8]) ||
                (grid[0] == grid[3] && grid[3] == grid[6]) ||
                (grid[1] == grid[4] && grid[4] == grid[7]) ||
                (grid[2] == grid[5] && grid[5] == grid[8]) ||
                (grid[0] == grid[4] && grid[4] == grid[8]) ||
                (grid[2] == grid[4] && grid[4] == grid[6])
            )
            {return true;}

            return false;
        }
        static void display_grid(string[] grid)
        {
            Console.WriteLine($" {grid[0]} | {grid[1]} | {grid[2]}");
            Console.WriteLine("--+--+--");
            Console.WriteLine($" {grid[3]} | {grid[4]} | {grid[5]}");
            Console.WriteLine("--+--+--");
            Console.WriteLine($" {grid[6]} | {grid[7]} | {grid[8]}");
        }
        static void get_input(int turn, string[] grid)
        {
            if (turn % 2 != 0)
            {
                string player = "X";
                Console.WriteLine($"{player}'s turn to choose a square (1-9): ");
                string string_choice = Console.ReadLine();
                int choice = int.Parse(string_choice);
                grid[choice - 1] = player;
            }
            else
            {
                string player = "O";
                Console.WriteLine($"{player}'s turn to choose a square (1-9): ");
                string string_choice = Console.ReadLine();
                int choice = int.Parse(string_choice);
                grid[choice - 1] = player;
            }  
        }

    }
}