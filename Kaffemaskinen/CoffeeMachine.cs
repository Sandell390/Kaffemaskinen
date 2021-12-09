using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Kaffemaskinen
{
    public class CoffeeMachine
    {
        public bool Power { get; set; }

        public Drink CurrentDrink { get; set; }

        public CoffeeMachine()
        {
        }

        public void TogglePower()
        {
            //Toggles the power on or off
            if (Power)
            {
                Console.WriteLine("Slukker for kaffemaskinen");
                Power = false;
            }
            else
            {
                Console.WriteLine("Tænder for kaffemaskinen");
                Power = true;
            }
        }
        public void FillIngredientInMachine()
        {
            CurrentDrink.FillIngredients();
        }

        public void StartMachine()
        {
            //Start the process of making drinks
            TogglePower();

            CurrentDrink.MakeDrink();

            TogglePower();
        }
    }
}
