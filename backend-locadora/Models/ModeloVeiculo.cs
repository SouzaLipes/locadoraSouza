using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

public class ModeloVeiculo
{
    [Key]
    public int IdModelo { get; set; }

    [Required]
    [StringLength(50)]
    public string Nome { get; set; }

    [ForeignKey("MarcaVeiculo")]
    public int IdMarca { get; set; }

    [ForeignKey("CategoriaVeiculo")]
    public int IdCategoria { get; set; }
}
