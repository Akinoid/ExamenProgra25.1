using System;
using System.Collections.Generic;
using System.Text;
using Examen_25._1_Promedio_1.Interfaces;


namespace Examen_25._1_Promedio_1.Models
{
    public abstract class Building : IUpgradable
    {
        public string Name { get; set; }
        public int Cost { get; set; }
        public int IncomePerTurn { get; set; }

        public Building(string name, int cost, int income)
        {
            Name = name;
            Cost = cost;
            IncomePerTurn = income;
        }

        public abstract void DisplayInfo();

        public virtual void Upgrade()
        {
            IncomePerTurn += 10;
        }
    }
}
