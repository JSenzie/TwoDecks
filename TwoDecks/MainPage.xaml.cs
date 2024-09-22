using MauiCards;
namespace TwoDecks
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
        }

        private Deck GetDeckFromResources(String key)
        {
            if (Resources.TryGetValue(key, out object resource) && resource is Deck deck)
            {
                return deck;
            }
            return [];
        }


        private void Deck1_Move_Clicked(object sender, EventArgs e)
        {
            if (Deck1.SelectedItem is Card card)
            {
                GetDeckFromResources("Deck2").Add(card);
                GetDeckFromResources("Deck1").Remove(card);
            }

        }

        private void Deck2_Move_Clicked(object sender, EventArgs e)
        {
            if (Deck2.SelectedItem is Card card)
            {
                GetDeckFromResources("Deck1").Add(card);
                GetDeckFromResources("Deck2").Remove(card);
            }

        }

        private void ShuffleDeck1_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck1").Shuffle();
        }

        private void SortDeck1_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck1").Sort();
        }

        private void ResetDeck1_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck1").Reset();
        }

        private void ClearDeck1_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck1").Clear();
        }

        private void ShuffleDeck2_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck2").Shuffle();
        }

        private void SortDeck2_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck2").Sort();
        }

        private void ResetDeck2_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck2").Reset();
        }

        private void ClearDeck2_Clicked(object sender, EventArgs e)
        {
            GetDeckFromResources("Deck2").Clear();
        }
    }
}
