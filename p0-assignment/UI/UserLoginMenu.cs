using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CevicheBL;
using CevicheModels;
using Serilog;
using CevicheUI;

internal class UserLoginMenu : IMenu
{
    public UserLoginMenu(IBL logic)
    {
        Logic = logic;
    }

    public IBL Logic { get; }

    public void Display()
    {
        throw new NotImplementedException();
    }

    public string UserChoice()
    {
        throw new NotImplementedException();
    }
}