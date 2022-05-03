namespace UI;
public class MainMenu : IMenu
{
    public IBL _bl;

    public MainMenu()
    {
    }

    public MainMenu(IBL bl)
    {
        _bl = bl;
    }

    public void Display()
    {
        Console.WriteLine("Welcome to Restaurant Reviews!");
        Console.WriteLine("What would you like to do?");
        Console.WriteLine("Press <2> User Login");
        Console.WriteLine("Press <1> Add new user");
        Console.WriteLine("Press <0> Exit");
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
}
