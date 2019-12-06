using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeGame.IO;
using TicTacToeGame.ApplicationStates;

namespace TicTacToeGame.ApplicationStates
{

    public abstract class MenuState : State, IMenu
    {


        public MenuState()
        {            

        }

    public override State Run(InputManager input, OutputManager output)
        {
            output.Render(this);
            output.Prompt(this);

            return this;

        }

        bool IMenu.GoBack()
        {
            throw new NotImplementedException();
        }

        bool IMenu.NavigateToSelection()
        {
            throw new NotImplementedException();
        }

        string[] IMenu.Print()
        {
            throw new NotImplementedException();
        }
    }
}

