using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CowsAndBulls
{
    public partial class GameForm : Form
    {
        private string difficulty;

        private int generatedNumberLength;

        private string generatedNumber;
        private string guessedNumber;

        private int[] cowsAndBulls;

        private int turnsPlayed;
        private int maxTurns;

        public GameForm(string difficulty)
        {
            InitializeComponent();

            this.difficulty = difficulty;
            switch (difficulty)
            {
                case "Normal":
                    maxTurns = 10;
                    break;
                case "Hard":
                    maxTurns = 5;
                    break;
                default:
                    break;
            }

            this.generatedNumberLength = 4;
            this.generatedNumber = GenerateNumber(this.difficulty, this.generatedNumberLength);
            turnsPlayed = 0;

            actionsLog.AppendText(String.Format("Player started a new game. Difficulty: {0}.\n", this.difficulty));
        }

        private void GameForm_Load(object sender, EventArgs e)
        {

        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            guessedNumber = digit1.Value.ToString() +
                digit2.Value.ToString() +
                digit3.Value.ToString() +
                digit4.Value.ToString();

            CountCowsAndBulls(guessedNumber);
        }

        private string GenerateNumber(string difficulty, int numberLength)
        {
            string number = "";

            Random random = new Random();

            if (difficulty == "Normal")
            {
                while (number.Length < numberLength)
                {
                    string temp = random.Next(0, 9).ToString();
                    if (number.Length == 0 && temp == "0")
                    {
                        continue;
                    }
                    else if (number.Contains(temp))
                    {
                        continue;
                    }
                    else
                    {
                        number += temp;
                    }
                }
            }
            else if (difficulty == "Hard")
            {
                for (int i = 0; i < numberLength; i++)
                {
                    number += random.Next(0, 9).ToString();
                }
            }

            actionsLog.AppendText(number + "\n");
            return number;
        }

        private void CountCowsAndBulls(string guessedNumber)
        {
            if (maxTurns < ++turnsPlayed)
            {
                GameOver("Computer");
            }
            else if (guessedNumber == this.generatedNumber)
            {
                GameOver("Player");
            }
            else
            {
                int bulls = 0;
                int cows = 0;

                bool[] isGuessVisted = new bool[generatedNumber.Length];
                bool[] isNumVisted = new bool[generatedNumber.Length];

                // count bulls and cows
                for (int i = 0; i < generatedNumber.Length; i++)
                {
                    if (guessedNumber[i] == generatedNumber[i])
                    {
                        bulls++;
                        isGuessVisted[i] = true; // set that we have visited this digit at index i
                        isNumVisted[i] = true; // set that we have visited this digit at index i
                    }
                }

                for (int i = 0; i < guessedNumber.Length; i++)
                {
                    for (int j = 0; j < generatedNumber.Length; j++)
                    {
                        if (i != j &&
                            !isNumVisted[j] &&
                            !isGuessVisted[i] &&
                            guessedNumber[i] == generatedNumber[j]) // check if digits are the same
                        {
                            cows++;
                            isGuessVisted[i] = true; // set that we have visited this digit at index i
                            isNumVisted[j] = true; // set that we have visited this digit at index j
                        }
                    }
                }

                actionsLog.AppendText(String.Format("Cows: {0}, Bulls: {1}\n", cows, bulls));
            }
        }

        private void GameOver(string winner)
        {
            actionsLog.AppendText(String.Format("Game over! {0} won!\n", winner));

            guessBtn.Hide();
        }
    }
}
