using Domain.Entities;

namespace Domain.Tests;

public class PetTests
{
    [Fact]
    public void Create_Pet_Give_Model()
    {
        var entitie = new Pet("Zeus", Types.Dog, DateTime.Now, 22);
    }
}