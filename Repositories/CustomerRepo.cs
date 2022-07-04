using System;

namespace FoodOderingApp.Enums
{
    public class CustmerRepo
    {
       
         public static int myIndex = 0;
        private static int count = 1;
        // public Customer customer = new Customer();
        public Customer [] customers = new Customer[50];
        public OrderRepo orderRepo = new OrderRepo();
        public void Register(string fName, string lName, string email,string password, string phone,string adress)
         {
          var customer = new Customer(count,fName,lName,email,password,phone,adress);
          customers[myIndex] = customer;
           System.Console.WriteLine($"You have successfully created an account and your customer number is {customer.CustomerNo}");
           System.Console.WriteLine($"We have given you a bonus of {customer.Wallet} but don't forget you cannot spend it.");
           myIndex++;
           count++;
         }
         
         public Customer Login(string email, string password)
        {
           var  customer = GetCustomer(email);
           if (customer != null && customer.Password == password)
           {
               return customer;
           }
           return null;
        }
         private Customer GetCustomer(string email)
       {
           for (int i = 0; i < myIndex; i++)
           {
               if (customers[i] != null && customers [i].Email == email)
               {
                   return customers[i];
               } 
           }
           return null;
        }
        public void CheckWallet(Customer customer)
        {
           
            Console.WriteLine("Your wallet balance is " + "#" + customer.Wallet + ".00");
            Console.WriteLine("Would you like to fund your wallet\n1. To fund wallet  2. To order food  0. To Main Main");
            int option;
            while(!int.TryParse(Console.ReadLine(),out option))
            {
                Console.WriteLine("Invalid option. Try again");
            }
            switch(option)
            {
                case 1:
                orderRepo.FundWalletWithoutOrder(customer);
                break;
                case 2:
                orderRepo.OrderFood(customer);
                break;
                case 0:
                MainMenu.WelcomePage();
                break;
                default:
                CheckWallet(customer);
                break;
            }
        }
         public void AfterFundWallet(Customer customer)
        {
           Console.WriteLine("1. To Order food\n0. To Main Menu");
           int option;
           while(!int.TryParse(Console.ReadLine(),out option))
           {
               Console.WriteLine("Invalid Input. Try again");
           }
           switch(option)
           {
               case 1:
               orderRepo.OrderFood(customer);
               break;
               case 0:
               MainMenu.WelcomePage();
               break;
               default:
               AfterFundWallet(customer);
               return;
           }
          
        }
        
         
    }
    
}