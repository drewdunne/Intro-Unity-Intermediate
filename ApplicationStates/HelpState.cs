using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeGame.IO;

namespace TicTacToeGame.GameStates
{
    class HelpState : ApplicationState
    {
        ApplicationState _currentState;

        public HelpState()
        {


        }

        public override ApplicationState Run(InputManager input, OutputManager output)
        {
            return _currentState;
        }
    }
}
