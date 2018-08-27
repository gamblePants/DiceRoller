using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;

namespace DiceRoller
{
    public class Dice
    {
        // random number generator

        private static readonly RNGCryptoServiceProvider generator = new RNGCryptoServiceProvider();
        

        // method for rolling multiple dice of the same type and adding +/- modifier (eg 3d6 +1)
        public static int DiceRoller(int multiplier, int die, int modifier)
        {         
            double[] rollArray = new double[multiplier];
            double result = 0.0D;

            // for loop counts for number of dice rolled
            for (int i = 0; i < multiplier; i++)
            {
                // random number created here (1 to die maximum)
                byte[] random = new byte[1];
                generator.GetBytes(random);
                double asciiValue = Convert.ToDouble(random[0]);
                double rounded = Math.Max(0, (asciiValue / 255d) - 0.00000000001d);
                rollArray[i] = Math.Floor(rounded * die) + 1;

                result += rollArray[i];
            }

            // add or subtract modifier here
            result += Convert.ToDouble(modifier);

            // return number as int
            return (int)result;
        }

    }
}
