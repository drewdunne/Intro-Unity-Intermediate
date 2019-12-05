using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToeGame.ApplicationStates
{
    public interface IMenu
    {
        string[] Print();
        bool NavigateToSelection();
        bool GoBack();

    }
}
