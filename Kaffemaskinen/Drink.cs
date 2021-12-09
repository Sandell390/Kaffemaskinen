using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public abstract class Drink
    {
        public abstract List<Ingredient> Ingredients { get; set; }

        public string TaskName { get; set; }

        public int Servings { get; set; }

        protected Drink(string taskName)
        {
            TaskName = taskName;
        }

        public virtual void FillIngredients()
        {
            //Fills the machine with ingredients
            for (int i = 0; i < Ingredients.Count; i++)
            {
                Ingredients[i].TotalAmount = Ingredients[i].AmountPrServing * Servings;
                Console.WriteLine($"Fylder {Ingredients[i].TotalAmount} {Ingredients[i].UnitType} {Ingredients[i].Name} på");
                Thread.Sleep(1000);
            }
        }

        public virtual void MakeDrink()
        {
            //Makes all servings
            for (int i = 0; i < Servings; i++)
            {
                //Removes ingredients amount
                for (int j = 0; j < Ingredients.Count; j++)
                {
                    Ingredients[j].TotalAmount -= Ingredients[j].AmountPrServing;
                }
                Console.WriteLine($"Har lavet {i + 1} kopper {TaskName} indtil videre");
                Thread.Sleep(1000);
            }
        }
    }
}
