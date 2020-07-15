namespace SnakesAndLadders
{
    partial class WelcomeForm
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
            this.PlayerOneLabel = new System.Windows.Forms.Label();
            this.PlayerOneTB = new System.Windows.Forms.TextBox();
            this.PlayerTwoTB = new System.Windows.Forms.TextBox();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PlayerOneLabel
            // 
            this.PlayerOneLabel.AutoSize = true;
            this.PlayerOneLabel.BackColor = System.Drawing.Color.Transparent;
            this.PlayerOneLabel.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlayerOneLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.PlayerOneLabel.Location = new System.Drawing.Point(76, 184);
            this.PlayerOneLabel.Name = "PlayerOneLabel";
            this.PlayerOneLabel.Size = new System.Drawing.Size(100, 22);
            this.PlayerOneLabel.TabIndex = 0;
            this.PlayerOneLabel.Text = "Player1";
            this.PlayerOneLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PlayerOneLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // PlayerOneTB
            // 
            this.PlayerOneTB.Location = new System.Drawing.Point(184, 184);
            this.PlayerOneTB.Name = "PlayerOneTB";
            this.PlayerOneTB.Size = new System.Drawing.Size(157, 22);
            this.PlayerOneTB.TabIndex = 2;
            this.PlayerOneTB.TextChanged += new System.EventHandler(this.PlayerOneTB_TextChanged);
            // 
            // PlayerTwoTB
            // 
            this.PlayerTwoTB.Location = new System.Drawing.Point(530, 184);
            this.PlayerTwoTB.Name = "PlayerTwoTB";
            this.PlayerTwoTB.Size = new System.Drawing.Size(157, 22);
            this.PlayerTwoTB.TabIndex = 3;
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.WelcomeLabel.Font = new System.Drawing.Font("Ravie", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WelcomeLabel.ForeColor = System.Drawing.Color.Coral;
            this.WelcomeLabel.Location = new System.Drawing.Point(204, 31);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(389, 129);
            this.WelcomeLabel.TabIndex = 4;
            this.WelcomeLabel.Text = "WELCOME!";
            this.WelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WelcomeLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Ravie", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(417, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Player2";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Pristina", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.button1.Location = new System.Drawing.Point(335, 312);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 34);
            this.button1.TabIndex = 6;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SnakesAndLadders.Properties.Resources.green_felt;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.PlayerTwoTB);
            this.Controls.Add(this.PlayerOneTB);
            this.Controls.Add(this.PlayerOneLabel);
            this.Name = "WelcomeForm";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PlayerOneLabel;
        private System.Windows.Forms.Label WelcomeLabel;
        public System.Windows.Forms.TextBox PlayerOneTB;
        public System.Windows.Forms.TextBox PlayerTwoTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}

