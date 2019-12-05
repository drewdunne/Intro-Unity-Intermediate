using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeGame.IO;
using TicTacToeGame.ApplicationStates;

namespace TicTacToeGame
{
    class Application
    {
        InputManager inputManager = new InputManager();
        OutputManager outputManager = new OutputManager();

        public void Run()
        {
            State currentState = new MenuState(MenuState.MenuID.MainMenu);

            do
            {
                currentState = currentState.Run(inputManager, outputManager);

            } while (currentState != null);
        }
    }
}
