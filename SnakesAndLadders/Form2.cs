using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SnakesAndLadders
{
    public partial class SLGame : Form
    {
        public SnakesAndLaddersGame game;
        public Panel PlayerOneDrawing = new Panel();
        public Panel PlayerTwoDrawing = new Panel();
        public int playerOnePosition = 0;
        public int playerTwoPosition = 0;
        public Panel p1 = new Panel();

        public SLGame()
        {
            InitializeComponent();
        }

        private void SLGame_Load(object sender, EventArgs e)
        {
            
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            game = new SnakesAndLaddersGame();
            this.playerOneAtStart.Visible = true;
            this.playerTwoAtStart.Visible = true;
            this.StartGameButton.Visible = false;
            game.Start(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Player1RollLabel_Click(object sender, EventArgs e)
        {

        }

        private void Player1RollButton_Click(object sender, EventArgs e)
        {
            int current_diceRoll = Dice.Roll();
            this.PlayerOneRollLabel.Text = current_diceRoll.ToString();
            this.playerOneAtStart.Visible = false;

            if (playerOnePosition + current_diceRoll < Constants.FinalPosition)
                playerOnePosition = NextPosition(playerOnePosition, current_diceRoll);
            else if (playerOnePosition + current_diceRoll == Constants.FinalPosition)
            {
                playerOnePosition = Constants.WinLabelHeight;
                Label WinLabel = new Label();
                this.Controls.Add(WinLabel);
                WinLabel.Text = this.PlayerOneGameLabel.Text + " wins!";
                WinLabel.Font = new Font("Arial", 20, FontStyle.Bold);
                WinLabel.Width = Constants.WinLabelHeight;
                WinLabel.Height = Constants.WinLabelHeight;
                WinLabel.Top = Constants.WinLabelTop;
                WinLabel.Left = Constants.WinLabelLeft;
                WinLabel.TextAlign = ContentAlignment.MiddleCenter;
                WinLabel.BackColor = Color.LightGreen;
                WinLabel.BringToFront();
            }

            this.Controls.Add(PlayerOneDrawing);
            
            PlayerOneDrawing.BackColor = Color.Blue;
            PlayerOneDrawing.Width = 34;
            PlayerOneDrawing.Height = 32;
            PlayerOneDrawing.Left = game.board.cellList[playerOnePosition].x + 50;
            PlayerOneDrawing.Top = game.board.cellList[playerOnePosition].y + 10;
            PlayerOneDrawing.BringToFront();

        }

        private void PlayerTwoRollButton_Click(object sender, EventArgs e)
        {
            int current_diceRoll = Dice.Roll();

            this.PlayerTwoRollLabel.Text = current_diceRoll.ToString();
            this.playerTwoAtStart.Visible = false;

            if (playerTwoPosition + current_diceRoll < Constants.FinalPosition)
                playerTwoPosition = NextPosition(playerTwoPosition, current_diceRoll);
            else if (playerTwoPosition + current_diceRoll == Constants.FinalPosition)
            {
                playerTwoPosition = Constants.FinalPosition;
                Label WinLabel = new Label();
                this.Controls.Add(WinLabel);
                WinLabel.Text = this.PlayerTwoGameLabel.Text + " wins!";
                WinLabel.Font = new Font("Arial", 20, FontStyle.Bold);
                WinLabel.Width = Constants.WinLabelWidth;
                WinLabel.Height = Constants.WinLabelHeight;
                WinLabel.Top = Constants.WinLabelTop;
                WinLabel.Left = Constants.WinLabelLeft;
                WinLabel.TextAlign = ContentAlignment.MiddleCenter;
                WinLabel.BackColor = Color.LightGreen; 
                WinLabel.BringToFront();
            }

            this.Controls.Add(PlayerTwoDrawing);
            PlayerTwoDrawing.BackColor = Color.Red; 
            PlayerTwoDrawing.Width =Constants.PlayerBoardDrawingWidth; 
            PlayerTwoDrawing.Height = Constants.PlayerBoardDrawingHeight; 
            PlayerTwoDrawing.Left = game.board.cellList[playerTwoPosition].x + 50; 
            PlayerTwoDrawing.Top = game.board.cellList[playerTwoPosition].y + 60;
            PlayerTwoDrawing.BringToFront();
            //this.Controls.SetChildIndex(PlayerOneDrawing, 1);
            //this.Refresh();
            //Thread.Sleep(1000);
            
        }

        private int NextPosition(int playerPosition, int current_diceRoll)
        {
            int result = playerPosition + current_diceRoll;
            switch (result)
            {
                case 1:
                    result = 9;
                    break;
                case 12:
                    result = 2;
                    break;
                case 14:
                    result = 22;
                    break;
                case 20:
                    result = 6;
                    break;
                case 18: 
                    result = 31;
                    break;
                case 34:
                    result = 27;
                    break;
            }
            return result;

        }
    }
}
