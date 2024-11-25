using System;
using System.Diagnostics.CodeAnalysis;
using System.Dynamic;
using System.Reflection.Metadata;
using System.Xml.Schema;

public class Darts
{
    public static void Main()
    {
        int[,] team1Score = new int[4, 3];
        int[,] team2Score = new int[4, 3];
        int[,] team3Score = new int[4, 3];

        int playerPerTeam = 4;
        int roundsPerPlayer = 3;

        Console.WriteLine("First team results");
        FillScores(team1Score, playerPerTeam, roundsPerPlayer);
        DisplayScores(team1Score, playerPerTeam, roundsPerPlayer);
        var team1BestScore = CalculateTeamWinner(team1Score, playerPerTeam, roundsPerPlayer);

        Console.WriteLine("Second team results");
        FillScores(team2Score, playerPerTeam, roundsPerPlayer);
        DisplayScores(team2Score, playerPerTeam, roundsPerPlayer);
        var team2BestScore = CalculateTeamWinner(team2Score, playerPerTeam, roundsPerPlayer);

        Console.WriteLine("Third team results");
        FillScores(team3Score, playerPerTeam, roundsPerPlayer);
        DisplayScores(team3Score, playerPerTeam, roundsPerPlayer);
        var team3BestScore = CalculateTeamWinner(team3Score, playerPerTeam, roundsPerPlayer);

        var higestScore = team1BestScore;
        var winningTeam = 1;

        if (team2BestScore > higestScore)
        {
            higestScore = team2BestScore;
            winningTeam = 2;
        }
        if (team3BestScore > higestScore)
        {
            higestScore = team3BestScore;
            winningTeam = 3;
        }

        Console.WriteLine($"The best  result was shown the player of team {winningTeam}, with a score {higestScore}");

    }

    static void FillScores(int[,] scores, int players, int rounds)
    {
        var random = new Random();
        for (int i = 0; i < players; i++)
        {
            for (int j = 0; j < rounds; j++)
            {
                scores[i, j] = random.Next(60);
            }
        }
    }
    static void DisplayScores(int[,] scores, int players, int rounds)
    {
        for (int i = 0; i < players; i++)
        {
            for (int j = 0; j < rounds; j++)
            {
                Console.WriteLine(scores[i, j] + " ");
            }
            Console.WriteLine();
        }
    }


    static int CalculateTeamWinner(int[,] scores, int players, int rounds)
    {
        int[] totalScores = new int[players];
        for (int i = 0; i < players; i++)
        {
            int playerScore = 0;
            for (int j = 0; j < rounds; j++)
            {
                playerScore += scores[i, j];
            }
            totalScores[i] = playerScore;
            Console.WriteLine($"Total score of player{i + 1}={playerScore}");

        }

        int higestPlayerScore = totalScores[0];
        int bestPlayerIndex = 0;
        for (int i = 0; i < players; i++)
        {
            if (totalScores[i] > higestPlayerScore)
            {
                higestPlayerScore = totalScores[i];
                bestPlayerIndex = i;
            }
        }
        Console.WriteLine($"The winner is player number {bestPlayerIndex + 1} with score of {higestPlayerScore}");
        Console.WriteLine($"The winner is player number {bestPlayerIndex + 1} with score of {higestPlayerScore}");

        return higestPlayerScore;

    }

}



