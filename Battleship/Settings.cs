using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Battleship
{
    public static class Settings
    {
        #region Global Variables and Constants
        public static int SIZE = 30;
        public static int LOCATION = 35;
        public static int turnsTaken = 0;
        public static Label[,] lbls = new Label[11,11];
        #endregion
    }
}
