using System;
using System.Collections.Generic;
using System.Text;
using Examen_25._1_Promedio_1.Interfaces;

namespace Examen_25._1_Promedio_1.Models
{
    public class Factory : Building, IIndustrial, IUpkeep
    {
        public Factory() : base("Fábrica", 300, 50) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Fábrica - Costo: {Cost}, Ingreso: {IncomePerTurn}, Mantenimiento: {GetUpkeepCost()}");
        }

        public int GetUpkeepCost()
        {
            return 10;
        }
    }
}
