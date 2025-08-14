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
    private readonly int _allergicScore;
    public Allergies(int mask) => _allergicScore = mask;

    public bool IsAllergicTo(Allergen allergen) => (_allergicScore & (int)allergen) != 0;

    public Allergen[] List() =>
        Enum.GetValues(typeof(Allergen))
        .Cast<Allergen>()
        .Where(IsAllergicTo)
        .ToArray();
}