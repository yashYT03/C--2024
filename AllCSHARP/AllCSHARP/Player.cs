using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AllCSHARP;

namespace AllCSHARP
{
    class Player
    {
        public string name = "anonymous";
        private int health = 99;
        
       public  int getHealth()
        {
            return health;
        }
        public void setHealth(int h)
        {
            health = h;
        }

    }
}


        

        