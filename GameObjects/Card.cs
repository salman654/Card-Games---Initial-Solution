using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameObjects {

    public enum Suit { Clubs, Diamonds, Hearts, Spades }
    public enum FaceValue {
        Ace, Two, Three, Four, Five, Six, Seven, Eight, Nine,
        Ten, Jack, Queen, King
        }

    // <summary>
    /// This Card Class represents a single playing card. Playing Card has face value i.e.
    /// Ace, King, Queen etc., and a suit value i.e. Clubs, Diamonds, Hearts and Spades.
    /// 
    /// Student Name: Salman
    /// 
    /// 
    /// Student Name: Julieth
    /// 
    /// 
    /// </summary>

    public class Card : IEquatable<Card>, IComparable<Card> {

        private Suit _suit;
        private FaceValue _faceValue;

        /// <summary>
        /// Constructor: creates an instance of the Card object(s)
        /// </summary>
        /// <param name="_suit"></param>
        /// <param name="faceValue"></param>
        public Card(Suit _suit, FaceValue faceValue) {
            this._suit = _suit;
            _faceValue = faceValue;

        }

        /// <summary>
        /// Compares this instance (of the Card object) to other specified card, and 
        /// returns a number indicative of their relative values.
        /// </summary>
        /// <param name="other"> the object to compare with</param>
        /// <returns>1: if position of Card is after card,
        ///          0: if postion of Card is same as card,
        ///          -1: if position of Card is before card</returns>
        public int CompareTo(Card other) {
            if (_suit > other._suit) {
                return 1;
            } else if (_suit < other._suit) {
                return -1;
            } else {
                if (_faceValue > other._faceValue) {
                    return 1;
                } else if (_faceValue < other._faceValue) {
                    return -1;
                } else {
                    return 0;
                    }
                }
        }

        /// <summary>
        /// Compares an instance of this Card to another card, returns true if
        /// this Card is equivalent to the other card.
        /// </summary>
        /// <param name="other"></param>
        /// <returns>true: if the two cards are the same; 
        ///          false: if cards are different</returns>
        public bool Equals(Card other) {
            if (_faceValue.Equals(other._faceValue) && (_suit.Equals(other._suit))) {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Checks and returns the Face value type of the Card
        /// </summary>
        /// <returns>face value of any card</returns>
        public FaceValue GetFaceValue() {
            return _faceValue;
        }

        /// <summary>
        /// Checks and returns the Suit type of the Card
        /// </summary>
        /// <returns>suit type of any card</returns>
        public Suit GetSuit() {
            return _suit;
        }

        /// <summary>
        /// Gets a string value representation of any Card object.
        /// </summary>
        /// <returns>string value representation of any Card</returns>
        public override string ToString() {

            string firstSuitLetter = " ";
            string firstFaceValueLetter = " ";

            if (_faceValue < FaceValue.Jack && _faceValue != FaceValue.Ace) {
                if (FaceValue.Two == _faceValue) {
                    firstFaceValueLetter = "2";
                    firstSuitLetter = _suit.ToString()[0].ToString();
                    }
                    else if (FaceValue.Three == _faceValue) {
                    firstFaceValueLetter = "3";
                    firstSuitLetter = _suit.ToString()[0].ToString();
                    }
                    else if (FaceValue.Four == _faceValue) {
                    firstFaceValueLetter = "4";
                    firstSuitLetter = _suit.ToString()[0].ToString();
                    }
                    else if (FaceValue.Five == _faceValue) {
                    firstFaceValueLetter = "5";
                    firstSuitLetter = _suit.ToString()[0].ToString();
                    }
                    else if (FaceValue.Six == _faceValue) {
                    firstFaceValueLetter = "6";
                    firstSuitLetter = _suit.ToString()[0].ToString();
                    }
                    else if (FaceValue.Seven == _faceValue) {
                    firstFaceValueLetter = "7";
                    firstSuitLetter = _suit.ToString()[0].ToString();
                    }
                    else if (FaceValue.Eight == _faceValue) {
                    firstFaceValueLetter = "8";
                    firstSuitLetter = _suit.ToString()[0].ToString();
                    }
                    else if (FaceValue.Nine == _faceValue) {
                    firstFaceValueLetter = "9";
                    firstSuitLetter = _suit.ToString()[0].ToString();
                    }
                    else if (FaceValue.Ten == _faceValue) {
                    firstFaceValueLetter = "10";
                    firstSuitLetter = _suit.ToString()[0].ToString();
                    }
                    else {
                    }
            }
              else {
                firstSuitLetter = _suit.ToString()[0].ToString();
                firstFaceValueLetter = _faceValue.ToString()[0].ToString();
              }
            return firstFaceValueLetter + firstSuitLetter;
        }

    } //End Card Class

} // End GameObjects namespace

