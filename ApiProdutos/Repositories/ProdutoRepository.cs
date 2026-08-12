using ApiProdutos.Models;
namespace ApiProdutos.Repositories;
public class ProdutoRepository
{
    private readonly List<Produto> _produtos = new();
    private int _proximoId = 1;
    public ProdutoRepository()
    {
        Adicionar(new Produto
        {
            Nome = "Notebook",
            Descricao = "Notebook com 16 GB de memória RAM",
            Preco = 4500.00m,
            QuantidadeEstoque = 10,
            Ativo = true
        });
        Adicionar(new Produto
        {
            Nome = "Mouse",
            Descricao = "Mouse óptico sem fio",
            Preco = 89.90m,
            QuantidadeEstoque = 25,
            Ativo = true
        });
    }
    public IReadOnlyCollection<Produto> ListarTodos()
        => _produtos.AsReadOnly();
    public Produto? BuscarPorId(int id)
        => _produtos.FirstOrDefault(p => p.Id == id);
    public Produto Adicionar(Produto produto)
    {
        produto.Id = _proximoId++;
        _produtos.Add(produto);
        return produto;
    }
    public bool Remover(Produto produto)
        => _produtos.Remove(produto);
}