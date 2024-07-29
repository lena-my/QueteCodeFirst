namespace QueteCodeFirst.Models;

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;
    public List<SavingAccount> SavingAccounts { get; set; } = new List<SavingAccount>();
}