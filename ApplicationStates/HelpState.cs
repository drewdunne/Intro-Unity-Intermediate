using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame.GameStates
{
    class HelpState : IApplicationState
    {
        public HelpState()
        {

        }

        public IApplicationState Run(InputManager input, OutputManager output)
        {
            return this;
        }
    }
}
