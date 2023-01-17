namespace Domain.Entities;

public class Pet
{
    public Pet(string name, Types types, DateTime birthday, int weight)
    {
        Name = name;
        Types = types;
        Birthday = birthday;
        Weight = weight;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public Types Types { get; set; }
    public DateTime Birthday { get; set; }
    public int Weight { get; set; }
}