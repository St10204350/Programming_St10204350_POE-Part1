POE_Part1
If you want to run and compile my program Firstly you need to unzip my folder, after unzipping the folder. Open your Microsoft Visual Studio IDE and select File on visual studio taskbar and click Open and select my unzip file of my program

And Press F5, choose Debug > Start with debugging from visual Studio Menu, or select the green Start arrow and project name "e.g. Part1" on the visual studio toolbar

The code using Part1; using System; using System.Numerics; using System.Reflection.Metadata.Ecma335;

namespace Part1 { class Application { private string[] ingredients; private double[] quantities; private string[] units; private string[] steps;

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

        if (numIngredients > 0) //if numIngredients is less than or equal to zero the program will stop
        {
            // Initialize the below arrays with the correct size
            ingredients = new string[numIngredients];
            quantities = new double[numIngredients];
            units = new string[numIngredients];

            int count = 1;

            // Prompt the user to enter the details for each ingredient
            for (int a = 0; a < numIngredients; a++)
            {
                Console.WriteLine($"Enter details for ingredient #{a + 1}:");

                Boolean w = true;

                Console.Write("Ingredient name: ");
                ingredients[a] = Console.ReadLine();

                try
                {
                    Console.Write("Ingredient quantity: ");
                    quantities[a] = double.Parse(Console.ReadLine());

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input. Please try again");
                    Console.Write("Ingredient quantity: ");
                }

                ///Prompt the user to choose from the below units values
                Console.WriteLine("Select the units of measurements (mg),(g),(kg),(ml),(l),(tablespoon),(teaspoon),(cups)");
                units[a] = Console.ReadLine();
                Boolean ingredientUnits = true;

                while (ingredientUnits)//loop that make ensure you inputted correct units 
                {
                    if (units[a].Equals("mg"))
                    {
                        break;
                    }
                    else if (units[a].Equals("g"))
                    {
                        break;
                    }
                    else if (units[a].Equals("kg"))
                    {
                        break;
                    }
                    else if (units[a].Equals("ml"))
                    {
                        break;
                    }
                    else if (units[a].Equals("l"))
                    {
                        break;
                    }
                    else if (units[a].Equals("tablespoon"))
                    {
                        break;
                    }
                    else if (units[a].Equals("teaspoon"))
                    {
                        break;
                    }
                    else if (units[a].Equals("cups"))
                    {
                        break;
                    }

                    else
                    {
                        Console.WriteLine("Incorrect units of measurement. Please try again");
                        Console.WriteLine("Select the units of measurements (mg),(g),(kg),(ml),(l),(teaspoon),(cups)");
                        units[a] = Console.ReadLine();
                    }


                }
                count++;

                // Prompt the user to enter the number of steps
                Console.Write("Enter the number of steps: ");
                int numSteps = int.Parse(Console.ReadLine());

                // Initialize the steps array with the correct size
                steps = new string[numSteps];

                // Prompt the user to enter the details for each step
                for (int b = 0; b < numSteps; b++)
                {

                    Console.Write($"Enter step #{b + 1}: ");
                    steps[b] = Console.ReadLine();
                }
            }


        }
        else
        {
            Console.WriteLine("Incorrect input");
        }

    }

    public void DisplayResults()
    {
        if (ingredients.Length > 0)
        {
            Console.WriteLine("Recipe name: " + recipeName);
        }
        else { Console.WriteLine("There's no recipe saved "); }


        // Display the ingredients and quantities results
        Console.WriteLine("Ingredients: ");
        for (int a = 0; a < ingredients.Length; a++)
        {
            Console.WriteLine($"- {quantities[a]} {units[a]} of {ingredients[a]}");
        }

        // Display the steps results
        Console.WriteLine("Steps: ");
        for (int b = 0; b < steps.Length; b++)
        {
            Console.WriteLine($"Step {b + 1}  {steps[b]}");
        }
    }

    public void ScaleRecipe()
    {
        n = int.Parse(Console.ReadLine());
        switch (n)
        {
            case 1:
                n = 0.5;
                for (int i = 0; i < quantities.Length; i++)
                {
                    quantities[i] *= n;
                }
                break;
            case 2:
                n = 2;
                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] == 16 || units[i].Equals("tablespoon"))
                    {
                        quantities[i] = 1;
                        units[i] = "cups";
                    }
                    else
                    {
                        quantities[i] *= n;
                    }
                }
                break;
            case 3:
                n = 3;
                for (int i = 0; i < quantities.Length; i++)
                {
                    if (quantities[i] == 3 || units[i].Equals("teaspoon"))
                    {
                        quantities[i] = 1;
                        units[i] = "tablespoon";
                    }
                    else
                    {
                        quantities[i] *= n;
                    }
                }
                break;
        }
    }

    public void ResetQuantities()
    {
        // Reset all the quantities to their original values
        for (int i = 0; i < quantities.Length; i++)
        {
            if (quantities[i] == 1 && units[i].Equals("cups"))
            {
                quantities[i] += 7;
                units[i] = "tablespoon";
            }
            else if (quantities[i] == 1 && units[i].Equals("tablespoon"))
            {
                quantities[i] += 2;
                units[i] = "teaspoon";
            }
            else if (n == 1)
            {
                quantities[i] /= 0.5;
            }
            else
            {
                quantities[i] /= n;
            }

        }

    }

    public void ClearRecipe()
    {
        //Prompt to choose from the below option provided
        Console.WriteLine("Would you like to clear the data: Yes or No");
        string clear = Console.ReadLine();
        if (clear == "Yes")
        {
            // Reset all the arrays to empty
            ingredients = new string[0];
            quantities = new double[0];
            units = new string[0];
            steps = new string[0];
        }
        else
        {
            Console.WriteLine("Thank you!!!");
        }

    }
}
}

class Program { static void Main(string[] args) { Application recipe = new Application();

    // Set the Foreground color to Red
    Console.ForegroundColor = ConsoleColor.Red;

    //Set the background color to DarkBlue
    Console.BackgroundColor = ConsoleColor.DarkBlue;
    Console.Clear();

    Console.WriteLine("*******Welcome to Destoyer's Application*******");

    while (true)
    {
        Console.WriteLine("1. Recipe details");
        Console.WriteLine("2. Display recipe");
        Console.WriteLine("3. Scale recipe");
        Console.WriteLine("4. Reset quantities");
        Console.WriteLine("5. Clear recipe");
        Console.WriteLine("6. Exit");

        string option = Console.ReadLine();

        switch (option)
        {
            case "1":
                //display the RecipeDetails method
                recipe.RecipeDetails();
                break;
            case "2":
                //display the DisplayResults method
                recipe.DisplayResults();
                break;
            case "3":
                //Prompt the to enter the factor to scale
                Console.WriteLine("Select the factor you want to be scaled : \n1. 0.5(half) \n2. 2(double) \n3. 3(triple)");
                recipe.ScaleRecipe();
                break;
            case "4":
                //display the ResetQuantities method
                recipe.ResetQuantities();
                break;
            case "5":
                //display the ClearRecipe method
                recipe.ClearRecipe();
                break;
            case "6":
                //Stop the application
                Console.WriteLine("Thank you for using the application...");
                return;
            default:
                //display the below message if the user inputted incorrect option
                Console.WriteLine("Invalid choice. Please enter a valid option.");
                break;
        }

    }
}
}
