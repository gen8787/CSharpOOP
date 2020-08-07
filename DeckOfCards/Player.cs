using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Player
    {
        public string Name { get; set; }
        public List<Card> Hand { get; set; } = new List<Card>();

        public Player(string name)
        {
            Name = name;
        }

        public Card Draw(Deck deck)
        {
            Card drawnCard = deck.Deal();
            Hand.Add(drawnCard);
            return drawnCard;
        }

        public Card Discard(int i)
        {
            if (i < 0 || i > Hand.Count - 1)
            {
                Console.WriteLine("You don't have that many cards!");
                return null;
            }
            Card disCard = Hand[i];
            Hand.RemoveAt(i);
            Console.WriteLine($"{Name} discarded the {disCard.StringVal} of {disCard.Suit}.");
            return disCard;
        }
    }
}