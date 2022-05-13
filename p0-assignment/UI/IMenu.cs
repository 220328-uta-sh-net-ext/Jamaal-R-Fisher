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

public interface IMenu
{

    //Interface members are implicitely public and abstract
    // void Start();

    /// <summary>
    /// Will display the menu and user choices in the terminal
    /// </summary>
    /// 

    void Display();

    /// <summary>
    /// Will record the user's choice and change/route your menu based on that choice
    /// </summary>
    /// <returns>Return the menu that will change your screen</returns>
    string UserChoice();
    // void Exit();
    // void Continue();

}
interface IAdminMenu
{

    //Interface members are implicitely public and abstract
    // void Start();

    /// <summary>
    /// Will display the menu and user choices in the terminal
    /// </summary>
    /// 

    void Display();

    /// <summary>
    /// Will record the user's choice and change/route your menu based on that choice
    /// </summary>
    /// <returns>Return the menu that will change your screen</returns>
    string UserChoice();
    // void Exit();
    // void Continue();
}