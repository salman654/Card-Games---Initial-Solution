using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GameObjects;
using Games;

/*
 * This Console Project is for you to test the functionality of
 * your classes defined in GameObjects and Games.
 * 
 * The code here will not be assessed.
 * ==========================================================
 * 
 * CrazyEights Text-based Gameplay Interface
 * 
 * Author: Ashley Stewart, September 2018
 * Email: a15.stewart@qut.edu.au
 * 
 * =========================================================
 */

class Program {
    static void Main() {
        // Setup a new game of CrazyEights
        CrazyEights.StartGame();

        // Game loop
        while (CrazyEights.IsPlaying) {
            if (CrazyEights.IsUserTurn) {
                UserTurn();
            }
            else {
                ComputerTurn();
            }
        }

        // End game
        Console.WriteLine("Game over!");
        ExitProgram();
    }

    static void UserTurn() {
        Console.WriteLine("================");
        Console.WriteLine("  User's turn!  ");
        Console.WriteLine("================");

        DisplayBoard();

        // User decides what to do
        int userChoice = (int)GetUserNum(
            message: "Choose a card (0 to draw): ",
            min: 0,
            max: CrazyEights.UserHand.GetCount(),
            wholeNumber: true
        );
        CrazyEights.ActionResult result;

        if (userChoice == 0) { // DRAW A CARD

            result = CrazyEights.UserDrawCard();
            Console.WriteLine(result);

        }
        else { // PLAY A CARD

            // Attempt to play the chosen card
            result = CrazyEights.UserPlayCard(userChoice - 1);

            // If a suit is needed, get one from the user and play the card again
            if (result == CrazyEights.ActionResult.SuitRequired) {
                Suit chosenSuit = GetSuit();
                result = CrazyEights.UserPlayCard(userChoice - 1, chosenSuit);
            }

            Console.WriteLine(result);
        }
    }

    static void ComputerTurn() {
        Console.WriteLine("================");
        Console.WriteLine("Computer's turn!");
        Console.WriteLine("================");

        // Repeat as long as it is the computer's turn and the game is not over
        while (!CrazyEights.IsUserTurn && CrazyEights.IsPlaying) {
            DisplayBoard();
            CrazyEights.ActionResult result = CrazyEights.ComputerAction();
            Console.ReadLine();
            Console.WriteLine(result);
        }
    }

    static Suit GetSuit() {
        Console.WriteLine("\nChoose a suit: ");
        Console.WriteLine("    1. Clubs");
        Console.WriteLine("    2. Diamonds");
        Console.WriteLine("    3. Hearts");
        Console.WriteLine("    4. Spades\n");

        int choice = (int)GetUserNum(
            message: "Enter your choice: ",
            min: 1,
            max: 4,
            wholeNumber: true
        );

        return (Suit)(choice - 1);
    }

    static void DisplayBoard() {
        Console.WriteLine("===================================");
        Console.WriteLine("   COMPUTER");
        DisplayHand(CrazyEights.ComputerHand);
        Console.WriteLine("\n\tDiscard: {0} ", CrazyEights.TopDiscard);
        Console.WriteLine("\t   Draw: {0}\n", CrazyEights.IsDrawPileEmpty ? "EMPTY" : "NOT EMPTY");
        Console.WriteLine("   USER");
        DisplayHand(CrazyEights.UserHand);
        Console.WriteLine("===================================");
    }

    static void DisplayHand(Hand hand) {
        // print card numbers
        for (int i = 0; i < hand.GetCount(); i++) {
            Console.Write("{0,4}", (i + 1).ToString());
        }
        Console.WriteLine();

        // print card values
        foreach (Card card in hand) {
            Console.Write("{0,4}", card);
        }
        Console.WriteLine();
    }

    static void ExitProgram() {
        Console.Write("\nPress ENTER to exit. ");
        Console.ReadLine();
    }

    static double GetUserNum(string message,
                         double min = double.MinValue,
                         double max = double.MaxValue,
                         bool wholeNumber = false) {

        double userNum;

        bool valid = false;
        do {
            Console.Write(message);

            if (!double.TryParse(Console.ReadLine(), out userNum)) {
                Console.WriteLine("Input must be numeric!\n");
            }
            else if (wholeNumber && userNum - (int)userNum != 0) {
                Console.WriteLine("Input must be a whole number!\n");
            }
            else if (userNum < min) {
                Console.WriteLine("Input must be at least {0}!\n", min);
            }
            else if (userNum > max) {
                Console.WriteLine("Input must be at most {0}!\n", max);
            }
            else {
                valid = true;
            }

        } while (!valid);


        return userNum;
    }
}
