using System;

namespace FoodOderingApp
{
    public class Cart
    {
         public int Id {get;set;}
         public string FoodId {get;set;}
         public string Price {get;set;}
         public int Quantity {get;set;}
         public Cart(int id, string foodId,string price, int quantity)
         {
              Id = id;
              FoodId = foodId;
              Price = price;
              Quantity = quantity;
         }
    }
}