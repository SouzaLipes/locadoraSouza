using System.ComponentModel.DataAnnotations;

public class Cliente
{
    [Key]
    public int IdCliente { get; set; }

    [Required]
    [StringLength(100)]
    public string Nome { get; set; }

    [Required]
    [StringLength(11)]
    public string Cpf { get; set; }

    [StringLength(255)]
    public string Endereco { get; set; }

    [StringLength(15)]
    public string Telefone { get; set; }

    [StringLength(100)]
    public string Email { get; set; }
}
