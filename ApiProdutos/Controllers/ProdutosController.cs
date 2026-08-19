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
}