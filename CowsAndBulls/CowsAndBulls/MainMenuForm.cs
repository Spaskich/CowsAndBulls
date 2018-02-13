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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();

            //set default difficulty
            chosenDifficulty.SelectedItem = "Normal";
        }

        private void quitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {

        }

        private void PlayBtn_Click(object sender, EventArgs e)
        {
            string username;

            if (usernameTextbox.Text.Length == 0)
            {
                //set default username
                username = "Guest";
            }
            else
            {
                username = usernameTextbox.Text;
            }

            var gameForm = new GameForm(chosenDifficulty.SelectedItem.ToString(), username);
            gameForm.Location = this.Location;
            gameForm.StartPosition = FormStartPosition.Manual;
            gameForm.FormClosing += delegate { this.Show(); };
            gameForm.Show();
            this.Hide();
        }
    }
}
