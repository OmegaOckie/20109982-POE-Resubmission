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
            this.nameHeroLabel = new System.Windows.Forms.Label();
            this.shopButton = new System.Windows.Forms.Button();
            this.heroNameTextBox = new System.Windows.Forms.TextBox();
            this.saveNameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nameOfHeroLabel = new System.Windows.Forms.Label();
            this.heroStatsLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.loadButton = new System.Windows.Forms.Button();
            this.enemyStatsLabel = new System.Windows.Forms.Label();
            this.mapGroupBox = new System.Windows.Forms.GroupBox();
            this.attackButton = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.mapGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // gameMapLabel
            // 
            this.gameMapLabel.AutoSize = true;
            this.gameMapLabel.Location = new System.Drawing.Point(6, 16);
            this.gameMapLabel.Name = "gameMapLabel";
            this.gameMapLabel.Size = new System.Drawing.Size(104, 13);
            this.gameMapLabel.TabIndex = 0;
            this.gameMapLabel.Text = "Xxxxxxxxxxxxxxxxxxx";
            // 
            // nameHeroLabel
            // 
            this.nameHeroLabel.AutoSize = true;
            this.nameHeroLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameHeroLabel.Location = new System.Drawing.Point(12, 9);
            this.nameHeroLabel.Name = "nameHeroLabel";
            this.nameHeroLabel.Size = new System.Drawing.Size(156, 19);
            this.nameHeroLabel.TabIndex = 1;
            this.nameHeroLabel.Text = "Name Your Hero";
            // 
            // shopButton
            // 
            this.shopButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shopButton.Location = new System.Drawing.Point(16, 205);
            this.shopButton.Margin = new System.Windows.Forms.Padding(2);
            this.shopButton.Name = "shopButton";
            this.shopButton.Size = new System.Drawing.Size(158, 28);
            this.shopButton.TabIndex = 2;
            this.shopButton.Text = "Shop";
            this.shopButton.UseVisualStyleBackColor = true;
            this.shopButton.Click += new System.EventHandler(this.shopButton_Click);
            // 
            // heroNameTextBox
            // 
            this.heroNameTextBox.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroNameTextBox.Location = new System.Drawing.Point(174, 6);
            this.heroNameTextBox.Name = "heroNameTextBox";
            this.heroNameTextBox.Size = new System.Drawing.Size(100, 26);
            this.heroNameTextBox.TabIndex = 3;
            // 
            // saveNameButton
            // 
            this.saveNameButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveNameButton.Location = new System.Drawing.Point(280, 7);
            this.saveNameButton.Name = "saveNameButton";
            this.saveNameButton.Size = new System.Drawing.Size(123, 23);
            this.saveNameButton.TabIndex = 4;
            this.saveNameButton.Text = "Save Name";
            this.saveNameButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Hero Name";
            // 
            // nameOfHeroLabel
            // 
            this.nameOfHeroLabel.AutoSize = true;
            this.nameOfHeroLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameOfHeroLabel.Location = new System.Drawing.Point(133, 52);
            this.nameOfHeroLabel.Name = "nameOfHeroLabel";
            this.nameOfHeroLabel.Size = new System.Drawing.Size(41, 19);
            this.nameOfHeroLabel.TabIndex = 6;
            this.nameOfHeroLabel.Text = "Bob";
            // 
            // heroStatsLabel
            // 
            this.heroStatsLabel.AutoSize = true;
            this.heroStatsLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.heroStatsLabel.Location = new System.Drawing.Point(12, 80);
            this.heroStatsLabel.Name = "heroStatsLabel";
            this.heroStatsLabel.Size = new System.Drawing.Size(114, 20);
            this.heroStatsLabel.TabIndex = 7;
            this.heroStatsLabel.Text = "Hero Stats";
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(705, 9);
            this.startButton.Margin = new System.Windows.Forms.Padding(2);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(84, 28);
            this.startButton.TabIndex = 8;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.Location = new System.Drawing.Point(705, 41);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(84, 28);
            this.saveButton.TabIndex = 9;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // loadButton
            // 
            this.loadButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadButton.Location = new System.Drawing.Point(705, 72);
            this.loadButton.Margin = new System.Windows.Forms.Padding(2);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(84, 28);
            this.loadButton.TabIndex = 10;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            // 
            // enemyStatsLabel
            // 
            this.enemyStatsLabel.AutoSize = true;
            this.enemyStatsLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enemyStatsLabel.Location = new System.Drawing.Point(12, 236);
            this.enemyStatsLabel.Name = "enemyStatsLabel";
            this.enemyStatsLabel.Size = new System.Drawing.Size(126, 20);
            this.enemyStatsLabel.TabIndex = 11;
            this.enemyStatsLabel.Text = "Enemy Stats";
            // 
            // mapGroupBox
            // 
            this.mapGroupBox.Controls.Add(this.gameMapLabel);
            this.mapGroupBox.Location = new System.Drawing.Point(280, 52);
            this.mapGroupBox.Name = "mapGroupBox";
            this.mapGroupBox.Size = new System.Drawing.Size(420, 274);
            this.mapGroupBox.TabIndex = 12;
            this.mapGroupBox.TabStop = false;
            this.mapGroupBox.Text = "Map";
            // 
            // attackButton
            // 
            this.attackButton.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attackButton.Location = new System.Drawing.Point(280, 331);
            this.attackButton.Margin = new System.Windows.Forms.Padding(2);
            this.attackButton.Name = "attackButton";
            this.attackButton.Size = new System.Drawing.Size(158, 28);
            this.attackButton.TabIndex = 13;
            this.attackButton.Text = "Attack";
            this.attackButton.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(444, 331);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(246, 108);
            this.listBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.attackButton);
            this.Controls.Add(this.mapGroupBox);
            this.Controls.Add(this.enemyStatsLabel);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.heroStatsLabel);
            this.Controls.Add(this.nameOfHeroLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveNameButton);
            this.Controls.Add(this.heroNameTextBox);
            this.Controls.Add(this.shopButton);
            this.Controls.Add(this.nameHeroLabel);
            this.Name = "Form1";
            this.Text = "Dungeon Diver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mapGroupBox.ResumeLayout(false);
            this.mapGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gameMapLabel;
        private System.Windows.Forms.Label nameHeroLabel;
        private System.Windows.Forms.Button shopButton;
        private System.Windows.Forms.TextBox heroNameTextBox;
        private System.Windows.Forms.Button saveNameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameOfHeroLabel;
        private System.Windows.Forms.Label heroStatsLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label enemyStatsLabel;
        private System.Windows.Forms.GroupBox mapGroupBox;
        private System.Windows.Forms.Button attackButton;
        private System.Windows.Forms.ListBox listBox1;
    }
}

