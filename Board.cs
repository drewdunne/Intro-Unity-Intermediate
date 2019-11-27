using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class Board
    {
        // Create, Clear, Print, Mark Cells
        public const int BOARD_WIDTH = 3;
        public const int BOARD_HEIGHT = 3;

        public void SetCell(int row, int col, char value)
        {
            TicTacToeUtils.ValidatePlayerSymbol(value);

            _boardState[row, col] = value;
        }

        public char?[,] BoardState {
            get {
                var copy = new char?[3, 3];
                for (int row = 0; row < 3; ++row)
                {
                    for (int col = 0; col < 3; ++row)
                    {
                        copy[row, col] = _boardState[row, col];
                    }
                }

                return copy;
            }
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        private readonly char?[,] _boardState = new char?[3, 3];
    }
}