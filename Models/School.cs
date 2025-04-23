using System;
using System.Collections.Generic;
using System.Text;
using Examen_25._1_Promedio_1.Interfaces;

namespace Examen_25._1_Promedio_1.Models
{
    public class School : Building, IPublicService, IUpkeep
    {
        public School() : base("Escuela", 400, 0) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Escuela - Costo: {Cost}, Mantenimiento: {GetUpkeepCost()}");
        }

        public int GetUpkeepCost()
        {
            return 15;
        }
    }
}
