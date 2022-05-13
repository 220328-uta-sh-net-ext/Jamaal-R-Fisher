using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CevicheUI;

namespace CevicheUI;
public class MainMenu : IMenu
{
    /*
    public interface IMenu
    {
        void MainMenu();
    }
    */

    public void Display()
    {
        Console.WriteLine("Welcome to Restaurant Reviews!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("Press <2> User Login");
        Console.WriteLine("Press <1> Add new user");
        Console.WriteLine("Press <0> Exit");
    }

    public string UserChoice()
    {
        if (Console.ReadLine() is not string userInput)
            throw new InvalidDataException("end of input");

        switch (userInput)
        {
            case "0":
                return "Exit";
            case "1":
                return "AddNewUser";
            case "2":
                return "UserLogin";
            default:
                Console.WriteLine("Please input a valid response");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                return "MainMenu";
        }
    }


    /*
    public IBL _bl;
    private object? logic;

    
    public MainMenu()
    {

    }


    public MainMenu(IBL bl)
    {
        _bl = bl;
    }

    public MainMenu(object? logic)
    {
        this.logic = logic;
    }

    public void Continue()
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

    public void Start()
    {
        Console.WriteLine("Welcome to Restaurant Reviews!");
    }
    */

}
