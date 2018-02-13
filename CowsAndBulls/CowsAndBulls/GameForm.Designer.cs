namespace CowsAndBulls
{
    partial class GameForm
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
            this.actionsLogPanel = new System.Windows.Forms.GroupBox();
            this.actionsLog = new System.Windows.Forms.TextBox();
            this.digit1 = new System.Windows.Forms.NumericUpDown();
            this.digit2 = new System.Windows.Forms.NumericUpDown();
            this.digit3 = new System.Windows.Forms.NumericUpDown();
            this.digit4 = new System.Windows.Forms.NumericUpDown();
            this.guessBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.actionsLogPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit4)).BeginInit();
            this.SuspendLayout();
            // 
            // actionsLogPanel
            // 
            this.actionsLogPanel.Controls.Add(this.actionsLog);
            this.actionsLogPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionsLogPanel.Location = new System.Drawing.Point(13, 13);
            this.actionsLogPanel.Name = "actionsLogPanel";
            this.actionsLogPanel.Size = new System.Drawing.Size(1239, 300);
            this.actionsLogPanel.TabIndex = 0;
            this.actionsLogPanel.TabStop = false;
            this.actionsLogPanel.Text = "Actions Log";
            // 
            // actionsLog
            // 
            this.actionsLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.actionsLog.Location = new System.Drawing.Point(7, 26);
            this.actionsLog.Multiline = true;
            this.actionsLog.Name = "actionsLog";
            this.actionsLog.ReadOnly = true;
            this.actionsLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.actionsLog.Size = new System.Drawing.Size(1226, 268);
            this.actionsLog.TabIndex = 0;
            // 
            // digit1
            // 
            this.digit1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit1.Location = new System.Drawing.Point(12, 319);
            this.digit1.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit1.Name = "digit1";
            this.digit1.ReadOnly = true;
            this.digit1.Size = new System.Drawing.Size(120, 49);
            this.digit1.TabIndex = 1;
            // 
            // digit2
            // 
            this.digit2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit2.Location = new System.Drawing.Point(13, 374);
            this.digit2.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit2.Name = "digit2";
            this.digit2.ReadOnly = true;
            this.digit2.Size = new System.Drawing.Size(120, 49);
            this.digit2.TabIndex = 2;
            // 
            // digit3
            // 
            this.digit3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit3.Location = new System.Drawing.Point(12, 429);
            this.digit3.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit3.Name = "digit3";
            this.digit3.ReadOnly = true;
            this.digit3.Size = new System.Drawing.Size(120, 49);
            this.digit3.TabIndex = 3;
            // 
            // digit4
            // 
            this.digit4.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.digit4.Location = new System.Drawing.Point(12, 484);
            this.digit4.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digit4.Name = "digit4";
            this.digit4.ReadOnly = true;
            this.digit4.Size = new System.Drawing.Size(120, 49);
            this.digit4.TabIndex = 4;
            // 
            // guessBtn
            // 
            this.guessBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.guessBtn.Location = new System.Drawing.Point(138, 484);
            this.guessBtn.Name = "guessBtn";
            this.guessBtn.Size = new System.Drawing.Size(150, 50);
            this.guessBtn.TabIndex = 5;
            this.guessBtn.Text = "Guess!";
            this.guessBtn.UseVisualStyleBackColor = true;
            this.guessBtn.Click += new System.EventHandler(this.guessBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitBtn.Location = new System.Drawing.Point(952, 619);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(300, 50);
            this.quitBtn.TabIndex = 6;
            this.quitBtn.Text = "Main menu";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.guessBtn);
            this.Controls.Add(this.digit4);
            this.Controls.Add(this.digit3);
            this.Controls.Add(this.digit2);
            this.Controls.Add(this.digit1);
            this.Controls.Add(this.actionsLogPanel);
            this.Name = "GameForm";
            this.Text = "Cows and Bulls";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.actionsLogPanel.ResumeLayout(false);
            this.actionsLogPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.digit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.digit4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox actionsLogPanel;
        private System.Windows.Forms.TextBox actionsLog;
        private System.Windows.Forms.NumericUpDown digit1;
        private System.Windows.Forms.NumericUpDown digit2;
        private System.Windows.Forms.NumericUpDown digit3;
        private System.Windows.Forms.NumericUpDown digit4;
        private System.Windows.Forms.Button guessBtn;
        private System.Windows.Forms.Button quitBtn;
    }
}