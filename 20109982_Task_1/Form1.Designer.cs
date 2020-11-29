namespace _20109982_Task_1
{
    partial class Form1
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
            this.gameMapLabel = new System.Windows.Forms.Label();
            this.playerStatsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameMapLabel
            // 
            this.gameMapLabel.AutoSize = true;
            this.gameMapLabel.Location = new System.Drawing.Point(109, 206);
            this.gameMapLabel.Name = "gameMapLabel";
            this.gameMapLabel.Size = new System.Drawing.Size(14, 13);
            this.gameMapLabel.TabIndex = 0;
            this.gameMapLabel.Text = "X";
            // 
            // playerStatsLabel
            // 
            this.playerStatsLabel.AutoSize = true;
            this.playerStatsLabel.Location = new System.Drawing.Point(431, 9);
            this.playerStatsLabel.Name = "playerStatsLabel";
            this.playerStatsLabel.Size = new System.Drawing.Size(66, 13);
            this.playerStatsLabel.TabIndex = 1;
            this.playerStatsLabel.Text = "Player Stats:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.playerStatsLabel);
            this.Controls.Add(this.gameMapLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameMapLabel;
        private System.Windows.Forms.Label playerStatsLabel;
    }
}

