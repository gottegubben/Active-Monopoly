using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The dice class will just be for simulating all kinds of dice throws.
    /// </summary>
    public class Dice
    {
        #region Constructors:
        //Creates a ordinary dice, from 1 to 6.
        public Dice()
        {
            minValue = 1;

            maxValue = 6;

            random = new Random();
        }

        //Ordinary dice with a seed.
        public Dice(int seed)
        {
            minValue = 1;

            maxValue = 6;

            random = new Random(seed);
        }

        //This constructor creates a dice with a min and max value.
        public Dice(int min, int max)
        {
            minValue = min;

            maxValue = max;

            random = new Random();
        }

        //This constructor creates a dice with a specified seed and a min and max value.
        public Dice(int min, int max, int seed)
        {
            minValue = min;

            maxValue = max;

            random = new Random(seed);
        }
        #endregion

        #region Properties:
        //The random class will be useful if you want to randomize the dice throw.
        private Random random { get; }

        //The lowest value the dice can throw. For a ordinary dice this is 1.
        private int minValue { get; }

        //The highest value you can get by throwing a dice.
        private int maxValue { get; }
        #endregion

        #region Methods:
        //Throw method simulates a throw and returns the value the dice throw generated.
        public int Throw()
        {
            return random.Next(minValue, maxValue + 1);
        }

        //Simulates a tampered throw.
        public int TamperedThrow()
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
