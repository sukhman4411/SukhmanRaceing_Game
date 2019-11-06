using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SukhmanRaceing_Game
{
   public class generateNo
    {
        Random rd = new Random();
        public int generateRandomNo()
        {
            return rd.Next(35);
        }
    }
}
