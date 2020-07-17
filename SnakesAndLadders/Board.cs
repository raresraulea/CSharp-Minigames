using System;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace SnakesAndLadders
{
    public class Board
    {
        public List<Cell> cellList = new List<Cell>();
        Label startPlayerOneLabel;
        Label startPlayerTwoLabel;
        public Board()
        {
            GenerateBoard();
        }

        private void GenerateBoard()
        {
            int X = 22;
            int Y = 600;


            for(int i = 0; i < Constants.BoardRows; i++, Y-=Constants.cellHeight + 3)
            {
                for (int j = 0; j < Constants.BoardColumns; j++)
                {
                    Cell cell = new Cell();
                    cell.x = X;
                    cell.y = Y;
                    cellList.Add(cell);
                    if (i % 2 == 0 && j != 5) X += Constants.cellWidth + 6;
                    else if(i%2 != 0 && j!= 5) X -= Constants.cellWidth + 6;
                }
                
            }
            var startingX = cellList[0].x;
            var startingY = cellList[0].x;

            
            
            //cellList.Add(new Cell() { x = 22, y = 600 });
            //cellList.Add(new Cell() { x = 22 + Constants.cellWidth + 5, y = 600 });
        }

        public void Show(SLGame form)
        {
            
            foreach (Cell cell in cellList)
                cell.Show(form);
            form.Refresh();
        }
    }
}