using fluxodin.Core.Enums;

namespace fluxodin.Core.Models;

public class Transaction
{
    
    public long Id { get; set; }
    public string Title { get; set; } = string.Empty;

    public DateTime CreateAt { get; set; } = DateTime.Now;
    public DateTime? PaidOrReceviedAt { get; set; }

    public ETransactionType Type {get;set;} = ETransactionType.Withdraw;

    public decimal Amout { get; set; }

    public long CategoryId { get; set; }
    public Category Category { get; set; } = null!;

    public string UserId { get; set; } = string.Empty;
}
