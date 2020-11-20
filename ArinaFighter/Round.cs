using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArinaFighter
{
    class Round 
    {
        public int roundNo;
        public string winnerName;



        //Battle battle = new Battle();
        //int randomNumber = rand.Next(min, max);


        public int RunRandom()
        {
            int randomNumber = 0;
            Random rand = new Random();
            randomNumber = rand.Next(1, 7);
            return randomNumber;
        }

    }
}
