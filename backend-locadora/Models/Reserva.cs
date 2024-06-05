using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class Reserva
{
    [Key]
    public int IdReserva { get; set; }

    [Required]
    public DateTime DataInicio { get; set; }

    [Required]
    public DateTime DataFim { get; set; }

    [ForeignKey("Cliente")]
    public int IdCliente { get; set; }

    [ForeignKey("Veiculo")]
    public int IdVeiculo { get; set; }

    [Required]
    public decimal ValorTotal { get; set; }
}
