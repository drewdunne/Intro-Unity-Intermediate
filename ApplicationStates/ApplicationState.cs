using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeGame.IO;

namespace TicTacToeGame
{
    public abstract class ApplicationState
    {
        protected InputManager input = new InputManager();
        protected OutputManager output = new OutputManager();
        private ApplicationState _currentState;

        public virtual ApplicationState Run(InputManager input, OutputManager output)
        {
            return _currentState;
        }
    }
}
