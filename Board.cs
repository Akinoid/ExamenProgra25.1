using System;
using System.Collections.Generic;
using System.Text;
using Examen_25._1_Promedio_1.Models;
using Examen_25._1_Promedio_1.Interfaces;

namespace Examen_25._1_Promedio_1
{
    public class Board
    {
        private Dictionary<string, Building> buildings = new Dictionary<string, Building>();

        public bool PlaceBuilding(string id, Building building)
        {
            if (buildings.ContainsKey(id)) return false;
            buildings.Add(id, building);
            return true;
        }

        public void ShowBoard()
        {
            Console.WriteLine("\n== Edificios en el tablero ==");
            foreach (KeyValuePair<string, Building> pair in buildings)
            {
                Console.Write($"[{pair.Key}] ");
                pair.Value.DisplayInfo();
            }
        }

        public int GetTotalIncome()
        {
            int total = 0;
            foreach (Building building in buildings.Values)
            {
                total += building.IncomePerTurn;
            }
            return total;
        }

        public int GetTotalUpkeep()
        {
            int total = 0;
            foreach (Building building in buildings.Values)
            {
                if (building is IUpkeep upkeep)
                {
                    total += upkeep.GetUpkeepCost();
                }
            }
            return total;
        }

        public Building? GetBuildingAt(string id)
        {
            if (buildings.ContainsKey(id))
            {
                return buildings[id];
            }
            return null;
        }
    }
}
