using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public class Espresso : Drink
    {
        public override List<Ingredient> Ingredients { get; set; } = new() { new Ingredient("Water", 15, "ml"), new Ingredient("Espresso Beans", 1.5f, "g") };

        public Espresso() : base("Espresso")
        {

        }
    }
}
