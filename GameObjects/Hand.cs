using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObjects;

namespace GameObjects {

    /// <summary>
    /// Hand class represents the Playing Cards that are dealt to a Player in a card game.
    /// 
    /// Student Name: Salman
    /// 
    /// 
    /// Student Name: Julieth
    /// 
    /// 
    /// </summary>
    
    public class Hand : IEnumerable {

        private List<Card> _hand;

        /// <summary>
        /// Default 'Hand' of Cards Constructor.
        /// </summary>
        public Hand() {
            this._hand = new List<Card>();
        }

        /// <summary>
        /// Overloaded 'Hand' of Cards Constructor stipulating given list of cards
        /// </summary>
        /// <param name="_hand">a list of cards</param>
        public Hand(List<Card> _hand) {
            this._hand = new List<Card>(_hand);
        }

        /// <summary>
        /// Gets the number of Cards there are in a Players hand.
        /// </summary>
        /// <returns>number of cards in Players hand</returns>
        public int GetCount() {
            return _hand.Count;
        }

        /// <summary>
        /// Returns card at given position in a Hand of Playing Cards
        /// </summary>
        /// <param name="cardpos">index position</param>
        /// <returns>index position of this card</returns>
        public Card GetCard(int cardpos) {
            return _hand[cardpos];
        }

        /// <summary>
        /// Add a Card to a Hand of Playing Cards
        /// </summary>
        /// <param name="card">the card to be added to a Hand of Playing Cards</param>
        public void AddCard(Card card) {
            _hand.Add(card);
        }

        /// <summary>
        /// Sorts cards in a Hand of Playing Cards by Suit, then by Face Value
        /// </summary>
        public void SortHand() {
            _hand.Sort();
        }

        /// <summary>
        /// Checks if a certain card is in a Hand of Playing Cards
        /// </summary>
        /// <param name="card">the card we are checking for</param>
        /// <returns>True: if card is found in the Hand of Playing Cards;
        ///          False: if card is not found in the Hand of Playing Cards</returns>
        public bool ContainsCard(Card card) {
            return _hand.Contains(card);
        }

        /// <summary>
        /// Removes the first instance of a card from a Hand of Playing Cards
        /// </summary>
        /// <param name="card">the card to be removed</param>
        /// <returns>True: if card can be successfully removed</returns>
        public bool RemoveCard(Card card) {
            return _hand.Remove(card);
        }

        /// <summary>
        /// Removes card at a specific position in a Hand of Playing Cards.
        /// </summary>
        /// <param name="cardpos">index position of card</param>
        public void RemoveCardAt(int cardpos) {
            _hand.RemoveAt(cardpos);
        }

        /// <summary>
        /// Implements the IEnumerable public interface
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator() {
            return _hand.GetEnumerator();
        }

    } //End Hand: IEnumerable class

} //End GameObjects namespace


