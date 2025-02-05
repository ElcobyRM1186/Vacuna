﻿using System.ComponentModel.DataAnnotations;

namespace VacunaAPI.DTOs
{
    public class RecoverPasswordDTO
    {
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]
        [EmailAddress(ErrorMessage = "Debes introducir un email válido.")]
        public string Email { get; set; }
    }
}
