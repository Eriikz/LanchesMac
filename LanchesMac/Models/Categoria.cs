using System.ComponentModel.DataAnnotations;

namespace LanchesMac.Models
{
    public class Categoria
    {
        [Key]
        public int CategoriaId { get; set; }
        [StringLength(100, ErrorMessage ="Maximo 100")]
        [Required(ErrorMessage = "Obrigatorio ErrorMessage")]
        [Display(Name = "Categoria")]
        public string? CategoriaNome { get; set; }

        [StringLength(200, ErrorMessage = "Maximo 200")]
        [Required(ErrorMessage = "Obrigatorio Descricao")]
        [Display(Name = "Descriçao")]
        public string? Descricao { get; set; }

        public List<Lanche>? Lanches { get; set;}
    }
}
