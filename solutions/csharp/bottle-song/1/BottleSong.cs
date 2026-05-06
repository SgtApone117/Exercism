using System;
using System.Collections.Generic;

public enum Numericals
{
    No,
    One,
    Two,
    Three,
    Four,
    Five,
    Six,
    Seven,
    Eight,
    Nine,
    Ten
}

public static class BottleSong
{
    public static IEnumerable<string> Recite(int startBottles, int takeDown)
    {
        var result = new List<string>();

        while (takeDown > 0)
        {
            string currentBottleWord = ((Numericals)startBottles).ToString();
            string nextBottleWord = ((Numericals)(startBottles - 1)).ToString().ToLower();

            string currentPlural = startBottles == 1 ? "bottle" : "bottles";
            string nextPlural = (startBottles - 1) == 1 ? "bottle" : "bottles";

            result.Add($"{currentBottleWord} green {currentPlural} hanging on the wall,");
            result.Add($"{currentBottleWord} green {currentPlural} hanging on the wall,");
            result.Add("And if one green bottle should accidentally fall,");
            result.Add($"There'll be {nextBottleWord} green {nextPlural} hanging on the wall.");
            if (takeDown > 1)
                result.Add("");

            takeDown--;
            startBottles--;
        }

        return result;
    }
}
