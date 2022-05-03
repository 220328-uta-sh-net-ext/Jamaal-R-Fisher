using UI;

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