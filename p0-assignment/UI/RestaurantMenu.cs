using System;
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
    public class RestaurantMenu : IRestaurantMenu
    {
        /*
        private IBL _bl;

        public RestaurantMenu(IBL bl) 
        {
            _bl = bl;
        }
        */

        static readonly Restaurant newlyAddedRestaurant = new();

        readonly IBL logic2;

        public RestaurantMenu(IBL logic2)
        {
            this.logic2 = logic2;
        }

        public void Display()
        {
            Console.WriteLine("Enter Restaurant Name, Zip Code, your Rating of the Restaurant and a brief Review of your experience.");
            Console.WriteLine("<5> Name - " + newlyAddedRestaurant.Name);
            Console.WriteLine("<4> Zip Code - " + newlyAddedRestaurant.Zipcode);
            Console.WriteLine("<3> Rating - " + newlyAddedRestaurant.Rating);
            Console.WriteLine("<2> User Review - " + newlyAddedRestaurant.UserReview);
            Console.WriteLine("<1> Save");
            Console.WriteLine("<0> Go Back");
        }

        public string UserChoice()
        {
            // Console.ReadLine returns null if redirecting from a file and the file ends
            if (Console.ReadLine() is not string userInput2)
                throw new InvalidDataException("end of input");
            switch (userInput2)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    try
                    {
                        Log.Information("Adding restaurant - " + newlyAddedRestaurant.Name);
                        logic2.AddNewRestaurant(newlyAddedRestaurant);
                        Log.Information("User added successfully");
                    }
                    catch (Exception ex)
                    {
                        Log.Warning("failed to add new user");
                        Console.WriteLine(ex.Message);
                    }
                    return "MainMenu";
                case "2":
                    Console.Write("Please type a brief review of your experience at the restaurant. ");
                    newlyAddedRestaurant.UserReview = Console.ReadLine() is string input4 ? input4 :
                        throw new InvalidDataException("end of input");
                    return "AddNewRestaurant";
                case "3":
                    Console.Write("Please enter your rating of this restaurant. ");
                    newlyAddedRestaurant.Rating = Console.ReadLine() is double input3 ? input3 :
                        throw new InvalidDataException("end of input");
                    return "AddNewRestaurant";
                case "4":
                    Console.Write("Please enter the restaurant's zip code. ");
                    newlyAddedRestaurant.Zipcode = Console.ReadLine() is string input2 ? input2 :
                        throw new InvalidDataException("end of input");
                    return "AddNewRestaurant";
                case "5":
                    Console.Write("Please enter the restaurant name. ");
                    newlyAddedRestaurant.Name = Console.ReadLine() is string input ? input :
                        throw new InvalidDataException("end of input");
                    return "AddNewRestaurant";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    return "AddNewRestaurant";
            }
        }

        /*
        class AddNewRestaurant : IRestaurantMenu
        {
            //static non-access modifier is needed to keep this variable consistent to all objects we create out of our AddNewUser
            static readonly Restaurant newlyAddedRestaurant = new();

            readonly IBL logic;

            public AddNewRestaurant(IBL logic)
            {
                this.logic = logic;
            }

            public void Display()
            {
                Console.WriteLine("Enter Restaurant Name, Zip Code, your Rating of the Restaurant and a brief Review of your experience.");
                Console.WriteLine("<5> Name - " + newlyAddedRestaurant.Name);
                Console.WriteLine("<4> Zip Code - " + newlyAddedRestaurant.Zipcode);
                Console.WriteLine("<3> Rating - " + newlyAddedRestaurant.Rating);
                Console.WriteLine("<2> User Review - " + newlyAddedRestaurant.UserReview);
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
                            Log.Information("Adding user - " + newlyAddedRestaurant.Name);
                            logic.AddNewUser(newlyAddedRestaurant);
                            Log.Information("User added successfully");
                        }
                        catch (Exception ex)
                        {
                            Log.Warning("failed to add new user");
                            Console.WriteLine(ex.Message);

                        }
                        return "MainMenu";
                    case "2":
                        Console.Write("Please type a brief review of your experience at the restaurant. ");
                        newlyAddedRestaurant.UserReview = Console.ReadLine() is string input3 ? input3 :
                            throw new InvalidDataException("end of input");
                        return "AddNewRestaurant";
                    case "3":
                        Console.Write("Please enter your rating of this restaurant. ");
                        newlyAddedRestaurant.Rating = Console.ReadLine() is string input2 ? input2 :
                            throw new InvalidDataException("end of input");
                        return "AddNewRestaurant";
                    case "4":
                        Console.Write("Please enter the restaurant's zip code. ");
                        newlyAddedRestaurant.Zipcode = Console.ReadLine() is string input ? input :
                            throw new InvalidDataException("end of input");
                        return "AddNewRestaurant";
                    case "5":
                        Console.Write("Please enter the restaurant name. ");
                        newlyAddedRestaurant.Name = Console.ReadLine() is string input ? input :
                            throw new InvalidDataException("end of input");
                        return "AddNewRestaurant";
                    default:
                        Console.WriteLine("Please input a valid response");
                        Console.WriteLine("Please press Enter to continue");
                        return "AddNewRestaurant";
                }
            }
        }

        /*
        public void Display()
        {
            throw new NotImplementedException();
        }
        public string UserChoice()
        {
            throw new NotImplementedException();
        }
        */

        /*
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
        */
    }
}