using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ApiCatalogo.Models
{
    [Table("Produtos")]
    public class Produto
    {
        public int ProdutoId { get; set; }

        [Required(ErrorMessage ="Nome é obrigatório")]
        [StringLength(100)]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Descrição é obrigatório")]
        [StringLength(200)]
        public string? Descricao { get; set; }

        [Required(ErrorMessage = "Preço é obrigatório")]
        [Column(TypeName="decimal(10,2)")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Imagem é obrigatório")]
        [StringLength(300)]
        public string? ImagemUrl { get; set; }
        public float Estoque { get; set; }
        public DateTime DataCadastro { get; set; }

        // Definindo relacionamento entre as tabelas
        public int CategoriaId { get; set; }

        [JsonIgnore]
        public Categoria? Categoria { get; set; }
    }
}
