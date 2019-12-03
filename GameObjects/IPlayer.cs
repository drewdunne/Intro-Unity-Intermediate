using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame
{
    public interface IPlayer
    {
        public string Name { get; set; }
        public uint Score { get; set; }

    }
}