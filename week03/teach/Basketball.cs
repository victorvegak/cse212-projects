/*
 * CSE 212 Lesson 6C 
 * 
 * This code will analyze the NBA basketball data and create a table showing
 * the players with the top 10 career points.
 * 
 * Note about columns:
 * - Player ID is in column 0
 * - Points is in column 8
 * 
 * Each row represents the player's stats for a single season with a single team.
 */

using Microsoft.VisualBasic.FileIO;

public class Basketball
{
    public static void Run()
    {
        var playerPoints = new Dictionary<string, int>();

        using var reader = new TextFieldParser("basketball.csv");
        reader.TextFieldType = FieldType.Delimited;
        reader.SetDelimiters(",");
        reader.ReadFields(); // ignore header row
        while (!reader.EndOfData) {
            var fields = reader.ReadFields();
            if (fields == null || fields.Length < 9) continue; // Ensure Format 
            string playerId = fields[0]; // Column 0: player Id 
            if(!int.TryParse(fields[8], out int points)) continue; // points 
            // Add points to player's total
            if (playerPoints.ContainsKey(playerId))
                playerPoints[playerId] += points;
            else
                playerPoints[playerId] = points;
        }
        // sort players by total points
        var topPlayers = playerPoints.OrderByDescending(p => p.Value).ToArray();

        // Display top 10 players
        Console.WriteLine("Top 10 Players by Career Points");
        Console.WriteLine("--------------------------------");
        Console.WriteLine($"{"Rank",-5} {"Player",-20} {"Points",10}");
        Console.WriteLine("--------------------------------");

        for (var i = 0; i < Math.Min(10, topPlayers.Length);++i)
        {
            Console.WriteLine($"{i+1, -5} {topPlayers[i].Key,-15} {topPlayers[i].Value,10}");
        }
    }
}