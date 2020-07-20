using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakesAndLadders
{
    public class Player
    {
        private string name;
        public int position;

        public object Controls { get; private set; }
        public object PlayerTwoGameLabel { get; private set; }

        public Player(string text)
        {
            position = 0;
            this.name = text;
        }

        public Player()
        {
            position = 0;
            name = "Default Player";
        }

        internal void ShowPlayerTwo(SLGame form)
        {
            throw new NotImplementedException();
        }

        internal void HidePlayerTwo(SLGame form)
        {
            form.PlayerTwoDrawing.BackColor = Color.Transparent;
        }

        internal void UpdatePlayerTwo(SLGame form)
        {
            throw new NotImplementedException();
        }

        internal string GetPosition()
        {
            return this.position.ToString();
        }

        internal void MakeYourMoves(SLGame form, int current_diceRoll)
        {
            if (this.position + current_diceRoll < Constants.FinalPosition)
                this.position = form.NextPosition(this.position, current_diceRoll);
            else if (this.position + current_diceRoll == Constants.FinalPosition)
            {
                this.position = Constants.FinalPosition;
                Label WinLabel = new Label();
                form.Controls.Add(WinLabel);

                if (this == form.game.playersList[0])
                    WinLabel.Text = form.PlayerOneGameLabel.Text + " wins!";
                else if (this == form.game.playersList[1])
                    WinLabel.Text = form.PlayerTwoGameLabel.Text + " wins!";

                WinLabel.Font = new Font("Arial", 20, FontStyle.Bold);
                WinLabel.Width = Constants.WinLabelWidth;
                WinLabel.Height = Constants.WinLabelHeight;
                WinLabel.Top = Constants.WinLabelTop;
                WinLabel.Left = Constants.WinLabelLeft;
                WinLabel.TextAlign = ContentAlignment.MiddleCenter;
                WinLabel.BackColor = Color.LightGreen;
                WinLabel.BringToFront();
            }

            if (this == form.game.playersList[0])
            {
                form.Controls.Add(form.PlayerOneDrawing);
                form.PlayerOneDrawing.BackColor = Color.Blue ;
                form.PlayerOneDrawing.Width = Constants.PlayerBoardDrawingWidth;
                form.PlayerOneDrawing.Height = Constants.PlayerBoardDrawingHeight;
                form.PlayerOneDrawing.Left = form.game.board.cellList[this.position].x + 50;
                form.PlayerOneDrawing.Top = form.game.board.cellList[this.position].y + 10;
                form.PlayerOneDrawing.BringToFront();
            }
            else if (this == form.game.playersList[1])
            {
                form.Controls.Add(form.PlayerTwoDrawing);
                form.PlayerTwoDrawing.BackColor = Color.Red;
                form.PlayerTwoDrawing.Width = Constants.PlayerBoardDrawingWidth;
                form.PlayerTwoDrawing.Height = Constants.PlayerBoardDrawingHeight;
                form.PlayerTwoDrawing.Left = form.game.board.cellList[this.position].x + 50;
                form.PlayerTwoDrawing.Top = form.game.board.cellList[this.position].y + 60;
                form.PlayerTwoDrawing.BringToFront();
            }
        }
    }
}