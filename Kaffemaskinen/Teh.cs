using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    class Teh : Drink
    {
        public override List<Ingredient> Ingredients { get; set; } = new() { new Ingredient("Water", 25, "ml"), new Ingredient("Teh bag", 1, "") };

        public Teh() : base("Teh")
        {

        }
    }
}
