using System;

namespace Human
{
    class Human
{
// Fields for Human
    public string Name;
    public int Strength;
    public int Intelligence;
    public int Dexterity;
    private int Health;

// Properties for Human
// add a public "getter" property to access health
    public string getHealth
    {
        get{
            string getHealth = Name + "'s health is "+ Health + ".\n";
            return getHealth;
        }
    }

// Constructor for Human
// Add a constructor that takes a value to set Name, and set the remaining fields to default values
    // public Human(string name)
    // {
    //     Name = name;
    //     Strength = 3;
    //     Intelligence = 3;
    //     Dexterity = 3;
    //     health = 100;
    // }
// Add a constructor to assign custom values to all fields
    public Human(string name, int strength, int intelligence, int dexterity, int health)
    {
        Name = name;
        Strength = strength;
        Intelligence = intelligence;
        Dexterity = dexterity;
        Health = health;
    }

// Build Attack method
        public void Attack(Human target)
    {
        Random rando = new Random();
        int actDamage = (Strength / 2) * (int)rando.Next(1, 5);
        target.Health -= actDamage;
        Console.WriteLine("Attack!!");
        Console.WriteLine($"{Name} attacked {target.Name} for {actDamage} damage!");
        Console.WriteLine($"{target.Name}'s health is now {target.Health}.\n");
        // return Health;
    }
}
}