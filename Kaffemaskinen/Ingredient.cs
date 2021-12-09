using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public class Ingredient
    {
        public string Name { get; }

        public string UnitType { get; }

        public float TotalAmount { get; set; }

        public float AmountPrServing { get; }

        public Ingredient(string name, float amountPrServing, string unitType)
        {
            AmountPrServing = amountPrServing;
            Name = name;
            UnitType = unitType;
        }

    }
}
