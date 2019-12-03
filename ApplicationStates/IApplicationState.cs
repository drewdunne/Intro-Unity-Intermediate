using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeGame.IO;

namespace TicTacToeGame
{
    public interface IApplicationState
    {
        InputManager input = new InputManager();
        OutputManager output = new OutputManager();

        public IApplicationState Run(input, output);
    }
}
