using System;
namespace HungryNinja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet eet = new Buffet();
            Ninja ninja = new Ninja();

            eet.Menu.Add(new Food("Donut", 250, false, true));
            eet.Menu.Add(new Food("Salad", 150, false, false));
            eet.Menu.Add(new Food("Korean BBQ", 300, true, false));
            eet.Menu.Add(new Food("French Fries", 200, false, false));
            eet.Menu.Add(new Food("Eggs", 100, false, false));
            eet.Menu.Add(new Food("Ice Cream", 300, false, true));
            eet.Menu.Add(new Food("Sweet & Spicy Chx", 275, true, true));

            ninja.Eat(eet.Serve());
            ninja.Eat(eet.Serve());
            ninja.Eat(eet.Serve());
            ninja.Eat(eet.Serve());
            ninja.Eat(eet.Serve());
            ninja.Eat(eet.Serve());
            ninja.Eat(eet.Serve());
            ninja.Eat(eet.Serve());
        }
    }
}