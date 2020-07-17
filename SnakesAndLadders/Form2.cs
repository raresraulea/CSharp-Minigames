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

            this.Controls.Add(PlayerOneDrawing);
            playerOnePosition += current_diceRoll;
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

            playerTwoPosition += current_diceRoll;
            this.Controls.Add(PlayerTwoDrawing);
            PlayerTwoDrawing.BackColor = Color.Red; 
            PlayerTwoDrawing.Width =34; 
            PlayerTwoDrawing.Height =32; 
            PlayerTwoDrawing.Left = game.board.cellList[playerTwoPosition].x + 50; 
            PlayerTwoDrawing.Top = game.board.cellList[playerTwoPosition].y + 60;
            PlayerTwoDrawing.BringToFront();
            //this.Controls.SetChildIndex(PlayerOneDrawing, 1);
            //this.Refresh();
            //Thread.Sleep(1000);
            
        }
    }
}
