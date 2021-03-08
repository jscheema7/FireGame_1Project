using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FireGame_1Project
{
  public  class Winner
    {
        static Random rd = new Random();
        int[] ram = new int[2];
        public Winner()
        {
            ram[0] = rd.Next(1, 6);
        }
        //this method is used to check the lifes of the player
        public int winTest(int chance) {
            if (chance==ram[0]) {
                return 0;
            }
            else
            {
                return 1;
            }
        }

    }
}
