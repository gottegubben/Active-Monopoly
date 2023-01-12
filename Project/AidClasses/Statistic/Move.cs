using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// Will record a move a player has made and the cards that the player has picked up (as well as the actions).
    /// </summary>
    public class Move
    {
        #region Constructors:
        //This will be the constructor that keeps the player corrolated to the move performed.
        public Move(Player player)
        {
            this.Player = player;
        }
        #endregion

        #region Properties:
        //The player that this move is corrolated to.
        public Player Player { get; set; }

        //The players position at the start of the round.
        public int PrePosition { get; set; }

        //The players position at the end of the round.
        public int PostPosition { get; set; }

        //The card that the player has picked up the round. If == null, then none cards has been picked up that round.
        public Card Card { get; set; }

        //The tile the player stepped on. If null, then the player has stayed on the same tile.
        public Tile Tile { get; set; }

        //Records if the player has bought a new property.
        public bool HasBoughtProperty { get; set; }

        //Records if the player has sold a property.
        public bool HasSoldProperty { get; set; }

        //Records if the player has constructed buildings on their properties.
        public bool HasConstructedBuilding { get; set; }

        //Records how many building if so.
        public int ConstructedBuildings { get; set; }
        #endregion
    }
}
