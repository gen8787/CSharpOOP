using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player1 = new Player("Player 1");
            Player player2 = new Player("Player 2");

            Deck deck1 = new Deck();
            deck1.Shuffle();

            player1.Draw(deck1);
            player2.Draw(deck1);
            player1.Draw(deck1);
            player2.Draw(deck1);
            player1.Draw(deck1);
            player2.Draw(deck1);

            player1.Discard(2);

            // deck1.Print();
            // Console.WriteLine(deck1.Deal());

            // deck1.Deal();
            // deck1.Deal();
            // deck1.Deal();
            
            // List<Card> hand = deck1.DealHand();

            // deck1.DealHand();


        }
    }
}
