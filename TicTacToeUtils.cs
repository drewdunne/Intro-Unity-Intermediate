using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public static class TicTacToeUtils
    {
        public static void ValidatePlayerSymbol(char playerSymbol)
        {
            if (playerSymbol != 'x' && playerSymbol != 'o')
            {
                throw new ArgumentOutOfRangeException("value", "must be set to 'x' or 'o'");
            }
        }
    }
}
