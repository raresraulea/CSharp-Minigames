using System;
using System.Drawing;
using System.Windows.Forms;

namespace SnakesAndLadders
{
    public class Cell
    {
        public int x, y;
        public Panel mainPanel;

        //public Label playerOneLabel = new Label();
        //public Label playerTwoLabel = new Label();

        internal void Show(SLGame form)
        {
            mainPanel = generateMainPanel();
            form.Controls.Add(mainPanel);
            //mainPanel.SendToBack();
            //form.Controls.SetChildIndex(mainPanel, 1);
        }

        private Panel generateMainPanel()
        {
            Panel mainPanel = new Panel
            {
                BorderStyle = BorderStyle.Fixed3D,
                Left = this.x,
                Top = this.y,
                Height = Constants.cellHeight,
                Width = Constants.cellWidth,
            };

            
            return mainPanel;

        }

        public static implicit operator int(Cell v)
        {
            throw new NotImplementedException();
        }

        internal void HideAndUpdatePlayer(SLGame sLGame)
        {
            throw new NotImplementedException();
        }

        internal void ShowPlayer(SLGame sLGame)
        {
            throw new NotImplementedException();
        }
    }
}