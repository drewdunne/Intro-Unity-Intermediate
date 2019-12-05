using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeGame.IO;

namespace TicTacToeGame.ApplicationStates
{
    public abstract class State
    {

        public virtual State Run(InputManager input, OutputManager output)
        {
            return this;
        }
    }
}
