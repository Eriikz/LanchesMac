using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LanchesMac.Models
{
    [Table("Lanche")]
    public class Lanche
    {
        public int LancheId { get; set; }

        [Required(ErrorMessage = "Nome lanche obrigatorio")]
        [Display(Name ="Nome do lanche")]
        [StringLength(80, MinimumLength = 10, ErrorMessage = "Minimo {1} e Maximo {2}")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "DescricaoCurta obrigatorio")]
        [Display(Name = "Descirção do lanche")]
        [MinLength(20, ErrorMessage = "Minimo {1}")]
        [MaxLength(200, ErrorMessage = "Minimo {1}")]
        public string? DescricaoCurta { get; set; }

        [Required(ErrorMessage = "DescricaoDetalhada obrigatorio")]
        [Display(Name = "Descirção Detalhada do lanche")]
        [MinLength(40, ErrorMessage = "Minimo {1}")]
        [MaxLength(400, ErrorMessage = "Minimo {1}")]
        public string? DescricaoDetalhada { get; set; }

        [Display(Name = "Preço")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1,999.99, ErrorMessage = "entre 1 e 999.99")]
        public decimal Preco { get; set; }

        [Display(Name = "Caminho da Imagem")]
        [StringLength(200, ErrorMessage =  "o {0} deve ter maximo {1}")]
        public string? ImagemUrl { get; set; }

        [Display(Name = "Caminho da mini Imagem")]
        [StringLength(200, ErrorMessage = "o {0} deve ter maximo {1}")]
        public string? ImagemUrlThumnailUrl { get; set; }

        [Display(Name = "Preferido")]
        public bool IsLanchePreferido { get; set; }

        [Display(Name = "Estoque")]
        public bool EmEstoque { get; set; }

        public int CategoriaId { get; set; }
        public virtual Categoria? Categoria { get; set; }

    }
}
