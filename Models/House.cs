using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_25._1_Promedio_1.Models
{
    public class House : Building
    {
        public House() : base("Casa", 150, 20) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Casa - Costo: {Cost}, Ingreso: {IncomePerTurn}");
        }
    }
}
