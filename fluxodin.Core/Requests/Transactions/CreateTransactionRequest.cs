using System.ComponentModel.DataAnnotations;
using fluxodin.Core.Enums;

namespace fluxodin.Core.Requests.Transactions;

public class CreateTransactionRequest: Request
{
    
    [Required(ErrorMessage ="Título inválido")]
    [MaxLength(80,ErrorMessage = "O título deve conter até 80 caracteres")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage ="Tipo inválido")]
    public ETransactionType Type {get;set;} = ETransactionType.Withdraw;

    [Required(ErrorMessage ="Valor inválido")]
    public decimal Amount { get; set; }

    [Required(ErrorMessage ="Categoria inválido")]
    public long CategoryId { get; set; }

    [Required(ErrorMessage ="Data inválido")]
    public DateTime? PaidOrReceviedAt { get; set; }
}
