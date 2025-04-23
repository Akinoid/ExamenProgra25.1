using System;
using System.Collections.Generic;
using System.Text;
using Examen_25._1_Promedio_1.Interfaces;

namespace Examen_25._1_Promedio_1.Models
{
    public class Apartment : Building, IResidential
    {
        public Apartment() : base("Departamento", 250, 35) { }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Departamento - Costo: {Cost}, Ingreso: {IncomePerTurn}");
        }
    }
}
