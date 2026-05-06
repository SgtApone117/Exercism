public enum Allergen
{
    Eggs = 1,
    Peanuts = 2,
    Shellfish = 4,
    Strawberries = 8, 
    Tomatoes = 16,
    Chocolate = 32,
    Pollen = 64,
    Cats = 128
}

public class Allergies
{
    private int _allergicScore;
    public Allergies(int mask)
    {
        _allergicScore = mask;
    }

    public bool IsAllergicTo(Allergen allergen){
        return (_allergicScore & (int)allergen) != 0;
    }

    public Allergen[] List()
    {
        var result = new List<Allergen>();
        foreach(Allergen allergen in Enum.GetValues(typeof(Allergen)))
        {
            if(IsAllergicTo(allergen))
            {
                result.Add(allergen);
            }
        }
        return result.ToArray();
    }
}