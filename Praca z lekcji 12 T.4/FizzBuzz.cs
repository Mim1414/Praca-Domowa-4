using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praca_z_lekcji_12_T._4
{
    class FizzBuzz
    {
        public string Fizz(int game)
        {


            if (game % 15 == 0)
            {
                return "FizzBuzz";
            }
            else if (game % 3 == 0)
            {
                return "Fizz";
            }
            else if (game % 5 == 0)
            {
                return "Buzz";
            }
            else
            {
                return game.ToString();
            }
        }
    }
}
