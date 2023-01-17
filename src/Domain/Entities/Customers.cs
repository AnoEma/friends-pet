namespace Domain.Entities;
public class Customers
{
    public Customers(string fistName, string lastName, string email, string phoneNumber, Pet pets)
    {
        FistName = fistName;
        LastName = lastName;
        Email = email;
        PhoneNumber = phoneNumber;
        Pets = pets;
    }

    public int Id { get; set; }
    public string FistName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public Pet Pets { get; set; }
}