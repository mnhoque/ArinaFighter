using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArinaFighter
{
    class Battle
    {

        //private readonly List<Round> RoundList = new List<Round>();

        ////public IEnumerable<Round> SubHead { get { return RoundList; } }

        //public void addInList(Round round)
        //{
        //    RoundList.Add(round);
        //}

        int newStrength_player1 = 0;
        int newStrength_player2 = 0;
        int count = 0;
        public void StartBattle(Charecter player, Charecter opponent)
        {
            while ((player.CheckLife() == true) && (opponent.CheckLife() == true))
            {
                if ((player.CheckLife() == false) || (opponent.CheckLife() == false))
                {
                    Console.WriteLine("The game is finished.");

                }

                Round round = new Round();
                count++;
                player.strength = newStrength_player1 + round.RunRandom();
                Console.WriteLine(player.Name + " " + player.halsa + " " + player.strength + " " + player.CheckLife());


                opponent.strength = newStrength_player2 + round.RunRandom();
                Console.WriteLine(opponent.Name + " " + opponent.halsa + " " + opponent.strength + " " + opponent.CheckLife());

                Console.WriteLine("Attttttaaaaaacccccckkkkkkkkk");

                if (player.strength > opponent.strength)
                {
                    Console.WriteLine($"The winner is {player.Name}");
                    round.roundNo = count;
                    round.winnerName = player.Name;

                    //battle.addInList(round);

                    opponent.halsa = opponent.halsa - 2;
                    Console.WriteLine($"Now the strength of {player.Name} is {player.halsa}");
                    Console.WriteLine($"Now the strength of {opponent.Name} {opponent.halsa}");
                    player.strength = 0;
                    opponent.strength = 0;
                }
                else if (player.strength == opponent.strength)
                {
                    Console.WriteLine($"The game is drawn");
                    count = count + 1;
                    player.strength = 0;
                    opponent.strength = 0;
                }
                else
                {
                    Console.WriteLine($"The winner is {opponent.Name}");
                    round.roundNo = count;
                    round.winnerName = opponent.Name;
                    //battle.addInList(round);


                    player.halsa = player.halsa - 2;
                    Console.WriteLine($"Now the strength of {player.Name} is {player.halsa}");
                    Console.WriteLine($"Now the strength of {opponent.Name} is {opponent.halsa}");

                    opponent.strength = 0;
                    player.strength = 0;
                }

                Console.WriteLine("----------------------------");

            }




        }
    }
}
