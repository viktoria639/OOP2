namespace Lab2;

internal class DefaultGame : Game
{
    public DefaultGame(DefaultAccount winner, DefaultAccount looser, uint rating) : base(winner, looser)
    {
        GameRating = rating;
        winner.AddGame(this);
        looser.AddGame(this);
    }
}