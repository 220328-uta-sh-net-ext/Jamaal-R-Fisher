using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CevicheBL;
using CevicheModels;
using Serilog;
using CevicheUI;

namespace CevicheUI;

public class RestaurantMenu : IMenu
{
    private IBL _bl;

    public RestaurantMenu(IBL bl) 
    {
        _bl = bl;
    }

    public void Continue()
    {
        throw new NotImplementedException();
    }

    public void Display()
    {
        throw new NotImplementedException();
    }

    public void Exit()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    public string UserChoice()
    {
        throw new NotImplementedException();
    }
}