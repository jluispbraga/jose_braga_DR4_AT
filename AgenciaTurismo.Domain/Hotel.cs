using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AgenciaTurismo.Domain.Entities;

public class Hotel
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Nome do hotel é obrigatório.")]
    [MinLength(3, ErrorMessage = "Nome deve ter pelo menos 3 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required]
    public Endereco Endereco { get; set; } = new();
}