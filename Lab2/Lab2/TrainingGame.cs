namespace Lab2;

internal class TrainingGame : Game
{
    public TrainingGame(DefaultAccount winner, DefaultAccount looser) : base(winner, looser)
    {
        winner.AddGame(this);
        looser.AddGame(this);
    }
}