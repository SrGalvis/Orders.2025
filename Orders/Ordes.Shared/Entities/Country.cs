﻿using Orders.Shared.Entities;
using Orders.Shared.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Ordes.Shared.Entities;

public class Country : IEntityWithName
{
    public int Id { get; set; }

    [Display(Name = "Pais")]
    [MaxLength(100, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres.")]
    [Required(ErrorMessage = "El campo {0} es obligatorio.")]
    public string Name { get; set; } = null!;

    public ICollection<State>? States { get; set; }

    [Display(Name = "Estados/Departamentos")]
    public int StatesNumber => States == null || States.Count == 0 ? 0 : States.Count;
}