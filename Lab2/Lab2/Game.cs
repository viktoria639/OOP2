namespace Lab2;

public abstract class Game
{
    public readonly DefaultAccount Winner;
    public readonly DefaultAccount Looser;
    public uint GameRating { get; set; }
    private static uint GlobalId;
    public readonly uint ID;

    protected Game(DefaultAccount winner, DefaultAccount looser)
    {
        Winner = winner;
        Looser = looser;
        ID = GlobalId++;
    }
    
}