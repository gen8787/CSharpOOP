using System;
using System.Collections.Generic;

namespace HungryNinja
{
    class Buffet
    {
        public List<Food> Menu;
        
//Constructor
        public Buffet()
        {
            Menu = new List<Food>()
            {

            };
        }
// build out a Serve method that randomly selects a Food object from the Menu list and returns the Food object
        public Food Serve()
        {
            Random rando = new Random();
            int i = rando.Next(Menu.Count);
            return Menu[i];
        }
    }
}