using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameObjects;

namespace Games {

    public static class TwentyOne {

        public enum Player { Player, Dealer };
        public enum Status { Dealer_Win, Player_Win, Player_Bust, Tie, In_Progress };

        private static CardPile _deck;
        private static Hand _playerHand;
        private static Hand _dealerHand;
        private const int STARTING_HAND_SIZE = 2;
        private static int _numPlayerWins;
        private static int _numDealerWins;
        private static Status _status;

        public static void NewGame() {
            _numPlayerWins = 0;
            _numDealerWins = 0;
            NewRound();
        }

        public static void NewRound() {
            _deck = new CardPile(fullDeck: true);
            _deck.ShufflePile();

            _playerHand = new Hand();
            _dealerHand = new Hand();

            foreach (Card card in _deck.DealCards(STARTING_HAND_SIZE)) {
                _playerHand.AddCard(card);
            }

            foreach (Card card in _deck.DealCards(STARTING_HAND_SIZE)) {
                _dealerHand.AddCard(card);
            }

        }

        public static Status GetStatus() {
            return _status;
        }

        public static void Hit(Player player) {
            if (_status == Status.In_Progress) {
                Card newCard = _deck.DealOneCard();
                if (player == Player.Player) {
                    _playerHand.AddCard(newCard);
                    if (GetScore(Player.Player) > 21) {
                        return Status.
                    }
                } else if (player == Player.Dealer) {
                    _dealerHand.AddCard(newCard);
                }
            }
        }

        public static void DealerPlay() {
            while (GetScore(Player.Dealer) < 17) {
                Hit(Player.Dealer);
            }

            if (GetScore(Player.Player) == 21 && GetScore() ) {

            }
        }

        public static int GetScore(Player player) {
            int score = 0;

            Hand hand;
            if (player == Player.Player) {
                hand = _playerHand;
            } else {
                hand = _dealerHand;
            }

            foreach (Card card in hand) {
                if (card.GetFaceValue() == FaceValue.Ace) {
                    score += 11;
                } else if (card.GetFaceValue() < FaceValue.Jack) {
                    score += (int)card.GetFaceValue() + 2;
                } else {
                    score += 10;
                }
            }

            return score;
        }

    }
}
