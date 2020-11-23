using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArinaFighter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many battles do you want guys");
            int number = 0;
            int.TryParse(Console.ReadLine(), out number);
            int battlecout = 0;
            while (battlecout < number + 1)
            {
                Battle battle = new Battle();

                Charecter player = new Charecter("Rajjo");
                Charecter opponent = new Charecter("aniya");

                battle.StartBattle(player, opponent);
                battlecout++;
            }
            
            

            Console.WriteLine("");

            //Charecter player1 = new Charecter("Rabbi");
            //int newStrength_player1 = player1.strength;

            //Console.WriteLine(player1.Name + " " + newStrength_player1);


            //Charecter player2 = new Charecter("Rahman");
            ////int newStrength_player1 = player1.strength;
            //int newStrength_player2 = player2.strength;
            //Console.WriteLine(player2.Name + " " + newStrength_player2);

            //int count = 0;

            //while ((player1.CheckLife() == true) && (player2.CheckLife() == true))
            //{
            //    if((player1.CheckLife() == false) || (player2.CheckLife() == false))
            //    {
            //        Console.WriteLine("The game is finished.");

            //    }

            //    Round round = new Round();
            //    count++;
            //    player1.strength = newStrength_player1 + player1.RunRandom();
            //    Console.WriteLine(player1.Name + " " + player1.halsa + " " + player1.strength + " " + player1.CheckLife());


            //    player2.strength = newStrength_player2 + player2.RunRandom();
            //    Console.WriteLine(player2.Name + " " + player2.halsa + " " + player2.strength + " " + player2.CheckLife());

            //    Console.WriteLine("Attttttaaaaaacccccckkkkkkkkk");

            //    if (player1.strength > player2.strength)
            //    {
            //        Console.WriteLine($"The winner is {player1.Name}");
            //        round.roundNo = count;
            //        round.winnerName = player1.Name;

            //        //battle.addInList(round);

            //        player2.halsa = player2.halsa - 2;
            //        Console.WriteLine($"Now the strength of {player1.Name} is {player1.halsa}");
            //        Console.WriteLine($"Now the strength of {player2.Name} {player2.halsa}");
            //        player1.strength = 0;
            //        player2.strength = 0;
            //    }
            //    else if (player1.strength == player2.strength)
            //    {
            //        Console.WriteLine($"The game is drawn");
            //        count = count + 1;
            //        player1.strength = 0;
            //        player2.strength = 0;
            //    }
            //    else
            //    {
            //        Console.WriteLine($"The winner is {player2.Name}");
            //        round.roundNo = count;
            //        round.winnerName = player2.Name;
            //        //battle.addInList(round);


            //        player1.halsa = player1.halsa - 2;
            //        Console.WriteLine($"Now the strength of {player1.Name} is {player1.halsa}");
            //        Console.WriteLine($"Now the strength of {player2.Name} is {player2.halsa}");

            //        player2.strength = 0;
            //        player1.strength = 0;
            //    }

            //    Console.WriteLine("----------------------------");

            //}





            Console.ReadLine();
        }
    }
}
