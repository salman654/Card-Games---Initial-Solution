using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects {

    /// <summary>
    /// CardPile Class represents a collection of playing cards, including - 
    /// i) a full deck at the start of game(52 cards);
    /// ii) discarded cards.
    /// Note: Cards dealt to Players is represented in the Hand Class, not in CardPile.
    /// 
    /// Student Name: Salman
    /// Student ID: n10057684
    /// 
    /// Student Name: Julieth
    /// Student ID: n9623540
    /// 
    /// </summary>
    /// 
    public class CardPile {

        private static Random _numberGenerator = new Random();
        private List<Card> _pile;

        /// <summary>
        /// Default CardPile Constructor
        /// </summary>
        public CardPile() {
            _pile = new List<Card>();
        }

        /// <summary>
        /// Overloaded CardPile Constructor - to create a CardPile with 52 Cards in order of Suits,
        /// followed by FaceValues.
        /// </summary>
        /// <param name="createPile52"></param>
        public CardPile(bool createPile52) {
            if (createPile52 == false) {
                _pile = new List<Card>();
            }
            else {
                _pile = new List<Card>();
                for (int suit = 0; suit < 4; suit++) {
                    for (int fvalue = 0; fvalue < 13; fvalue++) {
                        _pile.Add(new Card((Suit)suit, (FaceValue)fvalue));
                    }
                }
            }
        }

        /// <summary>
        /// Counts number of cards in a Pile of Cards
        /// </summary>
        /// <returns>number of cards in a Pile of Cards</returns>
        public int GetCount() {
            return _pile.Count;
            }

        /// <summary>
        /// Deals a card and removes it from Pile of Cards.
        /// </summary>
        /// <returns>Card that is dealt and removed from Pile of Cards.</returns>
        public Card DealOneCard() {
            Card card = _pile[0];
            _pile.RemoveAt(0);
            return card;
        }

        /// <summary>
        /// Shuffles the Pile of Cards
        /// </summary>
        public void ShufflePile() {
            _pile.Sort((a, b) => _numberGenerator.Next(0, 2) == 0 ? -1 : 1);
        }

        /// <summary>
        /// Adds a card to the Pile of Cards
        /// </summary>
        /// <param name="card"></param>
        public void AddCard(Card card) {
            _pile.Add(card);
        }

        /// <summary>
        /// Locates the Card at the final (last) position in a Pile of Cards.
        /// </summary>
        /// <returns>the card at the final (last) position in Pile of Cards</returns>
        public Card GetLastCardInPile() {
            return _pile.Last<Card>();
        }

        /// <summary>
        /// Deals out a hand of cards to Players
        /// </summary>
        /// <param name="cardsToDeal">number of cards to be dealt to Player</param>
        /// <returns>number of cards to be dealt out</returns>
        public List<Card> DealCards(int cardsToDeal) {
            List<Card> playingCards = new List<Card>();
            for (int i = 0; i < cardsToDeal; i++) {
                playingCards.Add(DealOneCard()); 
                }
            return playingCards;
        }

    } // End CardPile class

} // End GameObjects namespace
    
