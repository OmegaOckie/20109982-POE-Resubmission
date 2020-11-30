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
            this.shopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gameMapLabel
            // 
            this.gameMapLabel.AutoSize = true;
            this.gameMapLabel.Location = new System.Drawing.Point(145, 254);
            this.gameMapLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.gameMapLabel.Name = "gameMapLabel";
            this.gameMapLabel.Size = new System.Drawing.Size(17, 17);
            this.gameMapLabel.TabIndex = 0;
            this.gameMapLabel.Text = "X";
            // 
            // playerStatsLabel
            // 
            this.playerStatsLabel.AutoSize = true;
            this.playerStatsLabel.Location = new System.Drawing.Point(539, 9);
            this.playerStatsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.playerStatsLabel.Name = "playerStatsLabel";
            this.playerStatsLabel.Size = new System.Drawing.Size(88, 17);
            this.playerStatsLabel.TabIndex = 1;
            this.playerStatsLabel.Text = "Player Stats:";
            // 
            // shopButton
            // 
            this.shopButton.Location = new System.Drawing.Point(857, 13);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(88, 34);
            this.shopButton.TabIndex = 2;
            this.shopButton.Text = "Shop";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.playerStatsLabel);
            this.Controls.Add(this.gameMapLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameMapLabel;
        private System.Windows.Forms.Label playerStatsLabel;
        private System.Windows.Forms.Button shopButton;
    }
}

