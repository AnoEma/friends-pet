using Domain.Entities;

namespace Domain.Tests;

public class CustomerTests
{
    [Fact]
    public void Create_Customer_Give_Model()
    {
        var entitie = new Customers
            (
            "Ano",
            "Emangi",
            "arnoe@outlook.com",
            "1234567890",
              new Pet("Zeus", Types.Dog, DateTime.Now, 22)
            );
    }
}