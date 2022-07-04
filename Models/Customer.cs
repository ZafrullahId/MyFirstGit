using System;

namespace FoodOderingApp.Enums
{
   public class Customer:Person
    {
         public decimal Wallet {get;set;}
         public string CustomerNo {get;set;}
         public string Address {get;set;}
        public Customer(int id, string fName,string lName, string email,string password,string phone,string adress):base (id,fName,lName,email,password,phone)
       {
         CustomerNo =  $"CU{Guid.NewGuid().ToString().Replace("_", "").Substring(0,5).ToUpper()} ";
         Wallet = 0.00m;
         Address = adress;
       }
       public Customer()
       {
         
       }
    }
}