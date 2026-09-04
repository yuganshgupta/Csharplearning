class Expense
{
    public int Id { get; set; }
    public string Description { get; set; } = "";
    public decimal Amount { get; set; }

    public Expense(int id, string description, decimal amount)
    {
        Id = id;
        Description = description;
        Amount = amount;
    }
}