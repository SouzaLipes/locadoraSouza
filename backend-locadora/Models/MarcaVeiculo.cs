using System.ComponentModel.DataAnnotations;

public class MarcaVeiculo
{
    [Key]
    public int IdMarca { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }
}
