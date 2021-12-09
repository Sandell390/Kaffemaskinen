using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public class Coffee : Drink
    {
        public override List<Ingredient> Ingredients { get; set; } = new (){new Ingredient("Water", 15, "ml"), new Ingredient("Coffee Beans", 1.5f,"g")};

        public Filter filter;

        public Coffee() : base("Coffee")
        {

        }

        public void InsertNewFilter()
        {
            filter = new Filter();
            Console.WriteLine("Indsætter nyt filter");
        }

        public override void FillIngredients()
        {
            base.FillIngredients();
            InsertNewFilter();
        }

        public override void MakeDrink()
        {
            base.MakeDrink();
            filter.TimeUsed++;
        }
    }
}
