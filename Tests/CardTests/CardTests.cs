using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using GameObjects;

/*
 * The unit tests described in this file will test your Card code from 
 * the GameObjects project.
 * 
 * Running the tests will help you determine whether you have implemented 
 * Card correctly. The tests may be used to guide the marking
 * of your submission.
 * 
 * NOTE: The tests will not run until you have completed the method headers
 *       in the Card class as described by the UML diagram.
 * 
 * If there are any errors present in this file, it may be because:
 *     - You have not written all the necessary method headers in Card
 *       as specified by the UML diagram
 *     - You have written the method headers, but they are incorrect in some way
 *       (e.g. misspelled a method name, missing parameters, incorrect access 
 *       modifier etc.)
 *     - You are missing return statements in value-returning methods
 * 
 */

namespace GameObjectsTests {
    [TestClass()]
    public class CardTests {
        [TestMethod()]
        public void TestConstructorRunsWithoutErrors() {
            Card card = new Card(Suit.Clubs, FaceValue.Ace);
        }

        [TestMethod()]
        public void TestGetFaceValue() {
            Card card1 = new Card(Suit.Hearts, FaceValue.Seven);
            Card card2 = new Card(Suit.Clubs, FaceValue.Ace);

            Assert.AreEqual(
                FaceValue.Seven,
                card1.GetFaceValue()
            );

            Assert.AreEqual(
                FaceValue.Ace,
                card2.GetFaceValue()
            );
        }

        [TestMethod()]
        public void TestGetSuit() {
            Card card1 = new Card(Suit.Hearts, FaceValue.Seven);
            Card card2 = new Card(Suit.Clubs, FaceValue.Ace);

            Assert.AreEqual(
                Suit.Hearts,
                card1.GetSuit()
            );

            Assert.AreEqual(
                Suit.Clubs,
                card2.GetSuit()
            );
        }

        [TestMethod()]
        public void TestEquals() {
            Card card1 = new Card(Suit.Hearts, FaceValue.Seven);
            Card card2 = new Card(Suit.Hearts, FaceValue.Seven);
            Card card3 = new Card(Suit.Spades, FaceValue.Seven);
            Card card4 = new Card(Suit.Hearts, FaceValue.Nine);
            Card card5 = new Card(Suit.Clubs, FaceValue.Six);

            Assert.IsTrue(card1.Equals(card2));
            Assert.IsFalse(card1.Equals(card3));
            Assert.IsFalse(card1.Equals(card4));
            Assert.IsFalse(card1.Equals(card5));
        }

        [TestMethod()]
        public void TestCompareTo() {
            Card card1 = new Card(Suit.Clubs, FaceValue.Three);
            Card card2 = new Card(Suit.Clubs, FaceValue.Four);
            Card card3 = new Card(Suit.Diamonds, FaceValue.Two);
            Card card4 = new Card(Suit.Clubs, FaceValue.Three);

            if (card1.CompareTo(card2) > 0) {
                Assert.Fail();
            }

            if (card1.CompareTo(card3) > 0) {
                Assert.Fail();
            }

            if (card1.CompareTo(card4) != 0) {
                Assert.Fail();
            }
        }

        [TestMethod()]
        public void TestToString() {
            Assert.AreEqual(
                "3C",
                new Card(Suit.Clubs, FaceValue.Three).ToString()
            );

            Assert.AreEqual(
                "JS",
                new Card(Suit.Spades, FaceValue.Jack).ToString()
            );

            Assert.AreEqual(
                "2D",
                new Card(Suit.Diamonds, FaceValue.Two).ToString()
            );

            Assert.AreEqual(
                "8D",
                new Card(Suit.Diamonds, FaceValue.Eight).ToString()
            );

            Assert.AreEqual(
                "10S",
                new Card(Suit.Spades, FaceValue.Ten).ToString()
            );

            Assert.AreEqual(
                "KH",
                new Card(Suit.Hearts, FaceValue.King).ToString()
            );

            Assert.AreEqual(
                "AC",
                new Card(Suit.Clubs, FaceValue.Ace).ToString()
            );

        }
    }
}