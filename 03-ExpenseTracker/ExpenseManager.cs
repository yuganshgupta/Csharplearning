using System.Collections.Generic;

namespace _03_ExpenseTracker;

class ExpenseManager
{
    private List<Expense> expenses = new List<Expense>();

    public void AddExpense(Expense expense)
    {
        expenses.Add(expense);
    }

    public void ShowExpenses()
    {
        foreach(Expense expense in expenses)
        {
            System.Console.WriteLine($"ID : {expense.Id}, " 
            + $"Description : {expense.Description},  "
            + $"Amount : {expense.Amount} "
            );
        }
    }

    public void FindExpenseById(int id)
    {
        if(id <= 0)
        {
            System.Console.WriteLine("Enter a valid id please");
            return;
        }
         foreach(Expense expense in expenses)
        {
            if(expense.Id == id)
            {
                System.Console.WriteLine($"Item with id : {expense.Id} found ");
                return;
            }
        }

        System.Console.WriteLine("Item not found");
    }

    public void ShowTotalExpense()
    {
        decimal total = 0;
         foreach(Expense expense in expenses)
        {
            total += expense.Amount;
        }
        System.Console.WriteLine($"Total expenses is : {total}");
    }
}