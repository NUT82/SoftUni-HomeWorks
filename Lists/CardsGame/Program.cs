using System;
using System.Collections.Generic;
using System.Linq;

namespace CardsGame
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> handFirstPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> handSecondPlayer = Console.ReadLine().Split().Select(int.Parse).ToList();
            int firstPLayerDeck = handFirstPlayer.Count;
            int secondPLayerDeck = handSecondPlayer.Count;

            while (firstPLayerDeck != 0 && secondPLayerDeck != 0)
            {
                if (handFirstPlayer[0] > handSecondPlayer[0])
                {
                    RemoveAndAddCardsToPlayers(handFirstPlayer, handSecondPlayer);
                }
                else if (handFirstPlayer[0] < handSecondPlayer[0])
                {
                    RemoveAndAddCardsToPlayers(handSecondPlayer, handFirstPlayer);
                }
                else
                {
                    RemoveAndAddCardsToPlayers(handFirstPlayer, handSecondPlayer, true);
                }

                firstPLayerDeck = handFirstPlayer.Count;
                secondPLayerDeck = handSecondPlayer.Count;
            }

            if (firstPLayerDeck > secondPLayerDeck)
            {
                Console.WriteLine($"First player wins! Sum: {handFirstPlayer.Sum()}");
            }
            else
            {
                Console.WriteLine($"Second player wins! Sum: {handSecondPlayer.Sum()}");
            }
        }

        private static void RemoveAndAddCardsToPlayers(List<int> winnerHand, List<int> looserHand, bool draw = false)
        {
            if (draw)
            {
                winnerHand.RemoveAt(0);
                looserHand.RemoveAt(0);
                return;
            }

            int winingCard = winnerHand[0];
            int loosingCard = looserHand[0];
            winnerHand.RemoveAt(0);
            looserHand.RemoveAt(0);
            winnerHand.Add(winingCard);
            winnerHand.Add(loosingCard);
        }
    }
}
