using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/produto")]
public class ProdutoController : ControllerBase
{
    private readonly IProdutoReposity _produtoRepository;
    public ProdutoController(IProdutoReposity produtoReposity)
    {
        _produtoRepository = produtoReposity;
    }

    [HttpPost("cadastrar")]
    public IActionResult Cadastrar
        ([FromBody] Produto produto)
    {
        // produto.CriadoEM = DateTime.Now;

        _produtoRepository.Cadastrar(produto);
        return Created("", produto);
    }
}