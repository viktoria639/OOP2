using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab2;

class main
{
    public static void Main()
    {
        DefaultAccount firstPlayer = new VipAccount("Zelenskiy");
        DefaultAccount secondPlayer = new WarnedAccount("Putin");
        var thirdPlayer = new DefaultAccount("Biden");
        
        var players = new List<DefaultAccount>
        {
            firstPlayer,
            secondPlayer,
            thirdPlayer
        };

        Play(players.ElementAt(0), players.ElementAt(1), GameType.Default, 10);
        Play(players.ElementAt(1), players.ElementAt(2), GameType.Default, 10);
        Play(players.ElementAt(2), players.ElementAt(0), GameType.Default, 10);

        Play(players.ElementAt(0), players.ElementAt(1), GameType.Training, 0);
        Play(players.ElementAt(1), players.ElementAt(2), GameType.Training, 0);
        Play(players.ElementAt(2), players.ElementAt(0), GameType.Training, 0);

        Play(players.ElementAt(0), players.ElementAt(1), GameType.DoubleRating, 10);
        Play(players.ElementAt(1), players.ElementAt(2), GameType.DoubleRating, 10);
        Play(players.ElementAt(2), players.ElementAt(0), GameType.DoubleRating, 10);

        firstPlayer.GetStats();
        secondPlayer.GetStats();
        thirdPlayer.GetStats();
        Console.WriteLine();
    }

    private static void Play(DefaultAccount firstPlayer,DefaultAccount secondPlayer,GameType gameType,uint rating)
    {
        GameFactory.Create(gameType, firstPlayer, secondPlayer, rating);
    }
}