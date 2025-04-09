using API.Data;
using API.Models;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("api/usuario")]
public class UsuarioController : ControllerBase
{
    private readonly IUsuarioRepository _usuarioRepository;
    public UsuarioController(IUsuarioRepository usuarioRepository)
    {
        _usuarioRepository = usuarioRepository;
    }

    [HttpPost("cadastrar")]
    public IActionResult Cadastrar([FromBody] Usuario usuario)
    {
        // usuario.CriadoEM = DateTime.Now; // para corrigir o horário

        _usuarioRepository.Cadastrar(usuario);
        return Created("", usuario);
    }


    [HttpGet("listar")]
    public IActionResult Listar()
    {
        var usuarios = _usuarioRepository.Listar();
        return Ok(usuarios);
    }   
}