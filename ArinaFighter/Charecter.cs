using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ArinaFighter
{
    class Charecter
    {
        public bool isAlive { get; set; }

        private string playerName; // field

        public string Name   // property
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public int halsa { get; set; }
        public int strength { get; set; }
        

        public Charecter()
        {
            halsa = 10;
        }
        Random rand = new Random();

        
        public Charecter(string _playername):this()
        {
            this.playerName = _playername;
            
            strength = rand.Next(1,7);
           
        }

        public bool CheckLife()
        {
            if (halsa <= 0)
            {
                isAlive = false;
            }
            else
            {
                isAlive = true;
            }
            return isAlive;
        }
        
        

    }
}
