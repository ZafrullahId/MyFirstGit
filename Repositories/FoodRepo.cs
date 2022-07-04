using System;

namespace FoodOderingApp.Enums
{
    class FoodRepo
    {
        
        
        public static int myIndex = 0;
        private static int count = 1;
        public static Food[] foods = new Food[50];
         public void PrintAllReadyFood()
        {
            
            for (int i = 0; i < foods.Length; i++)
            {
                if (foods[i] != null)
                {
                     Console.Write(foods[i].FoodId + "." + " ");
                     Console.Write(foods[i].FoodTypeName + " ");
                     Console.Write(foods[i].Price + " per plate");
                     Console.WriteLine();
                }
            }
            Console.WriteLine("Enter 0 to main menu");
            int option;
            while(!int.TryParse(Console.ReadLine(),out option))
            {
                Console.WriteLine("Invalid input");
            }    
            switch(option)
            {
                case 0:
                MainMenu.WelcomePage();
                break;
                default:
                PrintAllReadyFood();
                break;
            }
        }
         public void AddFood()
        {
            Console.WriteLine("Enter food name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter food price per plate");
            decimal price;
            while(!decimal.TryParse(Console.ReadLine(),out price))
            {
                Console.WriteLine("invalid price input. Try again.");
            }
            var food = new Food(count,name, price);
            foods[myIndex] = food;
            Console.WriteLine("Food type successfuly addad to list...");
            count++;
            myIndex++;
            AddAnotherFood();
        }
           public void AddAnotherFood()
           {
            Console.WriteLine("Would you like to add another food.\n1 for yes and 2 for no 0. To Main Menu");
            int option;
            while(!int.TryParse(Console.ReadLine(),out option))
            {
                Console.WriteLine("Try again");
            }
            switch(option)
            {
                case 1:
                AddFood();
                break;
                case 2:
                AfterPrintAllReadyFood();
                break;
                case 0:
                MainMenu.WelcomePage();
                break;
                default:
                AddAnotherFood();
                return;
            }
        }
        public void AfterPrintAllReadyFood()
        {
             Console.WriteLine("This are the foods available");
            for (int i = 0; i < foods.Length; i++)
            {
                if (foods[i] != null)
                {
                     Console.Write(foods[i].FoodId + "." + " ");
                     Console.Write(foods[i].FoodTypeName + " ");
                     Console.Write(foods[i].Price + " per spoon");
                     Console.WriteLine();
                }
            }
            Console.WriteLine("Enter 0 To logout");
            int option;
            while(!int.TryParse(Console.ReadLine(),out option))
            {
                Console.WriteLine("Invalid input. Try again");
            }
            switch(option)
            {
                case 0:
                MainMenu.WelcomePage();
                break;
                default:
                AfterPrintAllReadyFood();
                break;
            }
        }
         public void PrintOnlyReadyFood()
         {
            for (int i = 0; i < foods.Length; i++)
            {
                if (foods[i] != null)
                {
                     Console.Write(foods[i].FoodId + "." + " ");
                     Console.Write(foods[i].FoodTypeName + " ");
                     Console.Write(foods[i].Price + " per spoon");
                     Console.WriteLine();
                }
                 else if(foods[0] == null)
                {
                    Console.WriteLine("No food available.Enter any key back to Main Menu");
                    Console.ReadKey();
                    MainMenu.WelcomePage();
                }
            }
         }
        public Food GetFoodType(int id)
        {
            for (int i = 0; i < myIndex; i++)
            {
                if(foods[i] != null && foods[i].FoodId == id)
                return foods[i];
            }
            return null;
        }
        
    }
}