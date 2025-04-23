using System;
using System.Collections.Generic;
using System.Text;
using Examen_25._1_Promedio_1.Models;
using Examen_25._1_Promedio_1.Interfaces;

namespace Examen_25._1_Promedio_1
{
    public class Board
    {
        private Dictionary<string, Cell> cells;



        public Board(int width, int height)
        {
            cells = new Dictionary<string, Cell>();
            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    string id = $"{(char)('A' + row)}{col + 1}";
                    cells[id] = new Cell(id);
                }
            }
        }


        public bool PlaceBuilding(string id, Building building)
        {
            if (cells.ContainsKey(id) && !cells[id].IsOwned)
            {
                cells[id].IsOwned = true;
                cells[id].Building = building;
                return true;
            }
            return false;
        }


        public void ShowBoard()
        {
            Console.WriteLine("\n== Tablero de la Ciudad ==");
            for (int row = 0; row < 5; row++) 
            {
                for (int col = 0; col < 5; col++) 
                {
                    string id = $"{(char)('A' + row)}{col + 1}";
                    Console.Write($"{cells[id].Display()} ");
                }
                Console.WriteLine();
            }
        }


        public int GetTotalIncome()
        {
            int total = 0;
            foreach (var cell in cells.Values)
            {
                if (cell.Building != null)
                {
                    total += cell.Building.IncomePerTurn;
                }
            }
            return total;
        }

        
        public int GetTotalUpkeep()
        {
            int total = 0;
            foreach (var cell in cells.Values)
            {
                if (cell.Building is IUpkeep upkeep)
                {
                    total += upkeep.GetUpkeepCost();
                }
            }
            return total;
        }
    }
}