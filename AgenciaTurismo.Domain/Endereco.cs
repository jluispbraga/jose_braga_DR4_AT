using System.ComponentModel.DataAnnotations;

namespace AgenciaTurismo.Domain.Entities;

public class Endereco
{
    public int Id { get; set; }

    [Required(ErrorMessage = "Rua é obrigatória.")]
    public string Rua { get; set; } = string.Empty;

    [Required(ErrorMessage = "Cidade é obrigatória.")]
    [MinLength(3, ErrorMessage = "Cidade deve ter pelo menos 3 caracteres.")]
    public string Cidade { get; set; } = string.Empty;
}