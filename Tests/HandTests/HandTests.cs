using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using GameObjects;
using System.Collections.Generic;

/*
 * The unit tests described in this file will test your Hand code from 
 * the GameObjects project.
 * 
 * Running the tests will help you determine whether you have implemented 
 * Hand correctly. The tests may be used to guide the marking
 * of your submission.
 * 
 * NOTE: The tests will not run until you have completed the method headers
 *       in the Hand class as described by the UML diagram.
 * 
 * If there are any errors present in this file, it may be because:
 *     - You have not written all the necessary method headers in Hand
 *       as specified by the UML diagram
 *     - You have written the method headers, but they are incorrect in some way
 *       (e.g. misspelled a method name, missing parameters, incorrect access 
 *       modifier etc.)
 *     - You are missing return statements in value-returning methods
 * 
 */

namespace GameObjectsTests {
    [TestClass()]
    public class HandTests {
        [TestMethod()]
        public void TestConstructorRunsWithoutErrors() {
            Hand hand = new Hand();
        }

        [TestMethod()]
        public void TestConstructorWithParametersRunsWithoutErrors() {
            List<Card> cards = new List<Card> {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Spades, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Ten)
            };

            Hand hand = new Hand(cards);
        }

        [TestMethod()]
        public void TestGetCountWithEmptyHandIsZero() {
            Hand hand = new Hand();
            Assert.IsTrue(hand.GetCount() == 0);
        }

        [TestMethod()]
        public void TestGetCountWithHandFilledViaConstructor() {
            List<Card> cards = new List<Card> {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Spades, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Ten)
            };

            Hand hand = new Hand(cards);

            Assert.AreEqual(6, hand.GetCount());
        }

        [TestMethod()]
        public void TestGetCountWithHandFilledViaAddCard() {
            List<Card> cards = new List<Card> {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Spades, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Ten)
            };

            Hand hand = new Hand();
            foreach (Card card in cards) {
                hand.AddCard(card);
            }

            Assert.AreEqual(6, hand.GetCount());
        }

        [TestMethod()]
        public void TestAddCardRunsWithoutErrors() {
            Hand hand = new Hand();
            hand.AddCard(new Card(Suit.Clubs, FaceValue.Ace));
            hand.AddCard(new Card(Suit.Diamonds, FaceValue.Seven));
        }

        [TestMethod()]
        public void TestAddCardPreservesOrderViaGetCard() {
            Hand hand = new Hand();
            hand.AddCard(new Card(Suit.Clubs, FaceValue.Ace));
            Assert.IsTrue(hand.GetCard(0).Equals(new Card(Suit.Clubs, FaceValue.Ace)));

            hand.AddCard(new Card(Suit.Diamonds, FaceValue.Seven));
            Assert.IsTrue(hand.GetCard(1).Equals(new Card(Suit.Diamonds, FaceValue.Seven)));

            hand.AddCard(new Card(Suit.Clubs, FaceValue.King));
            Assert.IsTrue(hand.GetCard(2).Equals(new Card(Suit.Clubs, FaceValue.King)));
        }

        [TestMethod()]
        public void TestSortHand() {
            List<Card> cardsNotSorted = new List<Card> {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Spades, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Ten)
            };

            List<Card> cardsSorted = new List<Card> {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Hearts, FaceValue.Ten),
                new Card(Suit.Spades, FaceValue.Four)
            };

            Hand hand = new Hand(cardsNotSorted);
            hand.SortHand();

            for (int i = 0; i < cardsNotSorted.Count; i++) {
                Assert.IsTrue(hand.GetCard(i).Equals(cardsSorted[i]));
            }
        }

        [TestMethod()]
        public void TestGetEnumerator() {
            List<Card> cards = new List<Card> {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Spades, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Ten)
            };

            Hand hand = new Hand(cards);

            foreach (Card card in hand) { }
        }

        [TestMethod()]
        public void TestContainsCard() {
            List<Card> containsCards = new List<Card> {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Spades, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Ten)
            };

            List<Card> doesNotContainCards = new List<Card> {
                new Card(Suit.Hearts, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Seven),
                new Card(Suit.Diamonds, FaceValue.Two),
                new Card(Suit.Spades, FaceValue.Five),
                new Card(Suit.Spades, FaceValue.Jack),
                new Card(Suit.Hearts, FaceValue.Four)
            };

            Hand hand = new Hand(containsCards);

            foreach (Card card in containsCards) {
                Assert.IsTrue(hand.ContainsCard(card));
            }

            foreach (Card card in doesNotContainCards) {
                Assert.IsFalse(hand.ContainsCard(card));
            }
        }

        [TestMethod()]
        public void TestGetCard() {
            List<Card> cards = new List<Card> {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Spades, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Ten)
            };

            Hand hand = new Hand(cards);

            for (int i = 0; i < cards.Count; i++) {
                Assert.AreEqual(cards[i], hand.GetCard(i));
            }

        }

        [TestMethod()]
        public void TestRemoveCard() {
            List<Card> cards = new List<Card> {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Spades, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Ten)
            };

            Hand hand = new Hand(cards);

            Assert.IsTrue(hand.ContainsCard(new Card(Suit.Clubs, FaceValue.Ace)));
            hand.RemoveCard(new Card(Suit.Clubs, FaceValue.Ace));
            Assert.IsFalse(hand.ContainsCard(new Card(Suit.Clubs, FaceValue.Ace)));

            Assert.IsTrue(hand.ContainsCard(new Card(Suit.Hearts, FaceValue.Ten)));
            hand.RemoveCard(new Card(Suit.Hearts, FaceValue.Ten));
            Assert.IsFalse(hand.ContainsCard(new Card(Suit.Hearts, FaceValue.Ten)));
        }

        [TestMethod()]
        public void TestRemoveCardAt() {
            List<Card> cards = new List<Card> {
                new Card(Suit.Clubs, FaceValue.Ace),
                new Card(Suit.Hearts, FaceValue.Six),
                new Card(Suit.Diamonds, FaceValue.King),
                new Card(Suit.Clubs, FaceValue.Four),
                new Card(Suit.Spades, FaceValue.Four),
                new Card(Suit.Hearts, FaceValue.Ten)
            };

            Hand hand = new Hand(cards);

            Assert.IsTrue(hand.ContainsCard(new Card(Suit.Clubs, FaceValue.Ace)));
            hand.RemoveCardAt(0);
            Assert.IsFalse(hand.ContainsCard(new Card(Suit.Clubs, FaceValue.Ace)));

            Assert.IsTrue(hand.ContainsCard(new Card(Suit.Hearts, FaceValue.Six)));
            hand.RemoveCardAt(0);
            Assert.IsFalse(hand.ContainsCard(new Card(Suit.Hearts, FaceValue.Six)));

            Assert.IsTrue(hand.ContainsCard(new Card(Suit.Hearts, FaceValue.Ten)));
            hand.RemoveCardAt(3);
            Assert.IsFalse(hand.ContainsCard(new Card(Suit.Hearts, FaceValue.Ten)));
        }
    }
}
