namespace _03_ExpenseTracker;

class Program
{
    static void Main(string[] args)
    {
        // Having one object to manage and add all the expenses to the expenses list
        var mgm = new ExpenseManager();

        var e1 = new Expense(1,"DESC",120);
        mgm.AddExpense(e1);
        
        var e2 = new Expense(2,"DESC",120);
        mgm.AddExpense(e2);
        
        var e3 = new Expense(3,"DESC",120);
        mgm.AddExpense(e3);

        var e4 = new Expense(4,"DESC",(e1.Amount + e2.Amount + e3.Amount));
        mgm.AddExpense(e4);

        mgm.FindExpenseById(4);
        mgm.FindExpenseById(5);

        mgm.ShowExpenses();
        mgm.ShowTotalExpense();
        
    
    }
}
