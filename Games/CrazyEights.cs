using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameObjects;

namespace Games {

    /// <summary>
    /// This is the logic class (business layer) of the whole program. It handles and
    /// stores the Users requests and actions. Furthermore it ensures that the User conforms
    /// to the rules of the Card Game.
    /// 
    /// Student Name: Salman
    /// Student ID: n10057684
    /// 
    /// Student Name: Julieth
    /// Student ID: n9623540
    /// 
    /// </summary>
    /// 
    public static class CrazyEights {

        /// <summary>
        /// Declaring enum - ActionResult
        /// </summary>
        public enum ActionResult {
            /// <summary>
            /// A card was played that won the game
            /// </summary>
            WinningPlay,
            /// <summary>
            /// A valid card was played
            /// </summary>
            ValidPlay,
            /// <summary>
            /// A suit is required to continue play
            /// </summary>
            SuitRequired,
            /// <summary>
            /// Attempted to play an invalid card
            /// </summary>
            InvalidPlay,
            /// <summary>
            /// Attempted to play an invalid card when no cards can be played
            /// </summary>
            InvalidPlayAndMustDraw,
            /// <summary>
            /// A valid card was played, and the other player cannot play
            /// </summary>
            ValidPlayAndExtraTurn,
            /// <summary>
            /// Drew a playable card
            /// </summary>
            DrewPlayableCard,
            /// <summary>
            /// Drew an unplayable card
            /// </summary>
            DrewUnplayableCard,
            /// <summary>
            /// Drew an unplayable card and filled the hand
            /// </summary>
            DrewAndNoMovePossible,
            /// <summary>
            /// Drew an unplayable card and filled the hand, leaving both
            /// players unable to play, so piles were reset so that the 
            /// the other player can continue play (rule 9)
            /// </summary>
            DrewAndResetPiles,
            /// <summary>
            /// Attempted to draw a card while moves were still possible
            /// </summary>
            CannotDraw,
            /// <summary>
            /// Flipped the discard pile to use as the new draw pile (rule 10)
            /// </summary>
            FlippedDeck,
        }

        /// <summary>
        /// Private attribute - represents the pile of cards the players can draw from.
        /// </summary>
        private static CardPile _drawPile;

        /// <summary>
        /// Private attribute - represent the growing pile of cards that the players
        /// discard their 'playing' cards onto.
        /// </summary>
        private static CardPile _discardPile;

        /// <summary>
        /// Public static read-only property. Allows access to card at top of the _discardPile.
        /// </summary>
        public static Card TopDiscard {
            get {
                return _discardPile.GetLastCardInPile();
            }
        }

        /// <summary>
        /// Public static read-only property. Checks whether there are any cards that Users can
        /// draw from in the _drawPile.
        /// </summary>
        public static bool IsDrawPileEmpty {
            get {
                if (_drawPile.GetCount() == 0) {
                    return true;
                } else {
                    return false;
                }
            }
        }

        /// <summary>
        /// Public static read/write Property. Represents the Computer's hand of cards.
        /// </summary>
        public static Hand ComputerHand { get; private set; }

        /// <summary>
        /// Public static read/write Property. Represents the User's hand of cards.
        /// </summary>
        public static Hand UserHand { get; private set; }

        /// <summary>
        /// Public static read/write Property. 
        /// Tracks which player's turn it is. True: if it is the User's turn; 
        /// False: if it is the Computer's turn.
        /// </summary>
        public static bool IsUserTurn { get; private set; } = false;

        /// <summary>
        /// Public static read/write Property. 
        /// Tracks game progress. True: if a game is underway;
        /// False: if not.
        /// </summary>
        public static bool IsPlaying { get; private set; } = false;

        //METHODS:

        /// <summary>
        /// Sets up a game of Crazy Eights - according to the normal(default) rules.
        /// </summary>
        public static void StartGame() {
            _drawPile = new CardPile(true);
            _drawPile.ShufflePile();
            UserHand = new Hand(_drawPile.DealCards(8));
            ComputerHand = new Hand(_drawPile.DealCards(8));
            _discardPile = new CardPile();
            _discardPile.AddCard(_drawPile.DealOneCard());
            IsUserTurn = true;
            IsPlaying = true;
        }

        /// <summary>
        /// Sets up game of Crazy Eights - according to the prescribed given hands and 
        /// piles of cards.
        /// </summary>
        /// <param name="userHand">cards held by the User</param>
        /// <param name="computerHand">cards held by the Computer</param>
        /// <param name="drawPile">cards that both players can draw from</param>
        /// <param name="discardPile">cards that have been 'played' (discarded) by both players</param>
        public static void StartGame(Hand userHand, Hand computerHand, CardPile discardPile, CardPile drawPile) {
            _drawPile = drawPile;
            _discardPile = discardPile;
            UserHand = userHand;
            ComputerHand = computerHand;
            IsPlaying = true;
            IsUserTurn = true;
        }

        /// <summary>
        /// Sorts the cards held by the User
        /// </summary>
        public static void SortUserHand() {
            UserHand.SortHand();
        }

        /// <summary>
        /// Draws a card for the User
        /// </summary>
        /// <returns></returns>
        public static ActionResult UserDrawCard() {
            if (!IsPlaying) {
                throw new Exception("Game not Started!");
            }
            if (!IsUserTurn) {
                throw new Exception("Sorry - not User's turn to play!");
            }
            return DrawCard(UserHand);

        }

        /// <summary>
        /// Plays chosen card for the User, in compliance with the given set of rules.
        /// </summary>
        /// <param name="cardnum"></param>
        /// <param name="choosen"></param>
        /// <returns></returns>
        public static ActionResult UserPlayCard(int cardnum, Suit? choosenSuit = null) {
            return PlayCard(UserHand, cardnum, choosenSuit);
        }

        /// <summary>
        /// Performs an action as part of the Computer's turn.
        /// </summary>
        /// <returns></returns>
        public static ActionResult ComputerAction() {

            if (IsPlaying == false) {
                throw new Exception("Game not started");
            }
            if (IsUserTurn == true) {
                throw new Exception("Sorry! Not Computer's turn");
            }

            if (!IsHandPlayable(ComputerHand)) {
                return DrawCard(ComputerHand);
            } else {

                // Computer plays a card

                int cardToPlay = 0;

                // Eights
                for (int i = 0; i < ComputerHand.GetCount(); i++) {
                    if (ComputerHand.GetCard(i).GetFaceValue() == FaceValue.Eight) {
                        cardToPlay = i;
                        break;
                    }
                }
                //Matching Suits
                for (int i = 0; i < ComputerHand.GetCount(); i++) {
                    if(ComputerHand.GetCard(i).GetSuit() == TopDiscard.GetSuit()){
                        cardToPlay = i;
                        
                    }
                }
                // Matching FaceValues
                for (int i = 0; i < ComputerHand.GetCount(); i++) {
                    if(ComputerHand.GetCard(i).GetFaceValue() == TopDiscard.GetFaceValue()) {
                        cardToPlay = i;
                        
                    }
                }
               
                return PlayCard(ComputerHand, cardToPlay, ComputerHand.GetCard(cardToPlay).GetSuit());
            }
        }
        /// <summary>
        /// Plays chosen Card, from the given Hand, with a particular Suit.
        /// </summary>
        /// <param name="cardnum">the chosen card</param>
        /// <param name="choosen"></param>
        /// <returns></returns>
        private static ActionResult PlayCard(Hand thisHand, int cardnum, Suit? newSuit) {
            Hand otherHand;
            if (IsUserTurn) {
                otherHand = ComputerHand;
            } else {
                otherHand = UserHand;
            }

            //Eights
            if (thisHand.GetCard(cardnum).GetFaceValue() == FaceValue.Eight) {

                if (newSuit == null) {
                    return ActionResult.SuitRequired;
                } else {
                   
                    
                    
                    if ((IsHandPlayable(otherHand) == false) && (otherHand.GetCount() == 13)) {
                        _discardPile.AddCard(thisHand.GetCard(cardnum));
                        thisHand.RemoveCardAt(cardnum);
                        
                        return ActionResult.ValidPlayAndExtraTurn;
                    }
                    IsUserTurn = !IsUserTurn;
                    thisHand.RemoveCardAt(cardnum);
                    _discardPile.AddCard(new Card((Suit)newSuit, FaceValue.Eight));
                    return ActionResult.ValidPlay;
                    

                }
            }

            if ((IsCardPlayable(thisHand.GetCard(cardnum)) == true) && (thisHand.GetCount() == 1)) {
                _discardPile.AddCard(thisHand.GetCard(cardnum));
                thisHand.RemoveCardAt(cardnum);
                IsPlaying = false;
                return ActionResult.WinningPlay;

            }
          
            if (IsCardPlayable(thisHand.GetCard(cardnum)) == true) {



                _discardPile.AddCard(thisHand.GetCard(cardnum));
                thisHand.RemoveCardAt(cardnum);
                if ((IsHandPlayable(otherHand) == false) && (otherHand.GetCount() == 13)) {
                    

                    return ActionResult.ValidPlayAndExtraTurn;
                }

                IsUserTurn = !IsUserTurn;
                    return ActionResult.ValidPlay;

                

            }

            if (IsHandPlayable(thisHand) == false) {
                return ActionResult.InvalidPlayAndMustDraw;
            } else {

                //
                return ActionResult.InvalidPlay;
            }

        }

        /// <summary>
        /// Attempts to draw a Card into the given Hand.
        /// </summary>
        /// <param name="hand"></param>
        /// <returns></returns>
        private static ActionResult DrawCard(Hand hand) {

            Hand otherHand;
            if (IsUserTurn) {
                otherHand = ComputerHand;
            } else {
                otherHand = UserHand;
            }



            if (IsHandPlayable(hand) == true) {
                return ActionResult.CannotDraw;
            } else if ((IsDrawPileEmpty == true) && (IsHandPlayable(hand) == false)) {
                foreach (Card card in _discardPile.DealCards(_discardPile.GetCount())) {
                    _drawPile.AddCard(card);
                }
                _discardPile.AddCard(_drawPile.DealOneCard());
                return ActionResult.FlippedDeck;
            }
            hand.AddCard(_drawPile.DealOneCard());
            if (hand.GetCount() == 13 && (IsHandPlayable(hand) == false)) {

                if ((IsHandPlayable(hand) == false) && (hand.GetCount() == 13) && (IsHandPlayable(otherHand) == false) && otherHand.GetCount() == 13) {
                    IsPlaying = true;
                    IsUserTurn = !IsUserTurn;
                    return ActionResult.DrewAndResetPiles;
                } else {

                    IsUserTurn = !IsUserTurn;
                    IsPlaying = true;
                    return ActionResult.DrewAndNoMovePossible;
                }
            } else if (IsHandPlayable(hand) == false) {
                return ActionResult.DrewUnplayableCard;
            }

            return ActionResult.DrewPlayableCard;

        }

        /// <summary>
        /// Determines if the Hand contains (holds) a playable card.
        /// </summary>
        /// <param name="hand">a player's hand of cards</param>
        /// <returns>True: if hand contains playable card;
        ///          False: if not!</returns>
        private static bool IsHandPlayable(Hand hand) {
            if ((_discardPile.GetCount() == 1) && (TopDiscard.GetFaceValue() == FaceValue.Eight)) {
                return true;
            }


            foreach (Card card in hand) {
                if (TopDiscard.GetFaceValue() == card.GetFaceValue()) {
                    return true;
                } else if (TopDiscard.GetSuit() == card.GetSuit()) {
                    return true;
                } else if (card.GetFaceValue() == FaceValue.Eight) {
                    return true;
                }
            }

            return false;
        }

        /// <summary>
        /// Checks and determines if the selected card will make a valid play.
        /// </summary>
        /// <param name="card">the selected card</param>
        /// <returns>True: selected card will make valid play;
        ///          False: selected card will not make valid play</returns>
        private static bool IsCardPlayable(Card card) {
            if (TopDiscard.GetFaceValue() == card.GetFaceValue()) {
                return true;
            } else if (TopDiscard.GetSuit() == card.GetSuit()) {
                return true;
            } else if (TopDiscard.GetFaceValue() == FaceValue.Eight) {
                return true;
            }
            return false;
        }




    } //End of CrazyEights class

} //End of Games namespace
