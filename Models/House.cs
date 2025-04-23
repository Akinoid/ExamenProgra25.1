using System;
using System.Collections.Generic;
using System.Text;
using Examen_25._1_Promedio_1.Interfaces;

namespace Examen_25._1_Promedio_1.Models
{
    public class House : Building, IResidential
    {
        public House() : base("Casa", 100, 20) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Casa - Costo: {Cost}, Ingreso: {IncomePerTurn}");
        }
    }
}
