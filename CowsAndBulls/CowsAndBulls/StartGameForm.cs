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
    public partial class StartGameForm : Form
    {
        public StartGameForm()
        {
            InitializeComponent();

            //set default difficulty
            chosenDifficulty.SelectedItem = "Normal";
        }

        private void StartGameForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var gameForm = new GameForm(chosenDifficulty.SelectedItem.ToString());
            gameForm.Location = this.Location;
            gameForm.StartPosition = FormStartPosition.Manual;
            gameForm.FormClosing += delegate { this.Show(); };
            gameForm.Show();
            this.Hide();
        }
    }
}
