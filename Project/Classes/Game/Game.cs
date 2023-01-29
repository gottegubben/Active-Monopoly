using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    /// <summary>
    /// The boardgame class is for controlling the board of the game of Monopoly.
    /// </summary>
    public class Game
    {
        #region Consturctors:
        public Game(Random rnd, Action<Round> statisticCallback)
        {
            Data = MonopolyConfig.GetGameData(rnd);

            Stat = new Statistic();
        }
        #endregion

        #region Properties
        //The initial data. The players, the dices and the tiles.
        public GameData Data { get; set; }

        //The statistic class that will keep the data of the match.
        private Statistic Stat { get; set; }
        #endregion

        #region Methods:
        //Starts the match.
        public void StartMatch() 
        { 
            if(Data.Players.Count != 0)
            {
                GameLoop();
            }
            else
            {
                Log.TimeWrite("Forgot to add the players to the game!", Urgency.Incorrect);
                throw new Exception("Forgot to add the players to the game!");
            }
        }

        //Adds the players to the player list in the class.
        public void AddPlayers(int[] players)
        {
            if(players.Length < 6 && players.Length != 0)
            {
                for (int i = 0; i < players.Length; i++)
                {
                    for (int y = 0; y < players[i]; y++)
                    {
                        switch (i)
                        {
                            case 0:
                                Data.Players.Add(MonopolyConfig.GetAggressiveMaxBot());
                                break;
                            case 1:
                                Data.Players.Add(MonopolyConfig.GetAggressiveMinBot());
                                break;
                            case 2:
                                Data.Players.Add(MonopolyConfig.GetBalancedBot());
                                break;
                            case 3:
                                Data.Players.Add(MonopolyConfig.GetPassiveBot());
                                break;
                            case 4:
                                Data.Players.Add(MonopolyConfig.GetBraindeadBot());
                                break;
                        }
                    }
                }

                Data.PlayerPositionHandler = new PlayerPositionHandler(Data.Players);
            }
            else
            {
                Log.TimeWrite("The player array either didn't contain any values or owere to many!", Urgency.Incorrect);
            }
        }

        //The main loop that will run the game.
        private void GameLoop()
        {
            //Fix so that you can also play other types of games. Not just annihilation! Maybe it's fine either way.

            bool matchOngoing = true;
            while (matchOngoing) //Fix this loop!!!
            {
                new Round(Data, Stat.StoreState);

                int deadPlayers = 0;
                for (int i = 0; i < Data.Players.Count; i++)
                {
                    if (Data.Players[i].IsAlive != true)
                    {
                        deadPlayers++;
                    }
                }
                if (deadPlayers == Data.Players.Count)
                {
                    matchOngoing = false;
                }
            }
        }
        #endregion
    }
}
