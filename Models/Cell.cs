using System;
using System.Collections.Generic;
using System.Text;

namespace Examen_25._1_Promedio_1.Models
{
    public class Cell
    {
        public string Id { get; set; }
        public bool IsOwned { get; set; }
        public Building? Building { get; set; }

        public Cell(string id)
        {
            Id = id;
            IsOwned = false;
            Building = null;
        }

        public bool IsEmpty()
        {
            return !IsOwned || Building == null;
        }

        public string Display()
        {
            if (!IsOwned)
                return $"[{Id}]"; 

            if (Building == null)
                return "[ ]"; 

            
            return $"[{GetBuildingSymbol()}]";
        }

        
        private string GetBuildingSymbol()
        {
            if (Building is House) return "H"; 
            if (Building is Factory) return "F"; 
            if (Building is Apartment) return "A"; 
            if (Building is School) return "S"; 
            return "?"; 
        }
    }

}
