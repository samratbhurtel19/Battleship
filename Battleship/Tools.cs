using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public static class  Tools
    {
        #region Generic Tools

        private static Random random = new Random();
        public static int RandomInt(int min, int max)
        {
            return random.Next(min, max);
        }
        #endregion
    }
}
