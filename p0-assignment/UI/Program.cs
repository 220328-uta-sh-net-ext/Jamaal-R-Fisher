using BL;
using DL;
using UI;

MenuFactory.GetMenu("main").Display();

//create and configure our logger

Log.Logger = new LoggerConfiguration()
    // .WriteTo.Console().MinimumLevel.Debug()
    // .WriteTo.File("../UI/user.txt").MinimumLevel.Debug().MinimumLevel.Information()     // we want to save the logs in this file
    .CreateLogger();

// other approaches to this besides "gitignored file"...
//  - command-line arguments (in this file with top-level statements, invisible "args" variable
//  - environment variab
string connectionStringFilePath = "../../../../DL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

IRepo repository = new SqlRepo(connectionString);
IBL logic = new RRBL(repository);
RestaurantOperations operations = new(repository);

bool repeat = true;
IMenu menu = new MainMenu();

while (repeat)
{
    menu.Display();
    string ans = menu.UserChoice();

    switch (ans)
    {
        case "UserLogin":
            Log.Debug("Displaying UserLogin menu to the user");
            menu = new UserLoginMenu(logic);
            break;
        case "AddNewUser":
            Log.Debug("Displaying AddNewUser Menu to the user");
            menu = new AddNewUserMenu(logic);
            break;
        case "MainMenu":
            Log.Debug("Displaying Main menu to the user");
            menu = new MainMenu();
            break;
        case "Exit":
            Log.Debug("Exiting the application");
            Log.CloseAndFlush();
            repeat = false;
            break;
        default:
            Console.WriteLine("View does not exist");
            Console.WriteLine("Please press <enter> to continue");
            Console.ReadLine();
            break;
    }
}