public static class LineUp
{
    public static string Format(string name, int number)
    {
        var result = "";
        if((number >= 11 && number <= 20) || (number%100 >= 11 && number%100 <= 20))
        {
            result += "th";
        }
        else
        {
            if(number%10 == 1)
            {
                result += "st";
            }
            else if(number%10 == 2)
            {
                result += "nd";
            }
            else if(number%10 == 3)
            {
                result += "rd";
            }
            else
            {
                result += "th";
            }
        }
        return $"{name}, you are the {number}{result} customer we serve today. Thank you!";
    }
}
