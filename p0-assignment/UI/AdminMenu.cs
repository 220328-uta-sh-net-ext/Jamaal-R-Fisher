﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using Models;
using Serilog;
using UI;

namespace UI;
public class AdminMenu : IAdminMenu
{
    public IBL _bl;

    /*
    public AdminMenu(object? logic)
    {
    }
    

    internal class AdminMenu : IAdminMenu
    {
        private object? logic;

        public AdminMenu(object? logic)
        {
            this.logic = logic;
        }
    }
    
    public MainMenu()
    {

    }
    

    public MainMenu(IBL bl)
    {
        _bl = bl;
    }

    

    public void Continue()
    {
        throw new NotImplementedException();
    }
    */

    public void Display()
    {
        Console.WriteLine("Welcome admin!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("Press <2> Search Restaurants");
        Console.WriteLine("Press <1> Search Users");
        Console.WriteLine("Press <0> Exit");
    }

    /*
    public void Exit()
    {
        throw new NotImplementedException();
    }

    public void Start()
    {
        throw new NotImplementedException();
    }

    /*
    public void Start()
    {
        Console.WriteLine("Welcome to Restaurant Reviews!");
    }
    */

    public string UserChoice()
    {
        if (Console.ReadLine() is not string userInput)
            throw new InvalidDataException("end of input");

        switch (userInput)
        {
            case "0":
                return "Exit";
            case "1":
                return "GetUsers";
            case "2":
                return "GetRestaurants";
            default:
                Console.WriteLine("Please input a valid response");
                Console.WriteLine("Please press <enter> to continue");
                Console.ReadLine();
                return "MainMenu";
        }
    }
}
