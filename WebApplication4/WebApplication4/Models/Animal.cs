namespace WebApplication4.Models;

public class Animal
{
    private static int _id = 0;
    
    public int Id { get; private set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public double Weight { get; set; }
    public string HairColor { get; set; }

    public Animal(string name, string category, double weight, string hairColor)
    {
        Id = ++_id;
        Name = name;
        Category = category;
        Weight = weight;
        HairColor = hairColor;
    }
}