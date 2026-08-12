using System.ComponentModel.DataAnnotations;
namespace ApiProdutos.DTOs;
public class AtualizarProdutoDto
{
    [Required]
    [StringLength(100, MinimumLength = 3)]
    public string Nome { get; set; } = string.Empty;
    [StringLength(500)]
    public string Descricao { get; set; } = string.Empty;
    [Range(0.01, 999999.99)]
    public decimal Preco { get; set; }
    [Range(0, int.MaxValue)]
    public int QuantidadeEstoque { get; set; }
    public bool Ativo { get; set; }
}