public static class LineUp
{
    public static string Format(string name, int number)
    {
        string result = String.Empty;
        if((number%100 >= 11 && number%100 <= 13))
        {
            result += "th";
        }
        else
        {
            result += (number%10) switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
        }
        return $"{name}, you are the {number}{result} customer we serve today. Thank you!";
    }
}
