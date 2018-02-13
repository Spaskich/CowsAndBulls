using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    static class PlayerBase
    {
        private static SortedSet<Player> playerBase;

        public static void InitializePlayerBase()
        {
            playerBase = new SortedSet<Player>();
        }

        public static void AddPlayer(Player player)
        {
            if (!playerBase.Any(p => p.Username == player.Username))
            {
                playerBase.Add(player);
            }
        }

        public static Player GetPlayer(string username)
        {
            return playerBase.First(p => p.Username == username);
        }

        public static bool ContainsPlayer(string username)
        {
            return playerBase.Any(p => p.Username == username);
        }

        public static void SerializePlayerBase()
        {
            try
            {
                using (Stream stream = File.Open("players.bin", FileMode.Create))
                {
                    BinaryFormatter bin = new BinaryFormatter();
                    bin.Serialize(stream, playerBase);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static void DeserializePlayerBase()
        {
            try
            {
                using (Stream stream = File.Open("players.bin", FileMode.Open))
                {
                    BinaryFormatter bin = new BinaryFormatter();

                    playerBase = (SortedSet<Player>)bin.Deserialize(stream);
                }
            }
            catch (FileNotFoundException)
            {
                InitializePlayerBase();
            }
            catch (IOException e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        public static SortedSet<Player> GetPlayerBase()
        {
            return playerBase;
        }
    }
}
