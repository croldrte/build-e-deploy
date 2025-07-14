using System.ComponentModel.DataAnnotations;

namespace CasaMateriaisConstrucao.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public required string Nome { get; set; }

        public string? Descricao { get; set; }

        public string? UrlImagem { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Preco { get; set; }

        public string? Unidade { get; set; }

        public required string Categoria { get; set; }

        public string? Marca { get; set; }

        public int Estoque { get; set; }

        [Range(0, 5)]
        public double Avaliacao { get; set; }

        public DateTime DataCriacao { get; set; } = DateTime.UtcNow;

        public DateTime? DataModificacao { get; set; }

        public DateTime? DataExclusao { get; set; }
    }
}