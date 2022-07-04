using System;

namespace FoodOderingApp.Enums
{
    public class Food
    {
        public int FoodId {get;set;}
        public string FoodTypeName {get;set;}
        public decimal Price {get;set;}

        public Food(int foodId,string foodTypeName, decimal price)
        {
            FoodId = foodId;
            FoodTypeName = foodTypeName;
            Price = price;
        }
    }
}