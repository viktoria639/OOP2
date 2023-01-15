using System;
using System.Collections.Generic;

namespace Lab2;

public class DefaultAccount
{
    private string UserName { get; }
    protected double CurrentRating { get; set; }
    readonly List<Game> GamesHistory = new();
    int GamesCount => GamesHistory.Count;
    protected double Factor { get; set; }

    protected int DefaultRating { get; set; }
    public DefaultAccount(string userName)
    {
        UserName = userName;
        DefaultRating = 5;
        CurrentRating = DefaultRating;
        Factor = 1;
    }

    public void AddGame(Game game)
    {
        if (game.Looser.Equals(this))
        {
            LooseGame(game);
        }
        else
        {
            WinGame(game);
        }
        GamesHistory.Add(game);
    }

    protected virtual void WinGame(Game game)
    {
        CurrentRating += game.GameRating;
    }

    protected virtual void LooseGame(Game game)
    {
        if (game.GameRating > CurrentRating) CurrentRating = 0;
        else CurrentRating -= game.GameRating;
    }


    public void GetStats()
    {
        Console.WriteLine(UserName + "`s account type: " + GetType().Name  + " (rating at the beginning: " + DefaultRating + ", rating factor : " + Factor + ")");
        foreach (Game game in GamesHistory)
        {
            Console.Write("Winner: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(game.Winner.UserName +  "\n");
            Console.ResetColor();
            Console.Write("Looser: ");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(game.Looser.UserName +  "\n");
            Console.ResetColor();
            Console.WriteLine("Rating - " + game.GameRating + "\tNumber of game - " + (game.ID+1) + "\tGame type - " + game.GetType().Name);
        }
        Console.WriteLine("\nGames played: " + GamesCount);
        Console.WriteLine("Rating: " + UserName + ": " + CurrentRating + "\n" );
    }
}