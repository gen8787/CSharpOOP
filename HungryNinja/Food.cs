using System;
using System.Collections.Generic;
namespace HungryNinja
{
    public class Food
    {
// Fields
        public string Name;
        public int Calories;
        public bool IsSpicy; 
        public bool IsSweet; 

// add a constructor that takes in all four parameters: Name, Calories, IsSpicy, IsSweet
// Constructor
        public Food(string name, int calories, bool isSpicy, bool isSweet)
        {
            Name = name;
            Calories = calories;
            IsSpicy = isSpicy;
            IsSweet = isSweet;
        }
    }
}
