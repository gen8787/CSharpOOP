using System;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human me = new Human("Gary", 10, 7, 6, 500);
            Human you = new Human("You", 5, 10, 3, 500);
            
            me.Attack(you);
            me.Attack(you);
            me.Attack(you);

            // you.Attack(me);
            // you.Attack(me);
            // you.Attack(me);

            Console.WriteLine(me.getHealth);
            Console.WriteLine(you.getHealth);
        }
    }
}
