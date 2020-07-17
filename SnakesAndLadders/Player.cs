using System;
using System.Drawing;

namespace SnakesAndLadders
{
    public class Player
    {
        private string name;
        public int position;
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
    }
}