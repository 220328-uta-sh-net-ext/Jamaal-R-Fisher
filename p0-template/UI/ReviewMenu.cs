namespace UI;

public class ReviewMenu : IMenu
{
    private readonly IBL _bl;
    public ReviewMenu(IBL bl)
    {
        _bl = bl;
    }
    public void Start() {}

}