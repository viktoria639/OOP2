namespace Lab2;

class DoubleRatingGame : DefaultGame
{
    public DoubleRatingGame(DefaultAccount winner, DefaultAccount looser, uint rating) : base(winner, looser,2*rating)
    {
    }
}