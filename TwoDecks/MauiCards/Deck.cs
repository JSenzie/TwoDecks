using System.Collections.ObjectModel;

namespace MauiCards
{
    internal class Deck: ObservableCollection<Card>
    {
        public Deck() {
            Reset();
        }

        public void Reset()
        {
            Clear();
            for (int x = 0; x < Enum.GetValues(typeof(Values)).Length; x++) {
                for (int y = 0; y < Enum.GetValues(typeof(Suits)).Length; y++) {
                    Add(new Card((Values)x, (Suits)y));
                }
            }
        }

        public void Shuffle()
        {
            List<Card> copy = new List<Card>(this);
            Clear();

            while (copy.Count > 0) {
                int randomCard = Random.Shared.Next(0, copy.Count);
                Add(copy[randomCard]);
                copy.RemoveAt(randomCard);
            }

        }

        public void Sort()
        {
            List<Card> copy = new List<Card>(this);
            copy.Sort(new CardComparerByValue());
            Clear();
            foreach (Card card in copy) { 
                Add(card);
            }
        }
    }
}
