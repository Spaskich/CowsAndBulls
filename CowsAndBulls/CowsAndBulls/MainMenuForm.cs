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
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
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
            var gameForm = new StartGameForm();
            gameForm.Location = this.Location;
            gameForm.StartPosition = FormStartPosition.Manual;
            gameForm.FormClosing += delegate { this.Show(); };
            gameForm.Show();
            this.Hide();
        }
    }
}
