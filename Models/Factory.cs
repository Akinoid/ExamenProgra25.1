using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_25._1_Promedio_1.Models
{
    public class Factory : Building
    {
        public Factory() : base("Fábrica", 300, 50) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Fabrica - Costo: {Cost}, Ingreso: {IncomePerTurn}");
        }
    }
}
