using Microsoft.EntityFrameworkCore;

namespace FinTrack.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        [Precision(18, 2)]
        public decimal Amount { get; set; }

        public string? Description { get; set; }

        public string UserID { get; set; } = null!;


        public Transaction()
        {
            
        }

    }
}
