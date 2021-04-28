using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.TwentyOne
{
    public class TwentyOneGame : Game, IWalkAway
    {
        public TwentyOneDealer Dealer { get; set; }

        public static void playAgain(Player player)
        {
            if (player.Balance > 0)
            {
                Console.WriteLine("Do you want to play again, {0}?", player.Name);
                string answer = Console.ReadLine().ToLower();
                if (answer.StartsWith("y"))
                {
                    player.IsActive = true;
                    return;
                }
                else if (answer.StartsWith("n"))
                {
                    player.IsActive = false;
                    Console.WriteLine("Goodbye, {0}!", player.Name);
                    return;
                }
            }
            else if (player.Balance <= 0)
            {
                Console.WriteLine("You have broken the bank! Your balance is {0}", player.Balance);
                Console.WriteLine("Goodbye, {0}!", player.Name);
                player.IsActive = false;
                return;
            }
        }

        public override void Play()
        {
            //wipe players who opted out from player list
            List<Player> removalList = new List<Player>();
            removalList = Players.Where(x => !x.IsActive).ToList();
            foreach (Player player in removalList)
            {
                Players.Remove(player);
                Bets.Remove(player);
            }

            if (Players.Count == 0)
            {
                return;
            }


            Dealer = new TwentyOneDealer();
            foreach (Player player in Players)
            {
                player.Hand = new List<Card>();
                player.Stay = false;

            }
            Dealer.Hand = new List<Card>();
            Dealer.Stay = false;
            Dealer.Deck = new Deck();
            Dealer.Deck.Shuffle(3);

            foreach (Player player in Players)
            {
                Console.WriteLine("{0}, you have {1} in the bank.", player.Name, player.Balance);

                bool validAnswer = false;
                int bet = 0;
                while (!validAnswer)
                {
                    Console.WriteLine("Place your bet:");
                    validAnswer = int.TryParse(Console.ReadLine(), out bet);
                    if (!validAnswer)
                    {
                        Console.WriteLine("Please enter digits only, no decimals.");
                    }
                }
                if (bet < 0)
                {
                    throw new FraudException();
                }

                bool successfullyBet = player.Bet(bet);
                if (!successfullyBet)
                {
                    return;
                }
                Bets[player] = bet;
            }

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Dealing...");
                foreach (Player player in Players)
                {
                    Console.Write("{0}: ", player.Name);
                    Dealer.Deal(player.Hand);
                    if (i == 1)
                    {
                        bool blackJack = TwentyOneRules.CheckForBlackJack(player.Hand);
                        if (blackJack)
                        {
                            int blackJackPayout = Convert.ToInt32(1.5 * Bets[player]);
                            Console.WriteLine("Blackjack! {0} wins {1}", player.Name, blackJackPayout);
                            player.Balance += Convert.ToInt32(((Bets[player]) * 1.5) + Bets[player]);
                            Console.WriteLine("{0} has a balance of: {1}", player.Name, player.Balance);
                            foreach (Player blackjackplayer in Players)
                            {
                                playAgain(blackjackplayer);
                            }
                            return;
                        }
                    }
                }
                Console.Write("Dealer:");
                Dealer.Deal(Dealer.Hand);
                if (i == 1)
                {
                    bool blackJack = TwentyOneRules.CheckForBlackJack(Dealer.Hand);
                    if (blackJack)
                    {
                        Console.WriteLine("Dealer has Blackjack! Everyone loses...");
                        foreach (KeyValuePair<Player, int> entry in Bets)
                        {
                            Dealer.Balance += entry.Value;
                        }
                        foreach (Player player in Players)
                        {
                            playAgain(player);
                        }
                        return;
                    }
                }
            }
            foreach (Player player in Players)
            {
                while (!player.Stay && player.IsActive && !TwentyOneRules.IsBusted(player.Hand))
                {
                    Console.WriteLine("{0}, your cards are:", player.Name);
                    foreach (Card card in player.Hand)
                    {
                        Console.Write("{0} ", card.ToString());
                    }
                    Console.WriteLine("\nHit or Stay?");
                    string answer = Console.ReadLine().ToLower();
                    if (answer.StartsWith("s"))
                    {
                        player.Stay = true;
                        break;
                    }
                    else if (answer.StartsWith("h"))
                    {
                        Dealer.Deal(player.Hand);
                    }
                    bool busted = TwentyOneRules.IsBusted(player.Hand);
                    if (busted)
                    {
                        Dealer.Balance += Bets[player];
                        Console.WriteLine("{0} busted! Lost bet of {1}, balance is now {2}", player.Name, Bets[player], player.Balance);
                        playAgain(player);
                    }
                }
            }
            Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
            Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            while (!Dealer.Stay && !Dealer.isBusted)
            {
                Console.WriteLine("Dealer hits...");
                Dealer.Deal(Dealer.Hand);
                Dealer.isBusted = TwentyOneRules.IsBusted(Dealer.Hand);
                Dealer.Stay = TwentyOneRules.ShouldDealerStay(Dealer.Hand);
            }
            if (Dealer.Stay)
            {
                Console.WriteLine("Dealer is staying.");
            }
            if (Dealer.isBusted)
            {
                Console.WriteLine("Dealer busted!");
                foreach (KeyValuePair<Player, int> entry in Bets)
                {
                    Console.WriteLine("{0} won {1}!", entry.Key.Name, entry.Value);
                    Players.Where(x => x.Name == entry.Key.Name).First().Balance += (entry.Value * 2);
                    Dealer.Balance -= entry.Value;
                }
                foreach (Player player in Players)
                {
                    playAgain(player);
                }
                return;
            }
            foreach (Player player in Players)
            {
                if (!TwentyOneRules.IsBusted(player.Hand))
                {
                    bool? playerWon = TwentyOneRules.CompareHands(player.Hand, Dealer.Hand);
                    if (playerWon == null)
                    {
                        Console.WriteLine("Push! No one wins.");
                        player.Balance += Bets[player];
                    }
                    else if (playerWon == true)
                    {
                        Console.WriteLine("{0} won {1}!", player.Name, Bets[player]);
                        player.Balance += (Bets[player] * 2);
                        Console.WriteLine("{0} has a balance of: {1}", player.Name, player.Balance);
                        Dealer.Balance -= Bets[player];
                    }
                    else
                    {
                        Console.WriteLine("Dealer wins {0}.", Bets[player]);
                        Dealer.Balance += Bets[player];
                    }
                    playAgain(player);
                }
                else
                {
                    Console.WriteLine("Dealer wins {0}.", Bets[player]);
                    Dealer.Balance += Bets[player];
                }
            }
            return;
        }

        public override void ListPlayers()
        {
            Console.WriteLine("BlackJack players:");
            base.ListPlayers();
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();
        }
    }
}
