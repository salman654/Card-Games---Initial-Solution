using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using GameObjects;
using System.Collections.Generic;

/*
 * The unit tests described in this file will test your CardPile code from 
 * the GameObjects project.
 * 
 * Running the tests will help you determine whether you have implemented 
 * CardPile correctly. The tests may be used to guide the marking
 * of your submission.
 * 
 * NOTE: The tests will not run until you have completed the method headers
 *       in the CardPile class as described by the UML diagram.
 * 
 * If there are any errors present in this file, it may be because:
 *     - You have not written all the necessary method headers in CardPile
 *       as specified by the UML diagram
 *     - You have written the method headers, but they are incorrect in some way
 *       (e.g. misspelled a method name, missing parameters, incorrect access 
 *       modifier etc.)
 *     - You are missing return statements in value-returning methods
 * 
 */

namespace GameObjectsTests {
    [TestClass()]
    public class CardPileTests {
        [TestMethod()]
        public void TestConstructorRunsWithoutErrors() {
            CardPile pile = new CardPile();
        }

        [TestMethod()]
        public void TestConstructorWithParameterRunsWithoutErrors() {
            CardPile pile = new CardPile(true);
        }

        [TestMethod()]
        public void TestGetCountWithEmptyCardPile() {
            CardPile pile = new CardPile();
            Assert.AreEqual(0, pile.GetCount());

            pile = new CardPile(false);
            Assert.AreEqual(0, pile.GetCount());
        }

        [TestMethod()]
        public void TestGetCountWithFullCardPile() {
            CardPile pile = new CardPile(true);
            Assert.AreEqual(52, pile.GetCount());
        }

        [TestMethod()]
        public void TestConstructorBuildsDeckInCorrectOrderViaDealOneCard() {
            List<Card> cardOrder = new List<Card>() {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Clubs, FaceValue.Two),
                new Card(Suit.Clubs, FaceValue.Three),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Clubs, FaceValue.Five),
                new Card(Suit.Clubs, FaceValue.Six),
                new Card(Suit.Clubs, FaceValue.Seven),
                new Card(Suit.Clubs, FaceValue.Eight),
                new Card(Suit.Clubs, FaceValue.Nine),
                new Card(Suit.Clubs, FaceValue.Ten),
                new Card(Suit.Clubs, FaceValue.Jack),
                new Card(Suit.Clubs, FaceValue.Queen),
                new Card(Suit.Clubs, FaceValue.King),
                new Card(Suit.Diamonds, FaceValue.Ace),
                new Card(Suit.Diamonds, FaceValue.Two),
                new Card(Suit.Diamonds, FaceValue.Three),
                new Card(Suit.Diamonds, FaceValue.Four),
                new Card(Suit.Diamonds, FaceValue.Five),
                new Card(Suit.Diamonds, FaceValue.Six),
                new Card(Suit.Diamonds, FaceValue.Seven),
                new Card(Suit.Diamonds, FaceValue.Eight),
                new Card(Suit.Diamonds, FaceValue.Nine),
                new Card(Suit.Diamonds, FaceValue.Ten),
                new Card(Suit.Diamonds, FaceValue.Jack),
                new Card(Suit.Diamonds, FaceValue.Queen),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Hearts, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Two),
                new Card(Suit.Hearts, FaceValue.Three),
                new Card(Suit.Hearts, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Five),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Hearts, FaceValue.Seven),
                new Card(Suit.Hearts, FaceValue.Eight),
                new Card(Suit.Hearts, FaceValue.Nine),
                new Card(Suit.Hearts, FaceValue.Ten),
                new Card(Suit.Hearts, FaceValue.Jack),
                new Card(Suit.Hearts, FaceValue.Queen),
                new Card(Suit.Hearts, FaceValue.King),
                new Card(Suit.Spades, FaceValue.Ace),
                new Card(Suit.Spades, FaceValue.Two),
                new Card(Suit.Spades, FaceValue.Three),
                new Card(Suit.Spades, FaceValue.Four),
                new Card(Suit.Spades, FaceValue.Five),
                new Card(Suit.Spades, FaceValue.Six),
                new Card(Suit.Spades, FaceValue.Seven),
                new Card(Suit.Spades, FaceValue.Eight),
                new Card(Suit.Spades, FaceValue.Nine),
                new Card(Suit.Spades, FaceValue.Ten),
                new Card(Suit.Spades, FaceValue.Jack),
                new Card(Suit.Spades, FaceValue.Queen),
                new Card(Suit.Spades, FaceValue.King)
            };

            CardPile pile = new CardPile(true);
            for (int i = 0; i < 52; i++) {
                Assert.IsTrue(cardOrder[i].Equals(pile.DealOneCard()));
            }
        }

        [TestMethod()]
        public void TestShufflePile() {
            List<Card> cardOrder = new List<Card>() {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Clubs, FaceValue.Two),
                new Card(Suit.Clubs, FaceValue.Three),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Clubs, FaceValue.Five),
                new Card(Suit.Clubs, FaceValue.Six),
                new Card(Suit.Clubs, FaceValue.Seven),
                new Card(Suit.Clubs, FaceValue.Eight),
                new Card(Suit.Clubs, FaceValue.Nine),
                new Card(Suit.Clubs, FaceValue.Ten),
                new Card(Suit.Clubs, FaceValue.Jack),
                new Card(Suit.Clubs, FaceValue.Queen),
                new Card(Suit.Clubs, FaceValue.King),
                new Card(Suit.Diamonds, FaceValue.Ace),
                new Card(Suit.Diamonds, FaceValue.Two),
                new Card(Suit.Diamonds, FaceValue.Three),
                new Card(Suit.Diamonds, FaceValue.Four),
                new Card(Suit.Diamonds, FaceValue.Five),
                new Card(Suit.Diamonds, FaceValue.Six),
                new Card(Suit.Diamonds, FaceValue.Seven),
                new Card(Suit.Diamonds, FaceValue.Eight),
                new Card(Suit.Diamonds, FaceValue.Nine),
                new Card(Suit.Diamonds, FaceValue.Ten),
                new Card(Suit.Diamonds, FaceValue.Jack),
                new Card(Suit.Diamonds, FaceValue.Queen),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Hearts, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Two),
                new Card(Suit.Hearts, FaceValue.Three),
                new Card(Suit.Hearts, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Five),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Hearts, FaceValue.Seven),
                new Card(Suit.Hearts, FaceValue.Eight),
                new Card(Suit.Hearts, FaceValue.Nine),
                new Card(Suit.Hearts, FaceValue.Ten),
                new Card(Suit.Hearts, FaceValue.Jack),
                new Card(Suit.Hearts, FaceValue.Queen),
                new Card(Suit.Hearts, FaceValue.King),
                new Card(Suit.Spades, FaceValue.Ace),
                new Card(Suit.Spades, FaceValue.Two),
                new Card(Suit.Spades, FaceValue.Three),
                new Card(Suit.Spades, FaceValue.Four),
                new Card(Suit.Spades, FaceValue.Five),
                new Card(Suit.Spades, FaceValue.Six),
                new Card(Suit.Spades, FaceValue.Seven),
                new Card(Suit.Spades, FaceValue.Eight),
                new Card(Suit.Spades, FaceValue.Nine),
                new Card(Suit.Spades, FaceValue.Ten),
                new Card(Suit.Spades, FaceValue.Jack),
                new Card(Suit.Spades, FaceValue.Queen),
                new Card(Suit.Spades, FaceValue.King)
            };

            CardPile pile = new CardPile(true);
            pile.ShufflePile();

            for (int i = 0; i < pile.GetCount(); i++) {
                if (!pile.DealOneCard().Equals(cardOrder[i])) {
                    return;
                }
            }

            // If ShufflePile is correct, there is still a 1/52! (factorial) chance
            // that failure will occur.
            // The chance of this happening is less than the chance of randomly
            // selecting a particular atom on Earth.
            Assert.Fail();

        }

        [TestMethod()]
        public void TestAddCardRunsWithoutErrors() {
            CardPile pile = new CardPile();
            pile.AddCard(new Card(Suit.Hearts, FaceValue.Seven));
            pile.AddCard(new Card(Suit.Hearts, FaceValue.Nine));
            pile.AddCard(new Card(Suit.Diamonds, FaceValue.Jack));
        }

        [TestMethod()]
        public void TestGetLastCardInPileAfterAddCard() {
            CardPile pile = new CardPile();

            pile.AddCard(new Card(Suit.Clubs, FaceValue.Ace));

            Assert.IsTrue(
                pile.GetLastCardInPile().Equals(new Card(Suit.Clubs, FaceValue.Ace))
            );

            pile.AddCard(new Card(Suit.Hearts, FaceValue.Seven));

            Assert.IsTrue(
                pile.GetLastCardInPile().Equals(new Card(Suit.Hearts, FaceValue.Seven))
            );
        }

        [TestMethod()]
        public void TestGetCountCorrectAfterAddingCards() {
            CardPile pile = new CardPile();
            pile.AddCard(new Card(Suit.Hearts, FaceValue.Seven));
            pile.AddCard(new Card(Suit.Hearts, FaceValue.Nine));
            pile.AddCard(new Card(Suit.Diamonds, FaceValue.Jack));

            Assert.AreEqual(3, pile.GetCount());
        }

        [TestMethod()]
        public void TestDealOneCardAfterAddingCards() {
            CardPile pile = new CardPile();

            pile.AddCard(new Card(Suit.Spades, FaceValue.Ace));
            pile.AddCard(new Card(Suit.Clubs, FaceValue.Queen));
            pile.AddCard(new Card(Suit.Clubs, FaceValue.Four));

            Assert.IsTrue(
                pile.DealOneCard().Equals(new Card(Suit.Spades, FaceValue.Ace))
            );
        }

        [TestMethod()]
        public void TestDealCardsAfterAddingCards() {
            CardPile pile = new CardPile();

            List<Card> cardsToAdd = new List<Card> {
                new Card(Suit.Spades, FaceValue.Ace),
                new Card(Suit.Clubs, FaceValue.Queen),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Seven),
                new Card(Suit.Diamonds, FaceValue.Seven)
            };

            foreach (Card card in cardsToAdd) {
                pile.AddCard(card);
            }

            List<Card> dealtCards = pile.DealCards(4);
            for (int i = 0; i < 4; i++) {
                Assert.IsTrue(dealtCards[i].Equals(cardsToAdd[i]));
            }
        }
    }
}
