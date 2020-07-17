using System;
using System.Collections.Generic;

namespace SnakesAndLadders
{
    public class SnakesAndLaddersGame
    {
        public Board board = new Board();
        public Dice dice = new Dice();
        public List<Player> playersList = new List<Player>();
        public SLGame form;

        internal void Start(SLGame displayForm)
        {
            this.form = displayForm;

            Player p1 = new Player(displayForm.PlayerOneGameLabel.Text);
            Player p2 = new Player(displayForm.PlayerTwoGameLabel.Text);
            this.playersList.Add(p1);
            this.playersList.Add(p2);


            board.Show(this.form);

        }
    }
}