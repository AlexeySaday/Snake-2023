namespace Snake;

public class DataBindings
{
    public string UserName { get;set; } = string.Empty;
    public int Score { get;set; }
    public int ApplesNumber { get; set; }
    public override string ToString()
    {
        return UserName + " " + Score + " " + ApplesNumber;
    }
}