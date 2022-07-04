using System;

namespace FoodOderingApp.Enums
{
    public class Staff:Person
    {
        public string StaffNo {get;set;}
        public Role Role{get;set;}
        public Gender Gender {get;set;}
        public Staff(int id, string fName, string lName,string email,string password,string phone,Gender gender,Role role):base(id,fName,lName,email,password,phone)
        {
           StaffNo =  $"ST{Guid.NewGuid().ToString().Replace("_", "").Substring(0,5).ToUpper()} ";
           Role = role;
        }
    }
}