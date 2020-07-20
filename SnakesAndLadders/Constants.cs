using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakesAndLadders
{
    public static class Constants
    {
        static public int cellHeight = 105;
        static public int cellWidth = 127;
        public static Color cellBackgroundColor = Color.FromArgb(0, Color.Red);

        public static int BoardColumns = 6;
        public static int BoardRows = 6;

        public static int WinLabelHeight = 300;
        public static int WinLabelWidth = 600;
        public static int FinalPosition = 35;
        public static int WinLabelTop = 224;
        public static int WinLabelLeft = 315;

        public static int PlayerBoardDrawingWidth = 34;
        public static int PlayerBoardDrawingHeight = 32;

    }
}
