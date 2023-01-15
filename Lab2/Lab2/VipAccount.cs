namespace Lab2;

internal class VipAccount : DefaultAccount

{
    protected override void WinGame(Game game)
    {
        CurrentRating += Factor * game.GameRating;
    }

    protected override void LooseGame(Game game)
    {
        if (game.GameRating > CurrentRating) CurrentRating = 0;
        else CurrentRating -= game.GameRating/2;  
    }
    
    public VipAccount(string userName) : base(userName)
    {
        DefaultRating = 10;
        CurrentRating = DefaultRating;
        Factor = 2;
    }

}