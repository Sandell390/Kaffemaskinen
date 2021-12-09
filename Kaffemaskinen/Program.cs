using System;
using System.Collections.Generic;

namespace Kaffemaskinen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Velkommen til kafffemaskinen");

            CoffeeMachine coffeeMachine = new CoffeeMachine();
            
            //User choose want they want to have
            coffeeMachine.CurrentDrink = ChooseTask();

            Console.WriteLine("");
            Console.WriteLine("Hvor mange kopper vil du lave?");

            //User choose many many servings they want
            int choice = UserStringToInt();
            coffeeMachine.CurrentDrink.Servings = choice;

            //Fills the machine with ingredients
            coffeeMachine.FillIngredientInMachine();

            //Starts the machine
            coffeeMachine.StartMachine();

            Console.ReadLine();

        }

        static Drink ChooseTask()
        {
            Console.WriteLine("Hvad vil du gerne have: ");
            Console.WriteLine("1. Coffee");
            Console.WriteLine("2. Te");
            Console.WriteLine("3. Esspresso");

            int choice = UserStringToInt();
            switch (choice)
            {
                case 1:
                    return new Coffee();
                case 2:
                    return new Teh();
                case 3:
                    return new Espresso();
            }

            return new Coffee();
        }

        static int UserStringToInt()
        {
            int res;
            string userString = Console.ReadLine();
            while (!int.TryParse(userString, out res))
            {
                Console.WriteLine("Du skrev ikke et gyldigt tal, prøv igen");
                userString = Console.ReadLine();

            }
            return res;
        }
    }
}
