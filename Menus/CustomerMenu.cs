using System;

namespace FoodOderingApp.Enums
{
     public class CustomerMenu
    {
       FoodRepo foodRepo = new FoodRepo();
       OrderRepo orderRepo = new OrderRepo();
       public CustmerRepo custmerRepo = new CustmerRepo();
       public void CustomerOptionMenu()
      {
        System.Console.WriteLine("Enter 1 to Login\nEnter 2 to Register\nEnter 0 to back to Main Menu");
        int option;
        while(!int.TryParse(Console.ReadLine(),out option))
        {
          System.Console.WriteLine("Invalid input. Try again");
        }
        switch(option)
        {
          case 1:
          Login();
          break;
          case 2:
          Register();
          break;
          case 0:
          MainMenu.WelcomePage();
          break;
          default:
          Console.WriteLine("Invalid input");
          CustomerOptionMenu();
          return;
        }
      }
      public void Login()
      {
         System.Console.WriteLine("Enter Email: ");
         string email = Console.ReadLine();
         System.Console.WriteLine("Enter Password: ");
         string password = Console.ReadLine();
         var customer = custmerRepo.Login(email,password);
         
         if (customer == null)
         {
           Console.WriteLine("This account was not found. please register an account. Enter any key to register");
           Console.ReadKey();
           Register();
         }
         else
         {
           System.Console.WriteLine("Log-in successfuly...");
            AfterCustomerLogin(customer);
         }
      }
         public void AfterCustomerLogin(Customer customer)
         {
         Console.WriteLine("1. To check available foods\n2. To order for food\n3. To check Wallet\n0 To Main Menu");
         int option;
         while(!int.TryParse(Console.ReadLine(),out option))
         {
           Console.WriteLine("Invalid input. Try again");
         }
         switch(option)
         {
           case 1:
          foodRepo.PrintAllReadyFood();
          break;
          case 2:
          orderRepo.OrderFood(customer);
          break;
          case 3:
          custmerRepo.CheckWallet(customer);
          break;
          case 0:
          MainMenu.WelcomePage();
          break;
          default:
           Console.WriteLine("Invalid Input. Try again");
           CustomerContinueMenu();
          return;
         
         }
      }
        public void Register()
       {
          System.Console.WriteLine("Enter first name");
          string fName = Console.ReadLine();
          System.Console.WriteLine("Enter Last name");
          string lName= Console.ReadLine();
          System.Console.WriteLine("Enter your Email");
          string email = Console.ReadLine();
          System.Console.WriteLine("Enter your phone number");
          string phone = Console.ReadLine();
          System.Console.WriteLine("Enter password");
          string password = Console.ReadLine();
          System.Console.WriteLine("Enter your address");
          string address = Console.ReadLine();
          custmerRepo.Register(fName,lName,email,password,phone,address);
          var customer = custmerRepo.Login(email,password);
        AfterCustomerLogin(customer);
      }
       public void CustomerContinueMenu()
       {
         Console.WriteLine("1. To check available foods\n0 To Main Menu");
         int option;
         while(!int.TryParse(Console.ReadLine(),out option))
         {
           Console.WriteLine("Invalid input. Try again");
         }
         switch(option)
         {
           case 1:
          foodRepo.PrintAllReadyFood();
          break;
          case 0:
          MainMenu.WelcomePage();
          break;
          default:
          CustomerContinueMenu();
          return;
         }
       }
    }
}