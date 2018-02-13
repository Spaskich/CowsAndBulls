﻿using System;
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

        private bool isGameOver;

        private Player player;
        private uint currentScore;

        public GameForm(string difficulty, string username)
        {
            InitializeComponent();

            player = new Player(username);
            currentScore = 0;

            this.difficulty = difficulty;
            switch (difficulty)
            {
                case "Normal":
                    maxTurns = 15;
                    break;
                case "Hard":
                    maxTurns = 10;
                    break;
                default:
                    break;
            }

            this.generatedNumberLength = 4;
            this.generatedNumber = GenerateNumber(this.difficulty, this.generatedNumberLength);
            turnsPlayed = 0;

            isGameOver = false;
            
            actionsLog.AppendText(String.Format("{0} started a new game. Difficulty: {1}.\n", player.Username, this.difficulty));
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

            HandleTurn(guessedNumber);
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //protected override void OnClosed(EventArgs e)
        //{
        //    Application.Exit();
        //}

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

        private void HandleTurn(string guessedNumber)
        {
            if (guessedNumber == this.generatedNumber)
            {
                GameOver("Player");
            }
            else
            {
                int[] cowsAndBulls = CountCowsAndBulls();
                int cows = cowsAndBulls[0];
                int bulls = cowsAndBulls[1];

                //add 1 point for each bull
                currentScore += (uint)bulls;

                LogResult(cows, bulls);
            }

            if (maxTurns == ++turnsPlayed)
            {
                GameOver("Computer");
            }
        }

        private int[] CountCowsAndBulls()
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

            return new int[] { cows, bulls };
        }

        private void GameOver(string winner)
        {
            player.PlayGame();

            if (winner == "Player")
            {
                winner = player.Username;
                player.AddScore(50);
            }

            actionsLog.AppendText(String.Format("Game over! {0} won!\n", winner));
            actionsLog.AppendText(String.Format("Player: {0}. Games played: {1}. Highscore: {2}", player.Username, player.GamesPlayed, player.HighScore));

            guessBtn.Hide();
        }

        private void LogResult(int cows, int bulls)
        {
            actionsLog.AppendText(String.Format("Cows: {0}, Bulls: {1}\n", cows, bulls));
        }
    }
}
