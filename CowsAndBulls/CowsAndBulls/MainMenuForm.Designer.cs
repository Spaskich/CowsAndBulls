namespace CowsAndBulls
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PlayBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.highScoresBtn = new System.Windows.Forms.Button();
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.chosenDifficulty = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.usernameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // PlayBtn
            // 
            this.PlayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PlayBtn.Location = new System.Drawing.Point(12, 507);
            this.PlayBtn.Name = "PlayBtn";
            this.PlayBtn.Size = new System.Drawing.Size(300, 50);
            this.PlayBtn.TabIndex = 0;
            this.PlayBtn.Text = "Play";
            this.PlayBtn.UseVisualStyleBackColor = true;
            this.PlayBtn.Click += new System.EventHandler(this.PlayBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitBtn.Location = new System.Drawing.Point(12, 619);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(300, 50);
            this.quitBtn.TabIndex = 1;
            this.quitBtn.Text = "Quit";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // highScoresBtn
            // 
            this.highScoresBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highScoresBtn.Location = new System.Drawing.Point(12, 563);
            this.highScoresBtn.Name = "highScoresBtn";
            this.highScoresBtn.Size = new System.Drawing.Size(300, 50);
            this.highScoresBtn.TabIndex = 2;
            this.highScoresBtn.Text = "High Scores";
            this.highScoresBtn.UseVisualStyleBackColor = true;
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.difficultyLabel.Location = new System.Drawing.Point(5, 277);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(168, 42);
            this.difficultyLabel.TabIndex = 8;
            this.difficultyLabel.Text = "Difficulty:";
            // 
            // chosenDifficulty
            // 
            this.chosenDifficulty.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chosenDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chosenDifficulty.FormattingEnabled = true;
            this.chosenDifficulty.Items.AddRange(new object[] {
            "Normal",
            "Hard"});
            this.chosenDifficulty.Location = new System.Drawing.Point(12, 322);
            this.chosenDifficulty.Name = "chosenDifficulty";
            this.chosenDifficulty.Size = new System.Drawing.Size(200, 50);
            this.chosenDifficulty.TabIndex = 7;
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userLabel.Location = new System.Drawing.Point(5, 375);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(200, 42);
            this.userLabel.TabIndex = 10;
            this.userLabel.Text = "Username:";
            this.userLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // usernameTextbox
            // 
            this.usernameTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameTextbox.Location = new System.Drawing.Point(13, 421);
            this.usernameTextbox.MaxLength = 15;
            this.usernameTextbox.Name = "usernameTextbox";
            this.usernameTextbox.Size = new System.Drawing.Size(300, 49);
            this.usernameTextbox.TabIndex = 11;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.usernameTextbox);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.chosenDifficulty);
            this.Controls.Add(this.highScoresBtn);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.PlayBtn);
            this.Name = "MainMenuForm";
            this.Text = "Cows and Bulls";
            this.Load += new System.EventHandler(this.MainMenuForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PlayBtn;
        private System.Windows.Forms.Button quitBtn;
        private System.Windows.Forms.Button highScoresBtn;
        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.ComboBox chosenDifficulty;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox usernameTextbox;
    }
}

