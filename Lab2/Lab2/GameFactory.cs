using System;

namespace Lab2;

public enum GameType
{
    Default,Training,DoubleRating
}

public static class GameFactory
{
    public static Game Create(GameType gameType,DefaultAccount firstPLayer,DefaultAccount secondPlayer,uint rating)
    {
        Game game = gameType switch
        {
            GameType.Default => new DefaultGame(firstPLayer, secondPlayer, rating),
            GameType.DoubleRating => new DoubleRatingGame(firstPLayer, secondPlayer, rating),
            _ => new TrainingGame(firstPLayer, secondPlayer)
        };
        return game;
    }
    
    
}