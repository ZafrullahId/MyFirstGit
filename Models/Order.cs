using System;

namespace FoodOderingApp.Enums
{
    public class Order
    {
        public int Id {get;set;}
        public string CustomerNo {get;set;}
        public TimeOnly OrderedTime {get;set;}
        public TimeOnly ReadyTime {get;set;}
        public Status Status {get;set;}
        

        public Order(int id,string customerNo,TimeOnly orderedTime, TimeOnly readyTime)
        {
            Id = id;
            CustomerNo = customerNo;
            OrderedTime = orderedTime;
            ReadyTime = readyTime;
            Status = Enums.Status.Default;
        }
    }
}