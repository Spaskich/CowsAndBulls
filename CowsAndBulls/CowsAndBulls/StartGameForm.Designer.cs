namespace CowsAndBulls
{
    partial class StartGameForm
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
            this.difficultyLabel = new System.Windows.Forms.Label();
            this.chosenDifficulty = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // difficultyLabel
            // 
            this.difficultyLabel.AutoSize = true;
            this.difficultyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.difficultyLabel.Location = new System.Drawing.Point(5, 518);
            this.difficultyLabel.Name = "difficultyLabel";
            this.difficultyLabel.Size = new System.Drawing.Size(168, 42);
            this.difficultyLabel.TabIndex = 6;
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
            this.chosenDifficulty.Location = new System.Drawing.Point(12, 563);
            this.chosenDifficulty.Name = "chosenDifficulty";
            this.chosenDifficulty.Size = new System.Drawing.Size(200, 50);
            this.chosenDifficulty.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 619);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 50);
            this.button1.TabIndex = 7;
            this.button1.Text = "Start Game";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StartGameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.difficultyLabel);
            this.Controls.Add(this.chosenDifficulty);
            this.Name = "StartGameForm";
            this.Text = "StartGameForm";
            this.Load += new System.EventHandler(this.StartGameForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label difficultyLabel;
        private System.Windows.Forms.ComboBox chosenDifficulty;
        private System.Windows.Forms.Button button1;
    }
}