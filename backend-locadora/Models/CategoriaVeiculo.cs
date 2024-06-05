using System.ComponentModel.DataAnnotations;

namespace backend_locadora.Models
{
    public class CategoriaVeiculo
    {
        [Key]
        public int IdCategoriaVeiculo { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Nome { get; set; }
    }
}