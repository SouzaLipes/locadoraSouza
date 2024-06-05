using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Pagamento
{
    [Key]
    public int IdPagamento { get; set; }

    [ForeignKey("Reserva")]
    public int IdReserva { get; set; }

    [Required]
    public DateTime DataPagamento { get; set; }

    [Required]
    public decimal Valor { get; set; }

    [Required]
    [StringLength(50)]
    public string MetodoPagamento { get; set; }
}
