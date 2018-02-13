using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CowsAndBulls
{
    class Player
    {
        private string username;
        private uint gamesPlayed;
        private uint highScore;

        public Player(string username)
        {
            this.Username = username;
            this.gamesPlayed = 0;
            this.highScore = 0;
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            set
            {
                if (value.Length > 10)
                {
                    value = value.Substring(0, 10);
                }

                this.username = value;
            }
        }

        public uint GamesPlayed
        {
            get;
        }

        public uint HighScore
        {
            get
            {
                return this.highScore;
            }
        }

        public void PlayGame()
        {
            this.gamesPlayed++;
        }

        public void AddScore(uint score)
        {
            if (this.highScore < score)
            {
                this.highScore = score;
            }
        }
    }
}
