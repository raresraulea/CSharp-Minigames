namespace SnakesAndLadders
{
    partial class SLGame
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
            this.PlayerOneGameLabel = new System.Windows.Forms.Label();
            this.PlayerTwoGameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.playerTwoAtStart = new System.Windows.Forms.Panel();
            this.playerOneAtStart = new System.Windows.Forms.Panel();
            this.StartGameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Player1RollButton = new System.Windows.Forms.Button();
            this.PlayerOneRollLabel = new System.Windows.Forms.Label();
            this.PlayerTwoRollLabel = new System.Windows.Forms.Label();
            this.PlayerTwoRollButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PlayerOneGameLabel
            // 
            this.PlayerOneGameLabel.AutoSize = true;
            this.PlayerOneGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOneGameLabel.Location = new System.Drawing.Point(998, 61);
            this.PlayerOneGameLabel.Name = "PlayerOneGameLabel";
            this.PlayerOneGameLabel.Size = new System.Drawing.Size(0, 25);
            this.PlayerOneGameLabel.TabIndex = 0;
            // 
            // PlayerTwoGameLabel
            // 
            this.PlayerTwoGameLabel.AutoSize = true;
            this.PlayerTwoGameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwoGameLabel.Location = new System.Drawing.Point(998, 159);
            this.PlayerTwoGameLabel.Name = "PlayerTwoGameLabel";
            this.PlayerTwoGameLabel.Size = new System.Drawing.Size(0, 25);
            this.PlayerTwoGameLabel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackgroundImage = global::SnakesAndLadders.Properties.Resources.Board;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.playerTwoAtStart);
            this.panel1.Controls.Add(this.playerOneAtStart);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 756);
            this.panel1.TabIndex = 2;
            // 
            // playerTwoAtStart
            // 
            this.playerTwoAtStart.BackColor = System.Drawing.Color.Red;
            this.playerTwoAtStart.Location = new System.Drawing.Point(64, 658);
            this.playerTwoAtStart.Name = "playerTwoAtStart";
            this.playerTwoAtStart.Size = new System.Drawing.Size(34, 32);
            this.playerTwoAtStart.TabIndex = 1;
            this.playerTwoAtStart.Visible = false;
            // 
            // playerOneAtStart
            // 
            this.playerOneAtStart.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.playerOneAtStart.Location = new System.Drawing.Point(64, 608);
            this.playerOneAtStart.Name = "playerOneAtStart";
            this.playerOneAtStart.Size = new System.Drawing.Size(34, 32);
            this.playerOneAtStart.TabIndex = 0;
            this.playerOneAtStart.Visible = false;
            // 
            // StartGameButton
            // 
            this.StartGameButton.Location = new System.Drawing.Point(913, 584);
            this.StartGameButton.Name = "StartGameButton";
            this.StartGameButton.Size = new System.Drawing.Size(123, 59);
            this.StartGameButton.TabIndex = 3;
            this.StartGameButton.Text = "Start";
            this.StartGameButton.UseVisualStyleBackColor = true;
            this.StartGameButton.Click += new System.EventHandler(this.StartGameButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(908, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Player1:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(908, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Player2:";
            // 
            // Player1RollButton
            // 
            this.Player1RollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1RollButton.Location = new System.Drawing.Point(913, 109);
            this.Player1RollButton.Name = "Player1RollButton";
            this.Player1RollButton.Size = new System.Drawing.Size(85, 29);
            this.Player1RollButton.TabIndex = 7;
            this.Player1RollButton.Text = "Roll";
            this.Player1RollButton.UseVisualStyleBackColor = true;
            this.Player1RollButton.Click += new System.EventHandler(this.Player1RollButton_Click);
            // 
            // PlayerOneRollLabel
            // 
            this.PlayerOneRollLabel.AutoSize = true;
            this.PlayerOneRollLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOneRollLabel.Location = new System.Drawing.Point(1060, 109);
            this.PlayerOneRollLabel.Name = "PlayerOneRollLabel";
            this.PlayerOneRollLabel.Size = new System.Drawing.Size(18, 20);
            this.PlayerOneRollLabel.TabIndex = 8;
            this.PlayerOneRollLabel.Text = "0";
            this.PlayerOneRollLabel.Click += new System.EventHandler(this.Player1RollLabel_Click);
            // 
            // PlayerTwoRollLabel
            // 
            this.PlayerTwoRollLabel.AutoSize = true;
            this.PlayerTwoRollLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwoRollLabel.Location = new System.Drawing.Point(1060, 224);
            this.PlayerTwoRollLabel.Name = "PlayerTwoRollLabel";
            this.PlayerTwoRollLabel.Size = new System.Drawing.Size(18, 20);
            this.PlayerTwoRollLabel.TabIndex = 10;
            this.PlayerTwoRollLabel.Text = "0";
            // 
            // PlayerTwoRollButton
            // 
            this.PlayerTwoRollButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerTwoRollButton.Location = new System.Drawing.Point(913, 220);
            this.PlayerTwoRollButton.Name = "PlayerTwoRollButton";
            this.PlayerTwoRollButton.Size = new System.Drawing.Size(85, 29);
            this.PlayerTwoRollButton.TabIndex = 11;
            this.PlayerTwoRollButton.Text = "Roll";
            this.PlayerTwoRollButton.UseVisualStyleBackColor = true;
            this.PlayerTwoRollButton.Click += new System.EventHandler(this.PlayerTwoRollButton_Click);
            // 
            // SLGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 771);
            this.Controls.Add(this.PlayerTwoRollButton);
            this.Controls.Add(this.PlayerTwoRollLabel);
            this.Controls.Add(this.PlayerOneRollLabel);
            this.Controls.Add(this.Player1RollButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartGameButton);
            this.Controls.Add(this.PlayerTwoGameLabel);
            this.Controls.Add(this.PlayerOneGameLabel);
            this.Controls.Add(this.panel1);
            this.Name = "SLGame";
            this.Text = "Game";
            this.Load += new System.EventHandler(this.SLGame_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label PlayerOneGameLabel;
        public System.Windows.Forms.Label PlayerTwoGameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button StartGameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Player1RollButton;
        private System.Windows.Forms.Label PlayerOneRollLabel;
        private System.Windows.Forms.Label PlayerTwoRollLabel;
        private System.Windows.Forms.Button PlayerTwoRollButton;
        private System.Windows.Forms.Panel playerTwoAtStart;
        private System.Windows.Forms.Panel playerOneAtStart;
    }
}