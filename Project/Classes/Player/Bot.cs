using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The bot class will play as the player by having different kinds of parameters for controlling it's behaviour.
    /// </summary>
    public class Bot : Player
    {
        #region Constructors:
        //This is the normal constructor for the bot class.
        public Bot(double purchaseChance, double buildingChance)
        {
            PurchaseChance = purchaseChance;
            BuildingChance = buildingChance;

            Buffert = 0;
            MaxConstruction = 0;
        }
        #endregion

        #region Properties:
        //The chance of the bot purchasing a tile if it is able to buy it.
        public double PurchaseChance { get; set; }

        //Determins how likely the bot is to build if it is able to do it.
        public double BuildingChance { get; set; }

        //Buffert. If the bot has less money than this in the bank, it will keep it's money instead.
        public int Buffert { get; set; }

        //The max amount of construction that the player will build.
        public int MaxConstruction { get; set; }
        #endregion

        #region Methods:
        //Returns true if the odds were in the bots favour. Will from the parameters determin if the action the bot wants to do will be accepted or not.
        public bool IsAbleToTakeAction(Random rnd, double chance)
        {
            double compareNumber = rnd.NextDouble();

            return chance >= compareNumber;
        }

        public double? ChanceAlternator(int tileId)
        {
            double[] normalized = MonopolyConfig.TileValueBestToWorstProp;

            double maxValue = normalized.Max();
            double minValue = normalized.Min();

            //zi = (xi – min(x)) / (max(x) – min(x))

            for (int i = 0; i < normalized.Length; i++)
            {
                normalized[i] = (normalized[i] - minValue) / (maxValue - minValue); 
            }

            normalized = normalized.Reverse().ToArray();

            double? returnValue = null;

            try
            {
                int index = MonopolyConfig.TileIdBestToWorstProp.ToList().FindIndex(x => x == tileId);

                returnValue = normalized[index];
            }
            catch { }

            return returnValue;
        }
        #endregion
    }
}
