// Title: BS_Student.cs
// Author Name: Samrat Jayanta Bhurtel
// Student ID: 100949545
// Starting Date: 2024/11/05
// Description: This is the student's file to implement the Battleship game logic.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public static partial class BS
    {
        public static object grid { get; private set; }

        // Methods to clear grid
        public static void GridClear()
        {
            for (int i = 1; i <=MAX_BOARD_SIZE; i++)
            {
                for (int j = 1; j <= MAX_BOARD_SIZE; j++)
                {
                    board[i, j] = BoardStatus.Empty;
                    boatPositions[i, j] = Boats.NoBoat;
                }
            }
            
        }
        // Check if the boats sunk
        /// <summary>
        /// The boat to check if sunk<param name="boat">Name</param>
        /// </summary>
        /// <returns></returns>
        private static bool CheckBoatsSunken(Boats boat)
        {
            
            for (int i = 1; i <=MAX_BOARD_SIZE; i++)
            {
                for(int j = 1; j <= MAX_BOARD_SIZE; j++)
                {
                    if (boatPositions[i, j] == boat && board[i, j] != BoardStatus.Hit)
                    {
                        return false;
                    }
                  
                }
            }
            return true;

           
        }
        // Check if the Missile hit the boat or miss.
        public static bool MissileHit(int i, int j)
        {
            if (boatPositions[i, j] != Boats.NoBoat)
            {
                board[i, j] = BoardStatus.Hit;
                CheckBoatsSunken(boatPositions[i, j]);
                return true;
            }
            else
            {
                board[i, j] = BoardStatus.Miss;
                return false;
            }
        }
        // Check if the Game is over
        public static bool GameOver()
        {
            for (int i = 1; i <= MAX_BOARD_SIZE; i++)
            {
                for (int j = 0; j <MAX_BOARD_SIZE; j++)
                {
                    if (boatPositions[i, j] != Boats.NoBoat && board[i,j] != BoardStatus.Hit)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        // Check if the boat is still alive
        public static Dictionary<Boats, bool> BoatsAlive()
        {
            Dictionary<Boats, bool> boatsAlive = new Dictionary<Boats, bool>();
            boatsAlive.Add(Boats.Carrier, CheckBoatsSunken(Boats.Carrier));
            boatsAlive.Add(Boats.Battleship, CheckBoatsSunken(Boats.Battleship));
            boatsAlive.Add(Boats.Cruiser, CheckBoatsSunken(Boats.Cruiser));
            boatsAlive.Add(Boats.Submarine, CheckBoatsSunken(Boats.Submarine));
            boatsAlive.Add(Boats.Destroyer, CheckBoatsSunken(Boats.Destroyer));
            return boatsAlive;
        }
    }
}
