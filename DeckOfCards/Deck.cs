using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    public class Deck
    {
        public List<Card> Cards { get; set; } = new List<Card>();

        public Deck()
        {
            // Cards = new List<Card>();
            Reset();
        }

        public void Reset()
        {
            Dictionary<int, string> faceCards = new Dictionary<int, string>()
            {
                {1, "Ace"},
                {11, "Jack"},
                {12, "Queen"},
                {13, "King"},
            };

            string[] suits = new string[]
            {
                "Hearts", "Diamonds", "Clubs", "Spades"
            };

            foreach (string suit in suits)
            {
                for (int i = 1; i <= 13; i++)
                {
                    string StringVal = i.ToString();

                    if (faceCards.ContainsKey(i))
                    {
                        StringVal = faceCards[i];
                    }
                    Card card = new Card(StringVal, suit, i);
                    Cards.Add(card);
                }
            }
        }
        public Card Deal()
        {
            if (Cards.Count > 0)
            {
                int lastIdx = Cards.Count - 1;
                Card card = Cards[lastIdx];
                Cards.RemoveAt(lastIdx);
                Console.WriteLine($"You've been dealt the {card.StringVal} of {card.Suit}.");
                return card;
            }
            return null;
        }

        public void Shuffle()
        {
            Random rando = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int randIdx = rando.Next(Cards.Count);

                Card curCard = Cards[i];
                Card randoCard = Cards[randIdx];

                Cards[i] = randoCard;
                Cards[randIdx] = curCard;
            }
        }

        public List<Card> DealHand(int numCards = 5)
        {
            List<Card> hand = new List<Card>();
            for (int i = 0; i < numCards; i++)
            {
                hand.Add(this.Deal());
            }
            Console.WriteLine("\n");
            return hand;
        }

        public void Print()
        {
            foreach (Card card in Cards)
            {
                Console.WriteLine($"{card.StringVal} of {card.Suit} | Worth: {card.Val}");
            }
        }
    }
}