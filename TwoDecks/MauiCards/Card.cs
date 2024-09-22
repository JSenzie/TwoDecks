namespace MauiCards
{
    internal class Card(Values value, Suits suit)
    {
        public Values Value => value;
        public Suits Suit => suit;
        public string Name => $"{Value} of {Suit}";

        public override string ToString()
        {
            return Name;
        }
    }
}
