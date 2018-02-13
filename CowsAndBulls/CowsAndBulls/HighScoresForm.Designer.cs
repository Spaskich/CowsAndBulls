namespace CowsAndBulls
{
    partial class HighScoresForm
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
            this.highScoresLog = new System.Windows.Forms.TextBox();
            this.quitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // highScoresLog
            // 
            this.highScoresLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.highScoresLog.Location = new System.Drawing.Point(12, 12);
            this.highScoresLog.Multiline = true;
            this.highScoresLog.Name = "highScoresLog";
            this.highScoresLog.ReadOnly = true;
            this.highScoresLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.highScoresLog.Size = new System.Drawing.Size(1240, 601);
            this.highScoresLog.TabIndex = 1;
            // 
            // quitBtn
            // 
            this.quitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitBtn.Location = new System.Drawing.Point(952, 619);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(300, 50);
            this.quitBtn.TabIndex = 7;
            this.quitBtn.Text = "Main menu";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // HighScoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.highScoresLog);
            this.Name = "HighScoresForm";
            this.Text = "HighScoresForm";
            this.Load += new System.EventHandler(this.HighScoresForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox highScoresLog;
        private System.Windows.Forms.Button quitBtn;
    }
}