using Microsoft.AspNetCore.Identity;


namespace BalanceCheck.Models
{
    public class AppUser:IdentityUser
    {
    
        public List<Income> Incomes { get; set; }

        public List<Expense> Expenses { get; set; }

    }
}
