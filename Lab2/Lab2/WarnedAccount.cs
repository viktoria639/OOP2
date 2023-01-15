namespace Lab2;

class WarnedAccount : DefaultAccount
{
    protected override void WinGame(Game game)
    {
        CurrentRating += Factor * game.GameRating;
    }

    protected override void LooseGame(Game game)
    {
        if (game.GameRating > CurrentRating) CurrentRating = 0;
        else CurrentRating -= (game.GameRating*2);  
    }
    
    public WarnedAccount(string userName) : base(userName)
    {
        DefaultRating = 1;
        CurrentRating = DefaultRating;
        Factor = 0.5;
    }
}