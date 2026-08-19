using ApiProdutos.DTOs;
using ApiProdutos.Models;
using ApiProdutos.Repositories;
using Microsoft.AspNetCore.Mvc;
namespace ApiProdutos.Controllers;
[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private readonly ProdutoRepository _repository;
    public ProdutosController(ProdutoRepository repository)
    {
        _repository = repository;
    }
    /// <summary>Retorna todos os produtos.</summary>
    [HttpGet]
    public ActionResult<IEnumerable<Produto>> ListarTodos()
    {
        return Ok(_repository.ListarTodos());
    }
    /// <summary>Busca um produto por ID.</summary>
    [HttpGet("{id:int}")]
    public ActionResult<Produto> BuscarPorId(int id)
    {
        var produto = _repository.BuscarPorId(id);
        if (produto is null)
            return NotFound(new { mensagem = $"Produto com ID {id} não encontrado." });
        return Ok(produto);
    }
    
    /// <summary>Cadastra um novo produto.</summary>
    [HttpPost]
    public ActionResult<Produto> Cadastrar([FromBody] CriarProdutoDto dados)
    {
        var produto = new Produto
        {
            Nome = dados.Nome,
            Descricao = dados.Descricao,
            Preco = dados.Preco,
            QuantidadeEstoque = dados.QuantidadeEstoque,
            Ativo = true
        };
        _repository.Adicionar(produto);
        return CreatedAtAction(nameof(BuscarPorId),
            new { id = produto.Id }, produto);
    }
    /// <summary>Atualiza um produto.</summary>
    [HttpPut("{id:int}")]
    public IActionResult Atualizar(int id, [FromBody] AtualizarProdutoDto dados)
    {
        var produto = _repository.BuscarPorId(id);
        if (produto is null) return NotFound();
        produto.Nome = dados.Nome;
        produto.Descricao = dados.Descricao;
        produto.Preco = dados.Preco;
        produto.QuantidadeEstoque = dados.QuantidadeEstoque;
        produto.Ativo = dados.Ativo;
        return NoContent();
    }
    /// <summary>Exclui um produto.</summary>
    [HttpDelete("{id:int}")]
    public IActionResult Excluir(int id)
    {
        var produto = _repository.BuscarPorId(id);
        if (produto is null) return NotFound();
        _repository.Remover(produto);
        return NoContent();
    }
}