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
    public IActionResult Listar([FromQuery] string? email, [FromQuery] string? senha)
    {
        var usuarios = _usuarioRepository.Listar();

        if (!string.IsNullOrEmpty(email))
        {
            usuarios = usuarios.Where(u => u.Email == email).ToList();
        }

        if (!string.IsNullOrEmpty(senha))
        {
            usuarios = usuarios.Where(u => u.Senha == senha).ToList();
        }

    return Ok(usuarios);
}

}