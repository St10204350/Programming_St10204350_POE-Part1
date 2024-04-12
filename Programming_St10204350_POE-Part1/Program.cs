using Part1;
using System;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;

namespace Part1
{
    class Application
    {
        private string[] ingredients;
        private double[] quantities;
        private string[] units;
        private string[] steps;

        String recipeName;
        double n;
        public Application()
        {
            // Initialize empty arrays for ingredients, quantities, units, and steps
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
        }
        public void RecipeDetails()
        {
            //Prompt the user to enter the recipe name
            Console.Write($"Enter the name of recipe: ");
            recipeName = Console.ReadLine();

            //Prompt the user to enter the number of ingredients he will need
            Console.Write("Enter the number of ingredients: ");
            int numIngredients = int.Parse(Console.ReadLine());

        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Application recipe = new Application();

        // Set the Foreground color to Red
        Console.ForegroundColor = ConsoleColor.Red;

        //Set the background color to DarkBlue
        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.Clear();

        Console.WriteLine("*******Welcome to Destoyer's Application*******");

        while (true)
        {
            Console.WriteLine("1. Recipe details");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    //display the RecipeDetails method
                    recipe.RecipeDetails();
                    break;
                default:
                    //display the below message if the user inputted incorrect option
                    Console.WriteLine("Invalid choice. Please enter a valid option.");
                    break;
            }

        }
    }
}