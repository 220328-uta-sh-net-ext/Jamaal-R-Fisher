using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Models;
using Serilog;
using UI;

namespace UI;

public class ReviewMenu : IMenu
{
    private readonly IBL _bl;
    public ReviewMenu(IBL bl)
    {
        _bl = bl;
    }

    public void Display()
    {
        throw new NotImplementedException();
    }

    public void Start() {}

    public string UserChoice()
    {
        throw new NotImplementedException();
    }
}