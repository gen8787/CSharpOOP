using System;
using System.Collections.Generic;
namespace HungryNinja
{
    public class Ninja
    {
        private int calorieIntake;
        public List<Food> FoodHistory = new List<Food>();

// Constructor
// add a constructor that sets calorieIntake to 0 and creates a new, empty list of Food objects to FoodHistory
        public Ninja()
        {
            calorieIntake = 0;
            FoodHistory = new List<Food>();

        }

// add a public "getter" property called "IsFull"
        public bool IsFull
        {
            get
            {
                if (calorieIntake > 1200)
                {
                    return true;
                }
                return false;
            }
        }

// build out the Eat method
        public void Eat(Food item)
        {
            if (!IsFull)
            {
                FoodHistory.Add(item);
                calorieIntake += item.Calories;
                Console.WriteLine($"That {item.Name} was delicious.");
                Console.WriteLine($"I've eaten {calorieIntake} calories so far.\n");
            }
            else
            {
                Console.WriteLine("I'm full and don't want to eat anymore.");
            }
            
        }
    }   
}