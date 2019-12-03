using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public class BoardEvaluator
    {
        private Board _boardToEvaluate;

        public BoardEvaluator(Board boardToEvaluate)
        {
            _boardToEvaluate = boardToEvaluate;
        }

        public bool IsWinner(char playerSymbol)
        {
            TicTacToeUtils.ValidatePlayerSymbol(playerSymbol);

            foreach (var condition in WIN_CONDITIONS)
            {
                if (EvaluateWinCondition(playerSymbol, condition))
                {
                    return true;
                }
            }

            return false;
        }

        private bool EvaluateWinCondition(char playerSymbol, byte[,] condition)
        {
            for (int row = 0; row < Board.BOARD_HEIGHT; ++row)
            {
                for (int col = 0; col < Board.BOARD_WIDTH; ++col)
                {
                    if (_boardToEvaluate.BoardState[row, col] != playerSymbol && condition[row, col] == 1)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        private static readonly byte[][,] WIN_CONDITIONS = new byte[][,]
       {
            new byte[,] {
                {1, 1, 1},
                {0, 0, 0},
                {0, 0, 0}
            },
            new byte[,] {
                {0, 0, 0},
                {1, 1, 1},
                {0, 0, 0}
            },
            new byte[,] {
                {0, 0, 0},
                {0, 0, 0},
                {1, 1, 1},
            },
            new byte[,] {
                {1, 0, 0},
                {1, 0, 0},
                {1, 0, 0}
            },
            new byte[,] {
                {0, 1, 0},
                {0, 1, 0},
                {0, 1, 0}
            },
            new byte[,] {
                {0, 0, 1},
                {0, 0, 1},
                {0, 0, 1}
            },
            new byte[,] {
                {1, 0, 0},
                {0, 1, 0},
                {0, 0, 1}
            },
            new byte[,] {
                {0, 0, 1},
                {0, 1, 0},
                {1, 0, 0}
            },
       };
    }
}
