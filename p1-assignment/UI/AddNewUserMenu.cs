﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CevicheBL;
using CevicheModels;
using Serilog;
using CevicheUI;

namespace CevicheUI
{
    class AddNewUserMenu : IMenu
    {
        //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddNewUser
        static readonly User newlyAddedUser = new();

        readonly IBL logic;

        public AddNewUserMenu(IBL logic)
        {
            this.logic = logic;
        }

        public void Display()
        {
            Console.WriteLine("Enter User Name, Password, and Zip Code");
            Console.WriteLine("<4> User Name - " + newlyAddedUser.Username);
            Console.WriteLine("<3> Password - " + newlyAddedUser.Password);
            Console.WriteLine("<2> Zip Code - " + newlyAddedUser.Zipcode);
            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }

        public string UserChoice()
        {
            // Console.ReadLine returns null if redirecting from a file and the file ends
            if (Console.ReadLine() is not string userInput)
                throw new InvalidDataException("end of input");
            switch (userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    try
                    {
                        Log.Information("Adding user - " + newlyAddedUser.Username);
                        logic.AddNewUser(newlyAddedUser);
                        Log.Information("User added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add new user");
                        Console.WriteLine(ex.Message);

                    }
                    return "MainMenu";
                case "2":
                    Console.Write("Please enter your zip code. ");
                    newlyAddedUser.Zipcode = Console.ReadLine() is string input3 ? input3 :
                        throw new InvalidDataException("end of input");
                    return "AddNewUser";
                case "3":
                    Console.Write("Please enter your password. ");
                    newlyAddedUser.Password = Console.ReadLine() is string input2 ? input2 :
                        throw new InvalidDataException("end of input");
                    return "AddNewUser";
                case "4":
                    Console.Write("Please enter your user name. ");
                    newlyAddedUser.Username = Console.ReadLine() is string input ? input :
                        throw new InvalidDataException("end of input");
                    return "AddNewUser";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    return "AddNewUser";
            }
        }
    }
}
