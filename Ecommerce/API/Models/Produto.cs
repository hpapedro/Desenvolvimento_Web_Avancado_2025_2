using System;

namespace API.Models;

public class Produto
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public DateTime CriadoEM { get; set; } = DateTime.Now;
}
